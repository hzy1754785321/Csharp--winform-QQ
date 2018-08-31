using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Server
{
	public partial class server : Form
	{
		public server()
		{
			InitializeComponent();
		}

		//public static server GetInstance()
		//{
		//	if (_instance == null)
		//	{
		//		_instance = new server();
		//	}
		//	return _instance;
		//}

		//public static server _instance = new server();

		private void StartServer_Click(object sender, EventArgs e)
		{
			try
			{
				if (StartServer.Text == "关闭服务器")
				{
					StartServer.Text = "开启服务器";
					this.Close();
				}
				else if (StartServer.Text == "开启服务器")
				{
					Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					IPAddress iP = IPAddress.Any;
					IPEndPoint point = new IPEndPoint(iP, Convert.ToInt32(port_text.Text));
					socketWatch.Bind(point);
					ShowMsg("监听成功!");
					socketWatch.Listen(10);
					Thread thread = new Thread(Listen);
					thread.IsBackground = true;
					thread.Start(socketWatch);
					ServerManager.InitDispatcher();
					StartServer.Text = "关闭服务器";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		Socket socketSend;
		public void Listen(object o)
		{
			//try
			//{
				Socket socketWatch = o as Socket;
				while (true)
				{
					socketSend = socketWatch.Accept();
					ShowMsg(socketSend.RemoteEndPoint + ":" + "连接成功");
					Thread r_thread = new Thread(Receive);
					r_thread.IsBackground = true;
					r_thread.Start(socketSend);
				}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
		}

		public void Receive(object o)
		{
			//try
			//{
				Socket socketSend = o as Socket;
				while (true)
				{
					byte[] buffer = new byte[1024 * 1024 * 3];
					int len = socketSend.Receive(buffer);
					if (len == 0)
					{
						break;
					}
					string str = Encoding.UTF8.GetString(buffer, 0, len);
					var msg = JsonConvert.DeserializeObject<Message>(str);
					//var msg = ToMessage(str)
					var count = msg.Value.Count;
					var funInfo = ServerManager.GetFunInfo(msg.key);
					var parseFun = funInfo.Split('.');
					string strClass = parseFun[0]+"."+parseFun[1];
					var callMethodName = parseFun[2];
					Type t;  
					object obj;  
					t = Type.GetType(strClass);    
					System.Reflection.MethodInfo method = t.GetMethod(callMethodName); 
					obj = System.Activator.CreateInstance(t);
					var value = new object[count];
					for (int i = 0; i < msg.Value.Count; i++)
					{
						value[i] = msg.Value[i];
					}
					Object result = new Object();
					if (count > 0)
					{
						result = method.Invoke(obj, value);
					}
					else
					{
						result = method.Invoke(obj, null);
					}
					string retStr = JsonConvert.SerializeObject(result);
					SendMessage(retStr);
				}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
		}

	

		//public static Message ToMessage(string message)
		//{
		//	if (string.IsNullOrEmpty(message))
		//	{
		//		Log.Error("message为空");
		//	}
		//	var args = message.Split(';');
		//	var msg = new Message
		//	{
		//		key = int.Parse(args[0])
		//	};
		//	for (int i = 1; i < args.Length; i++)
		//	{
		//		msg.Value.Add(args[i]);
		//	}
		//	return msg;
		//}

		public void SendMessage(string str)
		{
			byte[] buffer = Encoding.UTF8.GetBytes(str);
			socketSend.Send(buffer);
		}

		private void ServerForm_Load(object sender, EventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		public static bool Register(string name, string passwd)
		{
		//	ServerManager.AddDispatcher((int)Interface.register, System.Reflection.MethodBase.GetCurrentMethod().Name);
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				using (StreamReader sr = new StreamReader("d:\\user.txt", Encoding.GetEncoding("UTF-8")))
				{
					string line1;
					while ((line1 = sr.ReadLine()) != null)
					{
						var st = new char[] { ',' };
						var args = line1.Split(st, StringSplitOptions.RemoveEmptyEntries);
						int userId;
						string passwd1;
						userId = int.Parse(args[0]);
						passwd1 = args[1];
						var account = new UserAccount() { userId = userId, passwd = passwd1 };
						users.Add(account);
					}
					sr.Close();
				}
				var user = users.FirstOrDefault(t => t.userId == int.Parse(name));
				if (user != null)
				{
					Log.Error("用户账号已存在");
					return false;
				}
				
				using (var sw = new StreamWriter(@"d:\user.txt", true, Encoding.GetEncoding(@"UTF-8")))
				{
					var line = name + "," + passwd;
					sw.WriteLine(line);
					sw.Close();
					Log.Debug("注册完成");
					return true;
				}
			}
			else
			{
				Log.Error("账号或密码为空");
				return false;
			}
		}

		public static bool Login(string name, string passwd)
		{
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				using (StreamReader sr = new StreamReader("d:\\user.txt", Encoding.GetEncoding("UTF-8")))
				{
					string line1;
					while ((line1 = sr.ReadLine()) != null)
					{
						var st = new char[] { ',' };
						var args = line1.Split(st, StringSplitOptions.RemoveEmptyEntries);
						int userId;
						string passwd1;
						userId =int.Parse(args[0]);
						passwd1 = args[1];
						var account = new UserAccount() { userId = userId, passwd = passwd1 };
						users.Add(account);
					}
					sr.Close();
				}
				var user = users.FirstOrDefault(t => t.userId == int.Parse(name));
				if (user != null)
				{
					if (user.passwd == passwd)
					{
						Log.Debug("user:{0} 登录成功", user.userId);
						return true;
					}
					else
					{
						Log.Error("密码错误");
						return false;
					}
				}
				else
				{
					Log.Error("用户不存在");
					return false;
				}
			}
			else
			{
				Log.Error("用户名和密码不能为空");
				return false;
			}
		}

		private void showWindow_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index >= 0)
			{
				e.DrawBackground();
				Brush mybsh = Brushes.Black;
			//	MessageBox.Show(showWindow.Items[e.Index].ToString().Substring(0,2));
				if (showWindow.Items[e.Index].ToString().Substring(0,5) == "Error")
				{
					mybsh = Brushes.Red;
				}
				if (showWindow.Items[e.Index].ToString().Substring(0,5) == "Debug")
				{
					mybsh = Brushes.Blue;
				}
				e.DrawFocusRectangle();
				e.Graphics.DrawString(showWindow.Items[e.Index].ToString(), e.Font, mybsh, e.Bounds, StringFormat.GenericDefault);
			}
		}

		//public void AddShowWindow(string str)
		//{
		//	showWindow.Items.Add(str + "\r\n");
		//	ShowMsg(str + "\r\n");
		//}

		public static void ShowMsg(string msg)
		{
			showWindow.Items.Add(msg + "\r\n");
		}
	}

	public class Log
	{
		public static void Error(string content)
		{
			server.ShowMsg("Error:" + content);
		}
		public static void Error(string format, params object[] args)
		{
			var str = string.Format(format, args);
			server.ShowMsg("Error:" + str);
		}

		public static void Debug(string content)
		{
			server.ShowMsg("Debug:" + content);
		}

		public static void Debug(string format, params object[] args)
		{
			var str = string.Format(format, args);
			server.ShowMsg("Debug:" + str);
		}
	}

}

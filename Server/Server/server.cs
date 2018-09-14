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
using System.Data.SQLite;
using Backend;
namespace Server
{
	public partial class server : Form
	{
		public static string strAppPath = Application.StartupPath;
		public static string QQChatPath = @"\Data\QQChat.db3";
		public static string strPath = strAppPath + QQChatPath;
		public static Dictionary<int, UserInfo> activeUser = new Dictionary<int, UserInfo>();
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
					ServerManager.DataCheck();
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
					var s = new ServerUser.User();
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
					byte[] buffer = new byte[1024 * 1024 * 10];
					int len = socketSend.Receive(buffer);
					if (len == 0)
					{
						break;
					}
					string str = Encoding.UTF8.GetString(buffer, 0, len);
					var msg = JsonConvert.DeserializeObject<Message>(str);
					//var msg = ToMessage(str)
					var count = msg.Values.Count;
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
					for (int i = 0; i < msg.length.Count; i++)
					{
					var type = msg.Values[i].GetType();
					if (msg.length[i] == 0)
					{
						value[i] = msg.Values[i] as string;
					}
					else if (msg.length[i] == 1)
						value[i] = Convert.ToInt32(msg.Values[i]);
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

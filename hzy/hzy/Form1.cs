using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hzy
{

	public partial class Form1 : Form
	{
		public static string ipAddress = "192.168.0.103";
		public static string port = "36001";
		public static Thread thread;
		public static Dictionary<int, string> _message = new Dictionary<int, string>();
		public delegate void NotifyEventHandler(object sender);
		public static NotifyEventHandler NotifyEvent;
		public Form1()
		{
			InitializeComponent();
			string HostName = Dns.GetHostName(); 
			IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
			for (int i = 0; i < IpEntry.AddressList.Length; i++)
			{

				if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
				{
					ipAddress = IpEntry.AddressList[i].ToString();
					MessageBox.Show(ipAddress);
				}
			}
			startConnect();
		}

			private void login(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(name.Text) || !string.IsNullOrEmpty(passwd.Text))
			{
				List<object> userStr = new List<object>();
				userStr.Add(int.Parse(name.Text));
				userStr.Add(passwd.Text);
				SendMessage((int)Interface.login, userStr);
				string result;
				while (true)
				{
					if (_message.TryGetValue((int)Interface.login, out result))
					{
						_message.Remove((int)Interface.login);
						break;
					}
				}
				if (string.IsNullOrEmpty(result))
				{
					MessageBox.Show("登陆失败,账号不存在或密码错误!");
					return;
				}
				var userInfo = JsonConvert.DeserializeObject<UserInfo>(result);
				MessageBox.Show("登陆成功,欢迎使用");
				UserHomeStart(userInfo);
			}
			else
			{
				MessageBox.Show("账号与密码不能为空!");
				return;
			}
		}

		public static Socket socketSend;
		public  void startConnect()
		{
			//	try
			//	{
			while (true)
			{
				try
				{
					socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					IPAddress ip = IPAddress.Parse(Form1.ipAddress);
					IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Form1.port));
					socketSend.Connect(point);
					Thread r_thread = new Thread(Received);
					r_thread.IsBackground = true;
					r_thread.Start();
					MessageBox.Show("连接成功！");
					break;
				}
				catch (Exception)
				{
					continue;
				}
			}
	//		}
	//		catch (Exception)
	//		{
	//			MessageBox.Show("IP或端口错误,无法连接服务器");
	//		}
		}

	
		  
		public void Received()
		{
			while (true)
			{
				byte[] buffer = new byte[1024 * 1024 * 3];
				int len = socketSend.Receive(buffer);
				if (len == 0)
				{
					break;
				}
				string str = Encoding.UTF8.GetString(buffer, 0, len);
				var ret = JsonConvert.DeserializeObject<Result>(str);
				if (ret.retKey == (int)Interface.message)
				{
					UserHome._msg = JsonConvert.DeserializeObject<ChatMessage>(ret.Value);
					AddObserver(new NotifyEventHandler(Chat.SetNewMessage));
					Updates();
					continue;
				}
				_message.Add(ret.retKey, ret.Value);
			}
		}

		public static void AddObserver(NotifyEventHandler ob)
		{
			NotifyEvent += ob;
		}
		public static void RemoveObserver(NotifyEventHandler ob)
		{
			NotifyEvent -= ob;
		}

		public void Updates()
		{
			NotifyEvent?.Invoke(this);
		}

		//public static void SetNewMessage(Object obj)
		//{
		//	var newMsg = UserHome._msg;
		//	MessageBox.Show(UserHome._msg.content);
		//	RemoveObserver(new NotifyEventHandler(SetNewMessage));
		//}


		public static void SendMessage(int key,List<object> content)
		{
			var msg = new Message() { key = key, Values = new List<object>(), length = new List<int>() };
			for (int i = 0; i < content.Count(); i++)
			{
				if (content[i] is int)
				{
					msg.Values.Add(content[i]);
					msg.length.Add(1);
				}
				else if (content[i] is string)
				{
					msg.Values.Add(content[i]);
					msg.length.Add(0);
				}
			}
			var sendMsg = JsonConvert.SerializeObject(msg);
			byte[] buffer = new byte[1024 * 1024 * 3];
			buffer = Encoding.UTF8.GetBytes(sendMsg);
			socketSend.Send(buffer);
		}

		public void register(object sender, EventArgs e)
		{
			var registerForm = new RegisterForm();
			registerForm.MdiParent = this.MdiParent;
			registerForm.Show();
			this.Hide();
		}

		public void UserHomeStart(UserInfo info)
		{
			var userHome = new UserHome();
			userHome._mineInfo = info;
			userHome.InitUserHome(info);
			userHome.MdiParent = this.MdiParent;
			userHome.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}	
	
}

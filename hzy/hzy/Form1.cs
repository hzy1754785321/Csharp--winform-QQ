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
		public static string ipAddress = "192.168.8.190";
		public static string port = "36001";
		public Form1()
		{
			InitializeComponent();
		}
		private void login(object sender, EventArgs e)
		{
			//var userAccount = new UserAccount() { name = name.Text, passwd = passwd.Text };
			//	var userStr = JsonConvert.SerializeObject(userAccount);
			List<object> userStr = new List<object>();
			userStr.Add(int.Parse(name.Text));
			userStr.Add(passwd.Text);
			SendMessage((int)Interface.login, userStr);
			var task = new Task<string>(Received);
			task.Start();
			task.Wait();
			var receiveStr = task.Result;
			var result = JsonConvert.DeserializeObject<Result>(receiveStr);
			var userInfo = new UserInfo();
			userInfo = JsonConvert.DeserializeObject<UserInfo>(result.Value);
			if (result.ret == 1)
			{
				MessageBox.Show("登陆成功,欢迎使用"); 
				UserHomeStart(userInfo);
			}
			else if (result.ret == 0)
			{
				MessageBox.Show("登陆失败,账号不存在!");
				return;
			}
			else if (result.ret == -1)
			{
				MessageBox.Show("登陆失败,密码错误");
				return;
			}
			else if (result.ret == -2)
			{
				MessageBox.Show("登陆失败,账号或密码为空");
				return;
			}
		}

		public static Socket socketSend;
		public  void startConnect(object sender, EventArgs e)
		{
			try
			{
				socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				IPAddress ip = IPAddress.Parse(Form1.ipAddress);
				IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Form1.port));
				socketSend.Connect(point); 
				MessageBox.Show("连接成功！");
			}
			catch (Exception)
			{
				MessageBox.Show("IP或端口错误,无法连接服务器");
			}
		}
		  
		public static string Received()
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
				return str;
			}
			return null;
		}

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
			byte[] buffer = new byte[1024 * 1024 * 10];
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

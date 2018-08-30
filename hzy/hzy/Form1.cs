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
		public static string ipAddress = "192.168.8.188";
		public static string port = "36001";
		public Form1()
		{
			InitializeComponent();
		}
		private void login(object sender, EventArgs e)
		{
			//var userAccount = new UserAccount() { name = name.Text, passwd = passwd.Text };
			//	var userStr = JsonConvert.SerializeObject(userAccount);
			List<string> userStr = new List<string>();
			userStr.Add(name.Text);
			userStr.Add(passwd.Text);
			SendMessage((int)Interface.login, userStr);
			var task = new Task<string>(Received);
			task.Start();
			task.Wait();
			var receiveStr = task.Result;
			var isSuccess = JsonConvert.DeserializeObject<Boolean>(receiveStr);
			if (isSuccess)
			{
				MessageBox.Show("登陆成功!");
				UserHomeStart();
			}
			else
			{
				MessageBox.Show("登陆失败,账号或密码错误");
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

		public static void SendMessage(int key,List<string> content)
		{
			var msg = new Message() { key = key, Value = new List<string>() };
			for (int i = 0; i < content.Count(); i++)
			{ 
				msg.Value.Add(content[i]);
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

		public void UserHomeStart()
		{
			var userHome = new UserHome();
			userHome.MdiParent = this.MdiParent;
			userHome.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}	
	
}

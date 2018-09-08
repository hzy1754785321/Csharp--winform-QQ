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
using Newtonsoft.Json;

namespace hzy
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		public void register(object sender, EventArgs s)
		{
			if (string.IsNullOrEmpty(userId.Text) && string.IsNullOrEmpty(name.Text) &&string.IsNullOrEmpty(passwd.Text))
			{
				MessageBox.Show("账号与密码不能为空!");
				return;
			}
			var content = new List<object>();
			content.Add(int.Parse(userId.Text));
			content.Add(name.Text);
			content.Add(passwd.Text);
			Form1.SendMessage((int)Interface.register, content);
			var task = new Task<string>(Form1.Received);
			task.Start();
			task.Wait();
			var receiveStr = task.Result;
		//	var isSuccess = JsonConvert.DeserializeObject<Boolean>(receiveStr);
			//if (isSuccess)
			//{
			//	MessageBox.Show("注册成功!");
			//}
			//else
			//{
			//	MessageBox.Show("注册失败，请重试!");
			//}
		}

		private void backLogin(object sender, EventArgs e)
		{
			var loginForm = new Form1();
			loginForm.MdiParent = this.MdiParent;
			loginForm.Show();
			this.Hide();
		}
	}
}

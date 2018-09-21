using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace hzy
{
	public partial class Chat : Form
	{
		public UserInfo mineInfo = new UserInfo();
		public UserInfo targetInfo = new UserInfo();
		public Chat()
		{
			InitializeComponent();
		}

		public void SendChatMessage(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				List<object> userStr = new List<object>();
				var msg = new ChatMessage();
				msg.chatId = mineInfo.userId;
				msg.targetId = targetInfo.userId;
				msg.content = chatBox.Text;
				msg.time = DateTime.Now;
				userStr.Add(JsonConvert.SerializeObject(msg));
				Form1.SendMessage((int)Interface.message, userStr);
			}
		}

		private void Chat_Load(object sender, EventArgs e)
		{

		}

		private void SendChatMessage(object sender, EventArgs e)
		{
			List<object> userStr = new List<object>();
			var msg = new ChatMessage();
			msg.chatId = mineInfo.userId;
			msg.targetId = targetInfo.userId;
			msg.content = chatBox.Text;
			msg.time = DateTime.Now;
			userStr.Add(JsonConvert.SerializeObject(msg));
			Form1.SendMessage((int)Interface.message, userStr);
		}

		public void CloseChat(object sender, EventArgs e)
		{
			this.Close();
			UserHome.localForm.MdiParent = this.MdiParent;
			UserHome.localForm.Show();
		}
	}
}

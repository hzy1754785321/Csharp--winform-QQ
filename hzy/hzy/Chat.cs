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
		public static UserInfo targetInfo = new UserInfo();
		public Chat()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
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
                msg.name = mineInfo.name;
				userStr.Add(JsonConvert.SerializeObject(msg));
				chatListBox.Font = new Font(this.Font.FontFamily, 20); 
				chatListBox.Items.Add("我:" + msg.content + "\r\n");
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
            msg.name = mineInfo.name;
			userStr.Add(JsonConvert.SerializeObject(msg));
			chatListBox.Font = new Font(this.Font.FontFamily, 20);
			chatListBox.Items.Add(targetInfo.name + ":" +msg.content + "\r\n");
			Form1.SendMessage((int)Interface.message, userStr);
		}

		public static void SetNewMessage(Object obj)
		{
			var newMsg = UserHome._msg;
			if (newMsg.targetId == targetInfo.userId)
			{
				var sendPeople = targetInfo.name + ":" + "\r\n";
				chatListBox.Items.Add(sendPeople + newMsg.content + "\r\n");
				MessageBox.Show(UserHome._msg.content);
				Form1.RemoveObserver(new Form1.NotifyEventHandler(SetNewMessage));
			}
			
		}

		public void ShowChatMessage()
		{
			
		}

		public void CloseChat(object sender, EventArgs e)
		{
			this.Close();
			UserHome.localForm.MdiParent = this.MdiParent;
			UserHome.localForm.Show();
		}
	}
}

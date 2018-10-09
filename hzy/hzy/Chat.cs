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
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace hzy
{
	public partial class Chat : Form
	{
        const int WM_COPYDATA = 0x004A;
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

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_COPYDATA:
                    COPYDATASTRUCT mystr = new COPYDATASTRUCT();
                    Type mytype = mystr.GetType();
                    mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
                    var musicName = Path.GetFileName(mystr.lpData);
                    var name = musicName.Split('.');
                    if (mystr.type == 0)
                    {
                        string str = string.Format("有人分享了一首:{0} 给你，要去听听吗？", name[0]);
                        DialogResult dr = MessageBox.Show(str, "音乐分享", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            try
                            {

                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = @"C:\Users\ychi\source\repos\music\musicApp\musicApp\bin\Debug\musicApp.exe";
                                startInfo.Arguments = mystr.lpData;
                                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                                Process.Start(startInfo);
                            }
                            catch (Exception ex)
                            {
                                throw;
                            }
                        }
                        else if (dr == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else if (mystr.type == 1)
                    {
                        string str = string.Format("有人分享视频:{0} 给你，要去看看吗？", name[0]);
                        DialogResult dr = MessageBox.Show(str, "视频分享", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            try
                            {
                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = @"C:\Users\ychi\source\repos\music\musicApp\musicApp\bin\Debug\musicApp.exe";
                                startInfo.Arguments = mystr.lpData + " " + 1;
                                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                                Process.Start(startInfo);
                            }
                            catch (Exception ex)
                            {
                                throw;
                            }
                        }
                        else if (dr == DialogResult.No)
                        {
                            return;
                        }
                    }

                    //      chatListBox.Items.Add(content + "\r\n");
                    //     this.textBox1.Text = mystr.lpData;
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }


        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public int type; // 0:音乐 1:视频
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
    }
}

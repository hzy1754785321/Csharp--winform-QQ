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
using System.Collections;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Sockets;

namespace hzy
{

	public partial class UserHome : Form
	{
		private ContextMenuStrip onlyfornumber;
		private ContextMenuStrip setting;
		public UserInfo _mineInfo;
		public static Form localForm;

        public static List<GroupInfo> _group = new List<GroupInfo>();
		
		public static AutoResetEvent _mre = new AutoResetEvent(false);

		public static ChatMessage _msg { set; get; }
        public static ChatMessage _groupMsg { set; get; }

		private bool _isFirstClick = true;
		private bool _isDoubleClick = false;
		private int _milliseconds = 0;
		private System.Windows.Forms.Timer _doubleClickTimer;
		private Rectangle _doubleRec;



	
		public UserHome()
		{
			InitializeComponent();
			localForm = this;
			onlyfornumber = new ContextMenuStrip();
			onlyfornumber.Items.Add("选择图片");
			onlyfornumber.Items[0].Click += SelectPhoto;
			UserPhoto.ContextMenuStrip = onlyfornumber;

			setting = new ContextMenuStrip();
			setting.Items.Add("添加好友");
			setting.Items.Add("加入群聊");
            setting.Items.Add("创建群聊");
			setting.Items[0].Click += FindFriend;
			setting.Items[1].Click += FindGroup;
            setting.Items[2].Click += CreateGroup;

			Setting.ContextMenuStrip = setting;

			_doubleClickTimer = new System.Windows.Forms.Timer();
			_doubleClickTimer.Interval = 100;
			_doubleClickTimer.Tick += new EventHandler(StartChat);
		}

		public void InitUserHome(UserInfo user)
		{
			userName.Text = user.name;
			if (!string.IsNullOrEmpty(user.signature))
			{
				signature.Text = user.signature;
			}
			if (user.photo != null)
			{
				var photoByte = Convert.FromBase64String(user.photo);
				var ts = new MemoryStream(photoByte);
				ts.Position = 0;
				var img = Image.FromStream(ts);
				UserPhoto.Image = img;
				ts.Close();
			}
		}

		public void CheckPopUP()
		{
			int temp = 0;
			if (_mineInfo.ext != null)
			{
				if (_mineInfo.ext.type != null)
				{
					for (int i = 0; i < _mineInfo.ext.type.Count; i++)
					{
						while (_mineInfo.ext.type[(int)PopType.friend] > 0)
						{
							PopUp(_mineInfo.ext.friendApply[temp]);
							temp++;
						}
					}
				}
			}
		}

		public void PopUp(int userId)
		{
			string str = string.Format("用户:" + userId + " 请求加你为好友，是否同意？");
			DialogResult dr = MessageBox.Show(str,"好友申请", MessageBoxButtons.YesNoCancel);

			if (dr == DialogResult.Yes)
			{
				_mineInfo.ext.type[(int)PopType.friend]--;
				_mineInfo.ext.friendApply.Remove(userId);
				var fInfo = new FriendInfo();
				fInfo.friendId = userId;
				if (_mineInfo.friend == null)
					_mineInfo.friend = new List<FriendInfo>();
				_mineInfo.friend.Add(fInfo);
				List<object> userStr = new List<object>();
				userStr.Add(JsonConvert.SerializeObject(_mineInfo));
				userStr.Add(userId);
				Form1.SendMessage((int)Interface.friendSuccess, userStr);
			}
			else if (dr == DialogResult.No)
			{
				_mineInfo.ext.type[(int)PopType.friend]--;
				_mineInfo.ext.friendApply.Remove(userId);
				List<object> userStr = new List<object>();
                userStr.Add(JsonConvert.SerializeObject(_mineInfo));
				Form1.SendMessage((int)Interface.userInfoSave, userStr);
			}
			else if (dr == DialogResult.Cancel)
			{
				return;
			}
		}

        public static void CloseMain(int userId)
        {
            var userStr = new List<object>();
            userStr.Add(userId);
            Form1.SendMessage((int)Interface.loginOut, userStr);
            Form1.rece_thread.Abort();
            
            localForm.Close();
        }

        public void CloseChoose(object sender, FormClosingEventArgs e)
        {
            CloseForm closeForm = new CloseForm();
            closeForm.Location = this.Location;
            closeForm._userId = _mineInfo.userId;
            closeForm.Show();
        }

        public static void NoCloseMain()
        {
            localForm.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        public void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        private void SetNewPhoto(object sender, MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Button == MouseButtons.Right)
			{
				choosePhoto.Show(this, e.Location);
			}
		}
		MemoryStream ms;
		public void SelectPhoto(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string extension = Path.GetExtension(fileDialog.FileName);
				string[] str = new string[] { ".gif", ".jpge", ".jpg" };
				if (!((IList)str).Contains(extension))
				{
					MessageBox.Show("仅能上传gif,jpge,jpg格式的图片！");
				}
				else
				{
					FileInfo fileInfo = new FileInfo(fileDialog.FileName);
					if (fileInfo.Length > 20480)
					{
						MessageBox.Show("上传的图片不能大于20K");
					}
					else
					{
						UserPhoto.Image = Image.FromFile(fileDialog.FileName);
						ms = new MemoryStream();
						Image bi = UserPhoto.Image;
						bi.Save(ms, UserPhoto.Image.RawFormat);

						var arr = ms.ToArray();
						var sendArr = Convert.ToBase64String(arr);
						ms.Position = 0;
						ms.Close();
						List<object> userStr = new List<object>();
						userStr.Add(_mineInfo.userId);
						userStr.Add(sendArr);
						Form1.SendMessage((int)Interface.setPhoto, userStr);
					}
				}
			}
		}

		public void EntryName(object sender, EventArgs e)
		{
			entryMyName.Visible = true;
		}
		public void EntrySign(object sender, EventArgs e)
		{
			signText.Visible = true;
		}


		public void CloseChild(object sender, EventArgs e)
		{
			if (entryMyName.Visible)
				entryMyName.Visible = false;
			if (signText.Visible)
				signText.Visible = false;
		}

		private void SetMySign(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				entryMyName.Visible = false;
				signature.Text = entryMyName.Text;
				List<object> userStr = new List<object>();
				userStr.Add(_mineInfo.userId);
				userStr.Add(signature.Text);
				Form1.SendMessage((int)Interface.setSign, userStr);
			}
		}

		private void SetMyName(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				entryMyName.Visible = false;
				userName.Text = entryMyName.Text;
				List<object> userStr = new List<object>();
				userStr.Add(_mineInfo.userId);
				userStr.Add(userName.Text);
				Form1.SendMessage((int)Interface.setName, userStr);
			}
		}
		public class ButtonEx : CCWin.SkinControl.SkinButton
		{
			public new event EventHandler DoubleClick;
			DateTime clickTime;
			bool isClicked = false;
			protected override void OnClick(EventArgs e)
			{
				base.OnClick(e);
				if (isClicked)
				{
					TimeSpan span = DateTime.Now - clickTime;
					if (span.Milliseconds < SystemInformation.DoubleClickTime)
					{
						DoubleClick(this, e);
						isClicked = false;
					}
				}
				else
				{
					isClicked = true;
					clickTime = DateTime.Now;
				}
			}
		}

		private void mineInfo_MouseDown(object sender, MouseEventArgs e)
		{
			if (_isFirstClick)
			{
				_doubleRec = new Rectangle(e.X - SystemInformation.DoubleClickSize.Width / 2,
					e.Y - SystemInformation.DoubleClickSize.Height / 2,
					SystemInformation.DoubleClickSize.Width,
					SystemInformation.DoubleClickSize.Height);
				_isFirstClick = false;
				_doubleClickTimer.Start();
			}
			else
			{
				if (_doubleRec.Contains(e.Location))
				{
					_isDoubleClick = true;
				}
			}
		}

		public static UserInfo QueryUserInfo(int userId)
		{
			List<object> userStr = new List<object>();
			userStr.Add(userId);
			Form1.SendMessage((int)Interface.userInfo, userStr);
			string result;
			while (true)
			{
				if (Form1._message.TryGetValue((int)Interface.userInfo, out result))
				{
					Form1._message.Remove((int)Interface.userInfo);
					break;
				}
			}
			try
			{
				var userInfo = JsonConvert.DeserializeObject<UserInfo>(result);
				return userInfo;
			}
			catch (Exception)
			{
				return null;
			}
		}

        public static GroupInfo QueryGroupInfo(int groupId)
        {
            List<object> userStr = new List<object>();
            userStr.Add(groupId);
            Form1.SendMessage((int)Interface.groupInfo, userStr);
            string result;
            while (true)
            {
                if (Form1._message.TryGetValue((int)Interface.groupInfo, out result))
                {
                    Form1._message.Remove((int)Interface.groupInfo);
                    break;
                }
            }
            try
            {
                var groupInfo = JsonConvert.DeserializeObject<GroupInfo>(result);
                return groupInfo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ShowMenu(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Button == MouseButtons.Left)
			{
				Menu.Show(this, e.Location);
			}
		}

		public void FindFriend(object sender, EventArgs e)
		{
			AddFriend addFriend = new AddFriend();
			addFriend.Location = this.Location;
			addFriend.mineId = _mineInfo.userId;
			addFriend.Show();
		}
	
		public void FindGroup(object sender, EventArgs e)
		{
			AddGroup addGroup = new AddGroup();
			addGroup.Location = this.Location;
			addGroup.mineId = _mineInfo.userId;
			addGroup.Show();
		}

        public void CreateGroup(object sender, EventArgs e)
        {
            CreateGroup createGroup = new CreateGroup();
            createGroup.Location = this.Location;
            createGroup._mineId = _mineInfo.userId;
            createGroup.Show();
        }

		public void StartChat(object sender, EventArgs e)
		{
			_milliseconds += 100;
			if (_milliseconds >= SystemInformation.DoubleClickTime)
			{
				_doubleClickTimer.Stop();
				if (_isDoubleClick)
				{
					var chat = new Chat();
					chat.MdiParent = this.MdiParent;
					chat.Show();
					this.Hide();
					chat.mineInfo = _mineInfo;
					Chat.targetInfo = QueryUserInfo(666);
				}
				else
				{
					return;
				}
				_isDoubleClick = false;
				_isFirstClick = true;
				_milliseconds = 0;
			}
		}

        private void groupButton_Click(object sender, EventArgs e)
        {
            skinPanel1.Visible = false;
            friendTitle.Visible = false;
            familyTitle.Visible = false;
            workTitle.Visible = false;
            _mineInfo = QueryUserInfo(_mineInfo.userId);
            if (_mineInfo.groupId == null)
                _mineInfo.groupId = new List<int>();
            for (int i = 0; i < _mineInfo.groupId.Count; i++)
            {
                _group.Add(QueryGroupInfo(_mineInfo.groupId[i]));
            }
            int count = _group.Count;
            if (count == 0)
            {
                MessageBox.Show("你尚未加入群");
                return;
            }
            if (count >= 1)
            {
                groupName1.Text = _group[0].groupName;
                groupButton1.Visible = true;
            }
            if (count >= 2)
            {
                groupName2.Text = _group[1].groupName;
                groupButton2.Visible = true;
            }

            //Group group = new Group();
            //group.Location = this.Location;
            //group._groupId = 544823;
            //group.mineInfo = _mineInfo;
            //group.InitGroupInfo();
            //group.Show();
        }

    }
}

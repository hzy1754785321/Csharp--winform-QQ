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

namespace hzy
{
	public partial class AddFriend : Form
	{
		public int mineId;
		public AddFriend()
		{
			InitializeComponent();
		}

		public void Search(object sender, EventArgs e)
		{
			if (!IsInt(searchText.Text))
			{
				MessageBox.Show("请输入正确的用户ID!");
				return;
			}
			var userInfo = UserHome.QueryUserInfo(Convert.ToInt32(searchText.Text));
			if (userInfo == null)
			{
				MessageBox.Show("该用户不存在！");
				return;
			}
			friendID.Text = userInfo.userId.ToString();
			friendID.Visible = true;
			friendName.Text = userInfo.name;
			friendName.Visible = true;
			if (!string.IsNullOrEmpty(userInfo.signature))
			{
				friendSign.Text = userInfo.signature;
				friendSign.Visible = true;
			}
			else
			{
				friendSign.Text = "这个人很懒,什么都没写";
			}
			friendSign.Visible = true;
			if (!string.IsNullOrEmpty(userInfo.photo))
			{
				var photoByte = Convert.FromBase64String(userInfo.photo);
				var ts = new MemoryStream(photoByte);
				ts.Position = 0;
				var img = Image.FromStream(ts);
				friendPhoto.Image = img;
				ts.Close();
				friendPhoto.Visible = true;
			}
		}

		public void AddFriendApply(object sender, EventArgs e)
		{
			List<object> userStr = new List<object>();
			userStr.Add(mineId);
			userStr.Add(Convert.ToInt32(searchText.Text));
			Form1.SendMessage((int)Interface.friendApply, userStr);
			MessageBox.Show("发送好友申请成功");
		}

		public static bool IsInt(string str)
		{
			try
			{
				int a = Convert.ToInt32(str);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hzy
{
	public partial class AddGroup : Form
	{
		public int mineId;
		public AddGroup()
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
            var groupInfo = UserHome.QueryGroupInfo(Convert.ToInt32(searchText));
            if (groupInfo == null)
            {
                MessageBox.Show("该群不存在");
                return;
            }
            searchInfo.Visible = true;
            groupNumber.Text = groupInfo.groupId.ToString();
            groupNumber.Visible = true;
            groupName.Text = groupInfo.groupName;
            groupName.Visible = true;
            groupAdmin.Text = groupInfo.master.ToString();
            groupAdmin.Visible = true;
            groupMember.Text = groupInfo.groupMember.Count.ToString();
            groupMember.Visible = true;
            groupSynopsis.Text = groupInfo.groupSynopsis;
            groupSynopsis.Visible = true;
		}

        public void AddGroupApply(object sender, EventArgs e)
        {
            List<object> userStr = new List<object>();
            userStr.Add(mineId);
            userStr.Add(Convert.ToInt32(searchText.Text));
            Form1.SendMessage((int)Interface.joinGroup, userStr);
            MessageBox.Show("发送申请成功,请等待审核");
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

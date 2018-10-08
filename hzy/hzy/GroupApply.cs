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
    public partial class GroupApply : Form
    {
        public int _groupId;
        public GroupApply()
        {
            InitializeComponent();
        }

        public void InitGroupApply()
        {
            var groupInfo = UserHome.QueryGroupInfo(_groupId);
            if (groupInfo.apply == null)
                groupInfo.apply = new List<int>();
            for (int i = 0; i < groupInfo.apply.Count; i++)
            {
                applyListBox.Font = new Font(this.Font.FontFamily, 18);
                applyListBox.Items.Add("ID:" + groupInfo.apply[i] + " 申请加入群聊");
            }
        }
    }


}

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
    public partial class CreateGroup : Form
    {
        public int _mineId;
        public CreateGroup()
        {
            InitializeComponent();
        }

        public void Create(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(groupName.Text) || string.IsNullOrEmpty(groupSynopsis.Text))
            {
                MessageBox.Show("内容不能为空，请重新输入！");
                return;
            }
            var userStr = new List<object>();
            userStr.Add(_mineId);
            userStr.Add(groupName.Text);
            userStr.Add(groupSynopsis.Text);
            Form1.SendMessage((int)Interface.createGroup, userStr);
            string result;
            while (true)
            {
                if (Form1._message.TryGetValue((int)Interface.createGroup, out result))
                {
                    Form1._message.Remove((int)Interface.createGroup);
                    break;
                }
            }
            var groupInfo = JsonConvert.DeserializeObject<GroupInfo>(result);
            MessageBox.Show("创建成功，群号为:{0}", groupInfo.groupId.ToString());
            UserHome._mineInfo.groupId.Add(groupInfo.groupId);
        }
    }
}

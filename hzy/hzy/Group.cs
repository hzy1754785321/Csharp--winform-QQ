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
    public partial class Group : Form
    {
        public int _groupId;
        public UserInfo mineInfo;
        public static GroupInfo mineGroup;
        public Group()
        {
            InitializeComponent();
        }


        public void InitGroupInfo()
        {
            var groupInfo = UserHome.QueryGroupInfo(_groupId);
            mineGroup = groupInfo;
            GroupName.Text = groupInfo.groupName;
            groupNotice.Text = "群简介:" + groupInfo.groupSynopsis;
            groupNumber.Text = "(" + groupInfo.groupMember.Count + ")";
            for (int i = 0; i < groupInfo.groupMember.Count; i++)
            {
                var user = UserHome.QueryUserInfo(groupInfo.groupMember[i]);
                groupMemberList.Items.Add(user.name);
            }
        }

        public void GroupChat(object sender,EventArgs e)
        {
            List<object> userStr = new List<object>();
            var msg = new ChatMessage();
            msg.chatId = mineInfo.userId;
            msg.targetId = 0;
            msg.content = groupText.Text;
            msg.time = DateTime.Now;
            msg.name = mineInfo.name;
            userStr.Add(JsonConvert.SerializeObject(msg));
            userStr.Add(_groupId);
            groupChatList.Font = new Font(this.Font.FontFamily, 20);
            groupChatList.Items.Add(mineInfo.name + ":" + msg.content + "\r\n");
            Form1.SendMessage((int)Interface.sendGroupMessage, userStr);
        }

        public void showApply(object sender,EventArgs e)
        {
            GroupApply groupApply = new GroupApply();
            groupApply.Location = this.Location;
            groupApply._groupId = _groupId;
            groupApply.InitGroupApply();
            groupApply.Show();
        }

        public static void SetNewMessage(Object obj)
        {
            var newMsg = UserHome._groupMsg;
            if (newMsg.targetId == 0)
            {
                mineGroup.historyChat.Add(newMsg);
                ShowAllMsg();
                Form1.RemoveObserver(new Form1.NotifyEventHandler(SetNewMessage));
            }
        }

        public static void ShowAllMsg()
        {
            groupChatList.Items.Clear();
            for (int i = 0; i < mineGroup.historyChat.Count; i++)
            {
                var sendPeople = mineGroup.historyChat[i].name + ":";
                groupChatList.Items.Add(sendPeople + mineGroup.historyChat[i].content + "\r\n");
            }
        }
    }
}

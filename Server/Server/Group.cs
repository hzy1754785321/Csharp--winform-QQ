using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.SQLite;
using Backend;
using Server;
using System.Net.Sockets;

namespace ServerUser
{
    public partial class Group
    {
        public Result CreateGroup(int userId, string groupName, string synopsis)
        {
            var ret = new Result
            {
                retKey = (int)Interface.createGroup
            };
            Random rand = new Random(Environment.TickCount);
            var now = DateTime.Now;
            int groupId = 0;
            var member = new List<int>();
            while (true)
            {
                groupId = rand.Next(100000, 999999);
                var info = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
                if (info == null)
                {
                    member.Add(userId);
                    DataStorage.SQLiteHelper.CreateGroupAsync(groupId, now, userId, groupName, synopsis, JsonConvert.SerializeObject(member));
                    break;
                }
            }
            if (User.userKey.TryGetValue(userId, out UserInfo userInfo))
            {
                if (userInfo.groupId == null)
                    userInfo.groupId = new List<int>();
                userInfo.groupId.Add(groupId);
                User.UpdateUserInfo(userInfo);
            }
            else
            {
                var user = DataStorage.SQLiteHelper.QueryUserInfo(userId);
                if (user.groupId == null)
                    user.groupId = new List<int>();
                user.groupId.Add(groupId);
                User.UpdateUserInfo(user);
            }
            Log.Debug("user:{0} createGroup:{1} success!", userId, groupId);
            var groupInfo = new GroupInfo { groupId = groupId, groupName = groupName, master = userId, groupMember = member, groupSynopsis = synopsis };
            ret.Value = JsonConvert.SerializeObject(groupInfo);
            return ret;
        }

        public void JoinGroup(int userId, int groupId)
        {
            var groupInfo = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
            if (groupInfo.apply == null)
                groupInfo.apply = new List<int>();
            groupInfo.apply.Add(userId);
            UpdateGroupInfo(groupInfo);
        }

        public void JoinGroupSuccess(int userId, int groupId)
        {
            var groupInfo = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
            groupInfo.groupMember.Add(userId);
            groupInfo.apply.Remove(userId);
            UpdateGroupInfo(groupInfo);
            var userInfo = DataStorage.SQLiteHelper.QueryUserInfo(userId);
            if (userInfo.groupId == null)
                userInfo.groupId = new List<int>();
            userInfo.groupId.Add(groupId);
            User.UpdateUserInfo(userInfo);
        }

        public void JoinGroupFailed(int userId, int groupId)
        {
            var groupInfo = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
            groupInfo.apply.Remove(userId);
            UpdateGroupInfo(groupInfo);
        }

        public Result QueryGroupInfo(int groupId)
        {
            var ret = new Result
            {
                retKey = (int)Interface.groupInfo
            };
            var info = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
            if (info == null)
            {
                ret.Value = null;
            }
            else
            {
                ret.Value = JsonConvert.SerializeObject(info);
            }
            return ret;
        }

        public void ChatWithGroup(string msg,int groupId)
        {
            var chatMessage = JsonConvert.DeserializeObject<ChatMessage>(msg);
            var groupInfo = DataStorage.SQLiteHelper.QueryGroupsInfo(groupId);
            if (groupInfo.historyChat == null)
                groupInfo.historyChat = new List<ChatMessage>();
            groupInfo.historyChat.Add(chatMessage);
            var member = groupInfo.groupMember;
            for (int i = 0; i < member.Count; i++)
            {
                if (member[i] == chatMessage.chatId)
                    continue;
                if (server.userConnections.TryGetValue(member[i], out Socket socket))
                {
                    var ret = new Result();
                    ret.retKey = (int)Interface.sendGroupMessage;
                    ret.Value = JsonConvert.SerializeObject(chatMessage);
                    var retStr = JsonConvert.SerializeObject(ret);
                    server.SendMessage(socket, retStr);
                }
            }
            UpdateGroupInfo(groupInfo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using Newtonsoft.Json;
using Server;

namespace ServerUser
{
	public partial class User
	{
		public static void UpdateUserInfo(UserInfo info)
		{
			DataStorage.SQLiteHelper.UpdateUserInfoAsync(info.userId, info.name, info.passwd, JsonConvert.SerializeObject(info.friend), JsonConvert.SerializeObject(info.historyId), info.photo, info.signature, info.CreateTime, info.lastActive,JsonConvert.SerializeObject(info.ext),JsonConvert.SerializeObject(info.groupId));
		}
	}

    public partial class Group
    {
        public static void UpdateGroupInfo(GroupInfo info)
        {
            DataStorage.SQLiteHelper.UpdateGroupAsync(info.groupId, info.groupName, info.groupSynopsis, JsonConvert.SerializeObject(info.historyChat), JsonConvert.SerializeObject(info.groupMember), info.master, JsonConvert.SerializeObject(info.admin), JsonConvert.SerializeObject(info.apply), info.createTime);
        }
    }
}

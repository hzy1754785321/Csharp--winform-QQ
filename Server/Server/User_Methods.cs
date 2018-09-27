using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using Server;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace ServerUser
{
	public partial class User
	{
		public void SetName(int userId, string name)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.name = name;
				UpdateUserInfo(userInfo);
			}
		}

		public void SetSign(int userId, string sign)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.signature = sign;
				UpdateUserInfo(userInfo);
			}
			else
			{
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
			}
		}

		public void SetPhoto(int userId, string photo)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.photo = photo;
				UpdateUserInfo(userInfo);
			}
		}

		public void ChatWithOther(string msg)
		{
			var chatMessage = JsonConvert.DeserializeObject<ChatMessage>(msg);
			if (server.userConnections.TryGetValue(chatMessage.targetId, out Socket socket))
			{
				var ret = new Result();
				ret.retKey = (int)Interface.message;
				ret.Value = JsonConvert.SerializeObject(chatMessage);
				var retStr = JsonConvert.SerializeObject(ret);
				server.SendMessage(socket, retStr);
			}
			else
			{
				var friend = new FriendInfo();
				friend.friendId = chatMessage.targetId;
				friend.history.Add(chatMessage);
				if (userKey.TryGetValue(chatMessage.chatId, out UserInfo userInfo))
				{
					userInfo.friend.Add(friend);
					userInfo.historyId.Add(chatMessage.targetId);
					UpdateUserInfo(userInfo);
				}
				else
				{
					var info = DataStorage.SQLiteHelper.QueryUserInfo(chatMessage.chatId);
					if (info != null)
					{
						info.friend.Add(friend);
						info.historyId.Add(chatMessage.targetId);
						UpdateUserInfo(info);
					}
				}
			}
		}

		public void AddFriendApply(int applyId, int frindId)
		{
			if (userKey.TryGetValue(frindId, out UserInfo friendInfo))
			{
				if (friendInfo.ext == null)
					friendInfo.ext = new Extend();
				if (friendInfo.ext.type == null)
					friendInfo.ext.type = new List<int>();
				if (friendInfo.ext.friendApply == null)
					friendInfo.ext.friendApply = new List<int>();
				try
				{
					friendInfo.ext.type[(int)PopType.friend]++;
				}
				catch (Exception)
				{
					friendInfo.ext.type.Add(0);
					friendInfo.ext.type[(int)PopType.friend]++;
				}
				friendInfo.ext.friendApply.Add(applyId);
				UpdateUserInfo(friendInfo);
			}
		}

		public void addFriendSuccess(string userInfo, int friendId)
		{
			var user = JsonConvert.DeserializeObject<UserInfo>(userInfo);
			if (userKey.TryGetValue(user.userId, out UserInfo temp))
			{
				userKey[user.userId] = user;
				UpdateUserInfo(user);
			}
			else
			{
				UpdateUserInfo(user);
			}

			if (userKey.TryGetValue(friendId, out UserInfo friend))
			{
				var newFriend = new FriendInfo();
				newFriend.friendId = user.userId;
				if (friend.friend == null)
					friend.friend = new List<FriendInfo>();
				friend.friend.Add(newFriend);
				UpdateUserInfo(friend);
			}
			else
			{
				var friendInfo = DataStorage.SQLiteHelper.QueryUserInfo(friendId);
				if (friendInfo != null)
				{
					var newFriend = new FriendInfo();
					newFriend.friendId = user.userId;
					if (friendInfo.friend == null)
						friendInfo.friend = new List<FriendInfo>();
					friendInfo.friend.Add(newFriend);
					UpdateUserInfo(friendInfo);
				}
			}
		}
	}
}

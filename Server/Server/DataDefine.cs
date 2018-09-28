using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
	[Serializable]
	public class UserAccount
	{
		public int userId;
		public string name;
		public string passwd;
		public UserAccount() { }
		public UserAccount(int userId,string name, string passwd)
		{
			this.userId = userId;
			this.name = name;
			this.passwd = passwd;
		}
		public static UserAccount Parse(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return null;
			}
			var args = str.Split(';');
			return new UserAccount() { userId = int.Parse(args[0]),name = args[1], passwd = args[2] };
		}
	}

	[Serializable]
	public class UserInfo
	{
		/// <summary>
		/// 用户ID
		/// </summary>
		public int userId;
		/// <summary>
		/// 昵称
		/// </summary>
		public string name;
		/// <summary>
		/// 好友
		/// </summary>
		public List<FriendInfo> friend;
		/// <summary>
		/// 最近聊天ID
		/// </summary>
		public List<int> historyId;
		/// <summary>
		/// 头像
		/// </summary>
		public string photo;
		/// <summary>
		/// 个性签名
		/// </summary>
		public string signature;
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime;
		/// <summary>
		/// 上次登录时间
		/// </summary>
		public DateTime lastActive;
		/// <summary>
		/// 密码
		/// </summary>
		public string passwd;
		/// <summary>
		/// 扩展通知
		/// </summary>
		public Extend ext;
		/// <summary>
		/// 加入的群
		/// </summary>
		public List<int> groupId;
	}

	[Serializable]
	public class Extend
	{
		/// <summary>
		/// 好友申请
		/// </summary>
		public List<int> friendApply;
		/// <summary>
		/// 类型
		/// </summary>
		public List<int> type;
	}

	[Serializable]
	public class FriendInfo
	{
		/// <summary>
		/// 好友Id
		/// </summary>
		public int friendId;
		/// <summary>
		/// 备注
		/// </summary>
		public string remark;
		/// <summary>
		/// 历史聊天记录
		/// </summary>
		public List<ChatMessage> history;
	}

	[Serializable]
	public class ChatMessage
	{
		/// <summary>
		/// 内容
		/// </summary>
		public string content;
		/// <summary>
		/// 发言者ID
		/// </summary>
		public int chatId;
		/// <summary>
		/// 目标ID 为0表示为群聊
		/// </summary>
		public int targetId;
		/// <summary>
		/// 发出时间
		/// </summary>
		public DateTime time;
	}

	[Serializable]
	public class GroupInfo
	{
		/// <summary>
		/// 群号
		/// </summary>
		public int groupId;
		/// <summary>
		/// 群名称
		/// </summary>
		public string groupName;
		/// <summary>
		/// 群简介
		/// </summary>
		public string groupSynopsis;
		/// <summary>
		/// 群成员
		/// </summary>
		public List<int> groupMember;
		/// <summary>
		/// 历史发言
		/// </summary>
		public List<ChatMessage> historyChat;
		/// <summary>
		/// 群主
		/// </summary>
		public int master;
		/// <summary>
		/// 管理员
		/// </summary>
		public List<int> admin;
		/// <summary>
		/// 入群申请
		/// </summary>
		public List<int> apply; 
	}


	[Serializable]
	public class Message
	{
		/// <summary>
		/// 执行函数
		/// </summary>
		public int key;
		/// <summary>
		/// 参数
		/// </summary>
		public List<object> Values;
		/// <summary>
		/// 传递参数内容
		/// </summary>
	//	public List<string> Value;
		/// <summary>
		/// 长度 0:string 1:int 2:byte[]
		/// </summary>
		public List<int> length;
	}

	[Serializable]
	public class Result
	{
		/// <summary>
		/// 执行结果   
		/// </summary>
		public int retKey;
		/// <summary>
		/// 返回字符内容
		/// </summary>
		public string Value;
	}
}

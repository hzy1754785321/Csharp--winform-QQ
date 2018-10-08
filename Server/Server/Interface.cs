using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	public enum Interface
	{
		/// <summary>
		/// 登陆
		/// </summary>
		login = 1,
		/// <summary>
		/// 注册
		/// </summary>
		register,
		/// <summary>
		/// 设置名字
		/// </summary>
		setName,
		/// <summary>
		/// 设置签名
		/// </summary>
		setSign,
		/// <summary>
		/// 设置头像
		/// </summary>
		setPhoto,
		/// <summary>
		/// 发送聊天信息
		/// </summary>
		message,
		/// <summary>
		/// 用户信息
		/// </summary>
		userInfo,
		/// <summary>
		/// 添加好友
		/// </summary>
		friendApply,
		/// <summary>
		/// 添加好友成功
		/// </summary>
		friendSuccess,
        /// <summary>
        /// 创建群
        /// </summary>
        createGroup,
        /// <summary>
        /// 加群申请
        /// </summary>
        joinGroup,
        /// <summary>
        /// 同意加群
        /// </summary>
        joinGroupSuccess,
        /// <summary>
        /// 拒绝加群
        /// </summary>
        joinGroupFailed,
        /// <summary>
        /// 群信息
        /// </summary>
        groupInfo,
        /// <summary>
        /// 保存用户信息
        /// </summary>
        userInfoSave,
        /// <summary>
        /// 发送群聊信息
        /// </summary>
        sendGroupMessage,
    }

	public enum PopType
	{
		/// <summary>
		/// 好友申请
		/// </summary>
		friend = 0,
	}
	
}

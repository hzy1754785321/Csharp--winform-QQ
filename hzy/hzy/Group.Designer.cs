namespace hzy
{
	partial class Group
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupMemberList = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupChatList = new System.Windows.Forms.ListBox();
			this.groupNotice = new System.Windows.Forms.Label();
			this.groupText = new CCWin.SkinControl.SkinTextBox();
			this.groupSend = new CCWin.SkinControl.SkinButton();
			this.groupClose = new CCWin.SkinControl.SkinButton();
			this.groupNumber = new System.Windows.Forms.Label();
			this.GroupName = new System.Windows.Forms.Label();
			this.groupSetting = new System.Windows.Forms.Button();
			this.groupMessage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// groupMemberList
			// 
			this.groupMemberList.FormattingEnabled = true;
			this.groupMemberList.ItemHeight = 12;
			this.groupMemberList.Location = new System.Drawing.Point(480, 246);
			this.groupMemberList.Name = "groupMemberList";
			this.groupMemberList.Size = new System.Drawing.Size(206, 376);
			this.groupMemberList.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(481, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "群成员";
			// 
			// groupChatList
			// 
			this.groupChatList.FormattingEnabled = true;
			this.groupChatList.ItemHeight = 12;
			this.groupChatList.Location = new System.Drawing.Point(1, 52);
			this.groupChatList.Name = "groupChatList";
			this.groupChatList.Size = new System.Drawing.Size(476, 400);
			this.groupChatList.TabIndex = 2;
			// 
			// groupNotice
			// 
			this.groupNotice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupNotice.Location = new System.Drawing.Point(483, 57);
			this.groupNotice.Name = "groupNotice";
			this.groupNotice.Size = new System.Drawing.Size(203, 162);
			this.groupNotice.TabIndex = 3;
			this.groupNotice.Text = "群公告";
			// 
			// groupText
			// 
			this.groupText.BackColor = System.Drawing.Color.Transparent;
			this.groupText.DownBack = null;
			this.groupText.Icon = null;
			this.groupText.IconIsButton = false;
			this.groupText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.groupText.IsPasswordChat = '\0';
			this.groupText.IsSystemPasswordChar = false;
			this.groupText.Lines = new string[0];
			this.groupText.Location = new System.Drawing.Point(1, 456);
			this.groupText.Margin = new System.Windows.Forms.Padding(0);
			this.groupText.MaxLength = 32767;
			this.groupText.MinimumSize = new System.Drawing.Size(28, 28);
			this.groupText.MouseBack = null;
			this.groupText.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.groupText.Multiline = true;
			this.groupText.Name = "groupText";
			this.groupText.NormlBack = null;
			this.groupText.Padding = new System.Windows.Forms.Padding(5);
			this.groupText.ReadOnly = false;
			this.groupText.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.groupText.Size = new System.Drawing.Size(476, 123);
			// 
			// 
			// 
			this.groupText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.groupText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.groupText.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.groupText.SkinTxt.Multiline = true;
			this.groupText.SkinTxt.Name = "BaseText";
			this.groupText.SkinTxt.Size = new System.Drawing.Size(466, 113);
			this.groupText.SkinTxt.TabIndex = 0;
			this.groupText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.groupText.SkinTxt.WaterText = "";
			this.groupText.TabIndex = 4;
			this.groupText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.groupText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.groupText.WaterText = "";
			this.groupText.WordWrap = true;
			// 
			// groupSend
			// 
			this.groupSend.BackColor = System.Drawing.Color.Transparent;
			this.groupSend.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.groupSend.DownBack = null;
			this.groupSend.Location = new System.Drawing.Point(283, 587);
			this.groupSend.MouseBack = null;
			this.groupSend.Name = "groupSend";
			this.groupSend.NormlBack = null;
			this.groupSend.Size = new System.Drawing.Size(75, 28);
			this.groupSend.TabIndex = 5;
			this.groupSend.Text = "发送";
			this.groupSend.UseVisualStyleBackColor = false;
			// 
			// groupClose
			// 
			this.groupClose.BackColor = System.Drawing.Color.Transparent;
			this.groupClose.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.groupClose.DownBack = null;
			this.groupClose.Location = new System.Drawing.Point(384, 587);
			this.groupClose.MouseBack = null;
			this.groupClose.Name = "groupClose";
			this.groupClose.NormlBack = null;
			this.groupClose.Size = new System.Drawing.Size(75, 28);
			this.groupClose.TabIndex = 6;
			this.groupClose.Text = "取消";
			this.groupClose.UseVisualStyleBackColor = false;
			// 
			// groupNumber
			// 
			this.groupNumber.AutoSize = true;
			this.groupNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupNumber.Location = new System.Drawing.Point(538, 221);
			this.groupNumber.Name = "groupNumber";
			this.groupNumber.Size = new System.Drawing.Size(51, 21);
			this.groupNumber.TabIndex = 7;
			this.groupNumber.Text = "（1）";
			// 
			// GroupName
			// 
			this.GroupName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.GroupName.Location = new System.Drawing.Point(-1, 9);
			this.GroupName.Name = "GroupName";
			this.GroupName.Size = new System.Drawing.Size(478, 40);
			this.GroupName.TabIndex = 8;
			this.GroupName.Text = "群的名字";
			// 
			// groupSetting
			// 
			this.groupSetting.Location = new System.Drawing.Point(483, 12);
			this.groupSetting.Name = "groupSetting";
			this.groupSetting.Size = new System.Drawing.Size(75, 37);
			this.groupSetting.TabIndex = 9;
			this.groupSetting.Text = "群设置";
			this.groupSetting.UseVisualStyleBackColor = true;
			// 
			// groupMessage
			// 
			this.groupMessage.Location = new System.Drawing.Point(602, 12);
			this.groupMessage.Name = "groupMessage";
			this.groupMessage.Size = new System.Drawing.Size(75, 37);
			this.groupMessage.TabIndex = 10;
			this.groupMessage.Text = "群信息";
			this.groupMessage.UseVisualStyleBackColor = true;
			// 
			// Group
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 622);
			this.Controls.Add(this.groupMessage);
			this.Controls.Add(this.groupSetting);
			this.Controls.Add(this.GroupName);
			this.Controls.Add(this.groupNumber);
			this.Controls.Add(this.groupClose);
			this.Controls.Add(this.groupSend);
			this.Controls.Add(this.groupText);
			this.Controls.Add(this.groupNotice);
			this.Controls.Add(this.groupChatList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupMemberList);
			this.Name = "Group";
			this.Text = "Group";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox groupMemberList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox groupChatList;
		private System.Windows.Forms.Label groupNotice;
		private CCWin.SkinControl.SkinTextBox groupText;
		private CCWin.SkinControl.SkinButton groupSend;
		private CCWin.SkinControl.SkinButton groupClose;
		private System.Windows.Forms.Label groupNumber;
		private System.Windows.Forms.Label GroupName;
		private System.Windows.Forms.Button groupSetting;
		private System.Windows.Forms.Button groupMessage;
	}
}
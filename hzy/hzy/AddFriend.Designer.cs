namespace hzy
{
	partial class AddFriend
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
			this.searchText = new System.Windows.Forms.TextBox();
			this.search = new CCWin.SkinControl.SkinButton();
			this.add = new CCWin.SkinControl.SkinButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.friendSign = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.friendID = new System.Windows.Forms.Label();
			this.friendName = new System.Windows.Forms.Label();
			this.friendPhoto = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// searchText
			// 
			this.searchText.Location = new System.Drawing.Point(29, 18);
			this.searchText.Name = "searchText";
			this.searchText.Size = new System.Drawing.Size(242, 21);
			this.searchText.TabIndex = 0;
			this.searchText.Text = "请输入用户ID";
			// 
			// search
			// 
			this.search.BackColor = System.Drawing.Color.Transparent;
			this.search.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.search.DownBack = null;
			this.search.Location = new System.Drawing.Point(40, 65);
			this.search.MouseBack = null;
			this.search.Name = "search";
			this.search.NormlBack = null;
			this.search.Size = new System.Drawing.Size(75, 28);
			this.search.TabIndex = 1;
			this.search.Text = "搜索";
			this.search.UseVisualStyleBackColor = false;
			this.search.Click += new System.EventHandler(this.Search);
			// 
			// add
			// 
			this.add.BackColor = System.Drawing.Color.Transparent;
			this.add.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.add.DownBack = null;
			this.add.Location = new System.Drawing.Point(177, 65);
			this.add.MouseBack = null;
			this.add.Name = "add";
			this.add.NormlBack = null;
			this.add.Size = new System.Drawing.Size(75, 28);
			this.add.TabIndex = 2;
			this.add.Text = "添加";
			this.add.UseVisualStyleBackColor = false;
			this.add.Click += new System.EventHandler(this.AddFriendApply);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.friendSign);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.friendPhoto);
			this.panel1.Controls.Add(this.friendID);
			this.panel1.Controls.Add(this.friendName);
			this.panel1.Location = new System.Drawing.Point(12, 146);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(285, 122);
			this.panel1.TabIndex = 3;
			// 
			// friendSign
			// 
			this.friendSign.AutoSize = true;
			this.friendSign.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.friendSign.Location = new System.Drawing.Point(20, 92);
			this.friendSign.Name = "friendSign";
			this.friendSign.Size = new System.Drawing.Size(137, 12);
			this.friendSign.TabIndex = 4;
			this.friendSign.Text = "这个人很懒，什么都没写";
			this.friendSign.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(14, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 16);
			this.label3.TabIndex = 3;
			// 
			// friendID
			// 
			this.friendID.AutoSize = true;
			this.friendID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.friendID.Location = new System.Drawing.Point(142, 27);
			this.friendID.Name = "friendID";
			this.friendID.Size = new System.Drawing.Size(56, 16);
			this.friendID.TabIndex = 1;
			this.friendID.Text = "用户ID";
			this.friendID.Visible = false;
			// 
			// friendName
			// 
			this.friendName.AutoSize = true;
			this.friendName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.friendName.Location = new System.Drawing.Point(142, 59);
			this.friendName.Name = "friendName";
			this.friendName.Size = new System.Drawing.Size(56, 16);
			this.friendName.TabIndex = 0;
			this.friendName.Text = "用户名";
			this.friendName.Visible = false;
			// 
			// friendPhoto
			// 
			this.friendPhoto.Location = new System.Drawing.Point(17, 21);
			this.friendPhoto.Name = "friendPhoto";
			this.friendPhoto.Size = new System.Drawing.Size(60, 60);
			this.friendPhoto.TabIndex = 2;
			this.friendPhoto.TabStop = false;
			this.friendPhoto.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(94, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 14);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "昵称：";
			// 
			// AddFriend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 303);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.add);
			this.Controls.Add(this.search);
			this.Controls.Add(this.searchText);
			this.Name = "AddFriend";
			this.Text = "添加好友";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchText;
		private CCWin.SkinControl.SkinButton search;
		private CCWin.SkinControl.SkinButton add;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label friendID;
		private System.Windows.Forms.Label friendName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox friendPhoto;
		private System.Windows.Forms.Label friendSign;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
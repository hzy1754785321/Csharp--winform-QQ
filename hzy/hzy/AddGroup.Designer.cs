namespace hzy
{
	partial class AddGroup
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
            this.searchText = new CCWin.SkinControl.SkinTextBox();
            this.searchButton = new CCWin.SkinControl.SkinButton();
            this.applyButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.searchInfo = new CCWin.SkinControl.SkinPanel();
            this.groupSynopsis = new CCWin.SkinControl.SkinLabel();
            this.groupAdmin = new CCWin.SkinControl.SkinLabel();
            this.groupMember = new CCWin.SkinControl.SkinLabel();
            this.groupName = new CCWin.SkinControl.SkinLabel();
            this.groupNumber = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.searchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Transparent;
            this.searchText.DownBack = null;
            this.searchText.Icon = null;
            this.searchText.IconIsButton = false;
            this.searchText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.searchText.IsPasswordChat = '\0';
            this.searchText.IsSystemPasswordChar = false;
            this.searchText.Lines = new string[] {
        "请输入群号"};
            this.searchText.Location = new System.Drawing.Point(9, 16);
            this.searchText.Margin = new System.Windows.Forms.Padding(0);
            this.searchText.MaxLength = 32767;
            this.searchText.MinimumSize = new System.Drawing.Size(28, 28);
            this.searchText.MouseBack = null;
            this.searchText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.NormlBack = null;
            this.searchText.Padding = new System.Windows.Forms.Padding(5);
            this.searchText.ReadOnly = false;
            this.searchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText.Size = new System.Drawing.Size(324, 33);
            // 
            // 
            // 
            this.searchText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.searchText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.searchText.SkinTxt.Multiline = true;
            this.searchText.SkinTxt.Name = "BaseText";
            this.searchText.SkinTxt.Size = new System.Drawing.Size(314, 23);
            this.searchText.SkinTxt.TabIndex = 0;
            this.searchText.SkinTxt.Text = "请输入群号";
            this.searchText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.searchText.SkinTxt.WaterText = "";
            this.searchText.TabIndex = 0;
            this.searchText.Text = "请输入群号";
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.searchText.WaterText = "";
            this.searchText.WordWrap = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searchButton.DownBack = null;
            this.searchButton.Location = new System.Drawing.Point(12, 83);
            this.searchButton.MouseBack = null;
            this.searchButton.Name = "searchButton";
            this.searchButton.NormlBack = null;
            this.searchButton.Size = new System.Drawing.Size(89, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "搜索";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.Search);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.applyButton.DownBack = null;
            this.applyButton.Location = new System.Drawing.Point(215, 83);
            this.applyButton.MouseBack = null;
            this.applyButton.Name = "applyButton";
            this.applyButton.NormlBack = null;
            this.applyButton.Size = new System.Drawing.Size(89, 33);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "申请";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.AddGroupApply);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(20, 18);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(58, 21);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "群号：";
            // 
            // searchInfo
            // 
            this.searchInfo.BackColor = System.Drawing.Color.Transparent;
            this.searchInfo.Controls.Add(this.groupSynopsis);
            this.searchInfo.Controls.Add(this.groupAdmin);
            this.searchInfo.Controls.Add(this.groupMember);
            this.searchInfo.Controls.Add(this.groupName);
            this.searchInfo.Controls.Add(this.groupNumber);
            this.searchInfo.Controls.Add(this.skinLabel5);
            this.searchInfo.Controls.Add(this.skinLabel4);
            this.searchInfo.Controls.Add(this.skinLabel3);
            this.searchInfo.Controls.Add(this.skinLabel2);
            this.searchInfo.Controls.Add(this.skinLabel1);
            this.searchInfo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searchInfo.DownBack = null;
            this.searchInfo.Location = new System.Drawing.Point(9, 176);
            this.searchInfo.MouseBack = null;
            this.searchInfo.Name = "searchInfo";
            this.searchInfo.NormlBack = null;
            this.searchInfo.Size = new System.Drawing.Size(324, 288);
            this.searchInfo.TabIndex = 4;
            // 
            // groupSynopsis
            // 
            this.groupSynopsis.BackColor = System.Drawing.Color.Transparent;
            this.groupSynopsis.BorderColor = System.Drawing.Color.White;
            this.groupSynopsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupSynopsis.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupSynopsis.Location = new System.Drawing.Point(89, 150);
            this.groupSynopsis.Name = "groupSynopsis";
            this.groupSynopsis.Size = new System.Drawing.Size(226, 127);
            this.groupSynopsis.TabIndex = 12;
            this.groupSynopsis.Text = "12345";
            this.groupSynopsis.Visible = false;
            // 
            // groupAdmin
            // 
            this.groupAdmin.AutoSize = true;
            this.groupAdmin.BackColor = System.Drawing.Color.Transparent;
            this.groupAdmin.BorderColor = System.Drawing.Color.White;
            this.groupAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupAdmin.Location = new System.Drawing.Point(84, 113);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Size = new System.Drawing.Size(67, 25);
            this.groupAdmin.TabIndex = 11;
            this.groupAdmin.Text = "12345";
            this.groupAdmin.Visible = false;
            // 
            // groupMember
            // 
            this.groupMember.AutoSize = true;
            this.groupMember.BackColor = System.Drawing.Color.Transparent;
            this.groupMember.BorderColor = System.Drawing.Color.White;
            this.groupMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupMember.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupMember.Location = new System.Drawing.Point(100, 82);
            this.groupMember.Name = "groupMember";
            this.groupMember.Size = new System.Drawing.Size(67, 25);
            this.groupMember.TabIndex = 10;
            this.groupMember.Text = "12345";
            this.groupMember.Visible = false;
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.BackColor = System.Drawing.Color.Transparent;
            this.groupName.BorderColor = System.Drawing.Color.White;
            this.groupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupName.Location = new System.Drawing.Point(84, 50);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(67, 25);
            this.groupName.TabIndex = 9;
            this.groupName.Text = "12345";
            this.groupName.Visible = false;
            // 
            // groupNumber
            // 
            this.groupNumber.AutoSize = true;
            this.groupNumber.BackColor = System.Drawing.Color.Transparent;
            this.groupNumber.BorderColor = System.Drawing.Color.White;
            this.groupNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupNumber.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupNumber.Location = new System.Drawing.Point(84, 18);
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Size = new System.Drawing.Size(67, 25);
            this.groupNumber.TabIndex = 8;
            this.groupNumber.Text = "12345";
            this.groupNumber.Visible = false;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(20, 113);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(58, 21);
            this.skinLabel5.TabIndex = 7;
            this.skinLabel5.Text = "群主：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(18, 150);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(74, 21);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "群简介：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(20, 82);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(74, 21);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "群人数：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(20, 50);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(58, 21);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "群名：";
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 502);
            this.Controls.Add(this.searchInfo);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.searchInfo.ResumeLayout(false);
            this.searchInfo.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private CCWin.SkinControl.SkinTextBox searchText;
		private CCWin.SkinControl.SkinButton searchButton;
		private CCWin.SkinControl.SkinButton applyButton;
		private CCWin.SkinControl.SkinLabel skinLabel1;
		private CCWin.SkinControl.SkinPanel searchInfo;
		private CCWin.SkinControl.SkinLabel groupAdmin;
		private CCWin.SkinControl.SkinLabel groupMember;
		private CCWin.SkinControl.SkinLabel groupName;
		private CCWin.SkinControl.SkinLabel groupNumber;
		private CCWin.SkinControl.SkinLabel skinLabel5;
		private CCWin.SkinControl.SkinLabel skinLabel4;
		private CCWin.SkinControl.SkinLabel skinLabel3;
		private CCWin.SkinControl.SkinLabel skinLabel2;
		private CCWin.SkinControl.SkinLabel groupSynopsis;
	}
}
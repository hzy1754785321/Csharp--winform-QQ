namespace hzy
{
	partial class Chat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
			this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
			chatListBox = new System.Windows.Forms.ListBox();
			this.chatBox = new CCWin.SkinControl.RtfRichTextBox();
			this.skinButton1 = new CCWin.SkinControl.SkinButton();
			this.skinButton2 = new CCWin.SkinControl.SkinButton();
			this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
			this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
			this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
			this.skinButton3 = new CCWin.SkinControl.SkinButton();
			this.skinPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// skinPanel1
			// 
			this.skinPanel1.BackColor = System.Drawing.Color.Snow;
			this.skinPanel1.Controls.Add(chatListBox);
			this.skinPanel1.Controls.Add(this.chatBox);
			this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinPanel1.DownBack = null;
			this.skinPanel1.Location = new System.Drawing.Point(3, 97);
			this.skinPanel1.MouseBack = null;
			this.skinPanel1.Name = "skinPanel1";
			this.skinPanel1.NormlBack = null;
			this.skinPanel1.Size = new System.Drawing.Size(472, 558);
			this.skinPanel1.TabIndex = 0;
			// 
			// chatListBox
			// 
			chatListBox.FormattingEnabled = true;
			chatListBox.ItemHeight = 12;
			chatListBox.Location = new System.Drawing.Point(0, 3);
			chatListBox.Name = "chatListBox";
			chatListBox.Size = new System.Drawing.Size(469, 376);
			chatListBox.TabIndex = 2;
			// 
			// chatBox
			// 
			this.chatBox.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
			this.chatBox.Location = new System.Drawing.Point(0, 408);
			this.chatBox.Name = "chatBox";
			this.chatBox.Size = new System.Drawing.Size(469, 151);
			this.chatBox.TabIndex = 1;
			this.chatBox.Text = "";
			this.chatBox.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
			this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendChatMessage);
			// 
			// skinButton1
			// 
			this.skinButton1.BackColor = System.Drawing.Color.Transparent;
			this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton1.DownBack = null;
			this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinButton1.Location = new System.Drawing.Point(293, 661);
			this.skinButton1.MouseBack = null;
			this.skinButton1.Name = "skinButton1";
			this.skinButton1.NormlBack = null;
			this.skinButton1.Size = new System.Drawing.Size(88, 32);
			this.skinButton1.TabIndex = 1;
			this.skinButton1.Text = "关闭";
			this.skinButton1.UseVisualStyleBackColor = false;
			this.skinButton1.Click += new System.EventHandler(this.CloseChat);
			// 
			// skinButton2
			// 
			this.skinButton2.BackColor = System.Drawing.Color.Transparent;
			this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton2.DownBack = null;
			this.skinButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinButton2.Location = new System.Drawing.Point(387, 661);
			this.skinButton2.MouseBack = null;
			this.skinButton2.Name = "skinButton2";
			this.skinButton2.NormlBack = null;
			this.skinButton2.Size = new System.Drawing.Size(88, 32);
			this.skinButton2.TabIndex = 2;
			this.skinButton2.Text = "发送";
			this.skinButton2.UseVisualStyleBackColor = false;
			this.skinButton2.Click += new System.EventHandler(this.SendChatMessage);
			// 
			// skinPictureBox1
			// 
			this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
			this.skinPictureBox1.Location = new System.Drawing.Point(3, 3);
			this.skinPictureBox1.Name = "skinPictureBox1";
			this.skinPictureBox1.Size = new System.Drawing.Size(60, 60);
			this.skinPictureBox1.TabIndex = 3;
			this.skinPictureBox1.TabStop = false;
			// 
			// skinLabel1
			// 
			this.skinLabel1.AutoSize = true;
			this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel1.BorderColor = System.Drawing.Color.White;
			this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinLabel1.Location = new System.Drawing.Point(69, 9);
			this.skinLabel1.Name = "skinLabel1";
			this.skinLabel1.Size = new System.Drawing.Size(88, 25);
			this.skinLabel1.TabIndex = 4;
			this.skinLabel1.Text = "嗨哟阳光";
			// 
			// skinLabel2
			// 
			this.skinLabel2.AutoSize = true;
			this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel2.BorderColor = System.Drawing.Color.White;
			this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.skinLabel2.Location = new System.Drawing.Point(98, 41);
			this.skinLabel2.Name = "skinLabel2";
			this.skinLabel2.Size = new System.Drawing.Size(93, 20);
			this.skinLabel2.TabIndex = 5;
			this.skinLabel2.Text = "我的个性签名";
			// 
			// skinButton3
			// 
			this.skinButton3.BackColor = System.Drawing.Color.Transparent;
			this.skinButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton3.BackgroundImage")));
			this.skinButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.skinButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton3.DownBack = null;
			this.skinButton3.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.skinButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.skinButton3.Location = new System.Drawing.Point(74, 40);
			this.skinButton3.MouseBack = null;
			this.skinButton3.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.skinButton3.Name = "skinButton3";
			this.skinButton3.NormlBack = null;
			this.skinButton3.Size = new System.Drawing.Size(20, 20);
			this.skinButton3.TabIndex = 6;
			this.skinButton3.UseVisualStyleBackColor = false;
			// 
			// Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(676, 699);
			this.Controls.Add(this.skinButton3);
			this.Controls.Add(this.skinLabel2);
			this.Controls.Add(this.skinLabel1);
			this.Controls.Add(this.skinPictureBox1);
			this.Controls.Add(this.skinButton2);
			this.Controls.Add(this.skinButton1);
			this.Controls.Add(this.skinPanel1);
			this.Name = "Chat";
			this.Text = "Chat";
			this.Load += new System.EventHandler(this.Chat_Load);
			this.skinPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinPanel skinPanel1;
		private CCWin.SkinControl.RtfRichTextBox chatBox;
		private CCWin.SkinControl.SkinButton skinButton1;
		private CCWin.SkinControl.SkinButton skinButton2;
		private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
		private CCWin.SkinControl.SkinLabel skinLabel1;
		private CCWin.SkinControl.SkinLabel skinLabel2;
		private CCWin.SkinControl.SkinButton skinButton3;
		public static System.Windows.Forms.ListBox chatListBox;
	}
}
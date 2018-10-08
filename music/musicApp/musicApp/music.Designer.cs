namespace musicApp
{
	partial class music
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.open = new System.Windows.Forms.Button();
            this.musicList = new System.Windows.Forms.ListBox();
            this.Start = new CCWin.SkinControl.SkinButton();
            this.last = new CCWin.SkinControl.SkinButton();
            this.next = new CCWin.SkinControl.SkinButton();
            this.media = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(31, 25);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(70, 23);
            this.open.TabIndex = 3;
            this.open.Text = "打开";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.OpenClick);
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.ItemHeight = 12;
            this.musicList.Location = new System.Drawing.Point(49, 56);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(239, 244);
            this.musicList.TabIndex = 4;
            this.musicList.DoubleClick += new System.EventHandler(this.PlayMusic_Double_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Start.DownBack = null;
            this.Start.Location = new System.Drawing.Point(49, 341);
            this.Start.MouseBack = null;
            this.Start.Name = "Start";
            this.Start.NormlBack = null;
            this.Start.Size = new System.Drawing.Size(54, 54);
            this.Start.TabIndex = 5;
            this.Start.Text = "播放";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.PlayerMusic);
            this.Start.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.Transparent;
            this.last.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.last.DownBack = null;
            this.last.Location = new System.Drawing.Point(236, 341);
            this.last.MouseBack = null;
            this.last.Name = "last";
            this.last.NormlBack = null;
            this.last.Size = new System.Drawing.Size(52, 54);
            this.last.TabIndex = 6;
            this.last.Text = "上一首";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.LastMusic);
            this.last.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.next.DownBack = null;
            this.next.Location = new System.Drawing.Point(146, 341);
            this.next.MouseBack = null;
            this.next.Name = "next";
            this.next.NormlBack = null;
            this.next.Size = new System.Drawing.Size(52, 54);
            this.next.TabIndex = 7;
            this.next.Text = "下一首";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.NextMusic);
            this.next.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(236, 13);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(82, 20);
            this.media.TabIndex = 8;
            this.media.Text = "去看视频";
            this.media.UseVisualStyleBackColor = true;
            this.media.Click += new System.EventHandler(this.GotoMedia);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "分享给好友";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.media);
            this.Controls.Add(this.next);
            this.Controls.Add(this.last);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.open);
            this.Name = "music";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button open;
		private System.Windows.Forms.ListBox musicList;
		private CCWin.SkinControl.SkinButton Start;
		private CCWin.SkinControl.SkinButton last;
		private CCWin.SkinControl.SkinButton next;
		private System.Windows.Forms.Button media;
        private System.Windows.Forms.Button button1;
    }
}


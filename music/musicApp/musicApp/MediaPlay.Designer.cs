namespace musicApp
{
	partial class MediaPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlay));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaList = new System.Windows.Forms.ListBox();
            this.open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(188, 41);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(610, 385);
            this.MediaPlayer.TabIndex = 0;
            // 
            // MediaList
            // 
            this.MediaList.FormattingEnabled = true;
            this.MediaList.ItemHeight = 12;
            this.MediaList.Location = new System.Drawing.Point(12, 12);
            this.MediaList.Name = "MediaList";
            this.MediaList.Size = new System.Drawing.Size(170, 364);
            this.MediaList.TabIndex = 1;
            this.MediaList.DoubleClick += new System.EventHandler(this.StartMedia);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(188, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 2;
            this.open.Text = "打开";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.OpenMedia);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "分享给好友";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MediaPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.MediaList);
            this.Controls.Add(this.MediaPlayer);
            this.Name = "MediaPlay";
            this.Text = "MediaPlay";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
		private System.Windows.Forms.ListBox MediaList;
		private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button button1;
    }
}
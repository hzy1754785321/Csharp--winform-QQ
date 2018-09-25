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
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// MediaPlayer
			// 
			this.MediaPlayer.Enabled = true;
			this.MediaPlayer.Location = new System.Drawing.Point(133, 382);
			this.MediaPlayer.Name = "MediaPlayer";
			this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
			this.MediaPlayer.Size = new System.Drawing.Size(549, 45);
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
			// 
			// MediaPlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}
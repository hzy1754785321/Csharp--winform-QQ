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
			this.Start = new System.Windows.Forms.Button();
			this.next = new System.Windows.Forms.Button();
			this.last = new System.Windows.Forms.Button();
			this.open = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(49, 310);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(52, 54);
			this.Start.TabIndex = 0;
			this.Start.Text = "播放";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
			// 
			// next
			// 
			this.next.Location = new System.Drawing.Point(145, 310);
			this.next.Name = "next";
			this.next.Size = new System.Drawing.Size(52, 54);
			this.next.TabIndex = 1;
			this.next.Text = "下一首";
			this.next.UseVisualStyleBackColor = true;
			this.next.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
			// 
			// last
			// 
			this.last.Location = new System.Drawing.Point(236, 310);
			this.last.Name = "last";
			this.last.Size = new System.Drawing.Size(52, 54);
			this.last.TabIndex = 2;
			this.last.Text = "上一首";
			this.last.UseVisualStyleBackColor = true;
			this.last.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(31, 25);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(70, 23);
			this.open.TabIndex = 3;
			this.open.Text = "打开";
			this.open.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(49, 56);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(239, 244);
			this.listBox1.TabIndex = 4;
			// 
			// music
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 458);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.open);
			this.Controls.Add(this.last);
			this.Controls.Add(this.next);
			this.Controls.Add(this.Start);
			this.Name = "music";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.music_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button next;
		private System.Windows.Forms.Button last;
		private System.Windows.Forms.Button open;
		private System.Windows.Forms.ListBox listBox1;
	}
}


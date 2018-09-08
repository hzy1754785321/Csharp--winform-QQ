namespace test
{
	partial class Form1
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
			this.source = new CCWin.SkinControl.SkinPictureBox();
			this.target = new CCWin.SkinControl.SkinPictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
			this.SuspendLayout();
			// 
			// source
			// 
			this.source.BackColor = System.Drawing.Color.Transparent;
			this.source.ContextMenuStrip = this.skinContextMenuStrip1;
			this.source.Location = new System.Drawing.Point(67, 98);
			this.source.Name = "source";
			this.source.Size = new System.Drawing.Size(265, 317);
			this.source.TabIndex = 0;
			this.source.TabStop = false;
			this.source.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewPhoto);
			// 
			// target
			// 
			this.target.BackColor = System.Drawing.Color.Transparent;
			this.target.Location = new System.Drawing.Point(463, 98);
			this.target.Name = "target";
			this.target.Size = new System.Drawing.Size(265, 317);
			this.target.TabIndex = 1;
			this.target.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(129, 444);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(547, 444);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 47);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Path";
			// 
			// skinContextMenuStrip1
			// 
			this.skinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
			this.skinContextMenuStrip1.Back = System.Drawing.Color.White;
			this.skinContextMenuStrip1.BackRadius = 4;
			this.skinContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
			this.skinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.skinContextMenuStrip1.Fore = System.Drawing.Color.Black;
			this.skinContextMenuStrip1.HoverFore = System.Drawing.Color.White;
			this.skinContextMenuStrip1.ItemAnamorphosis = true;
			this.skinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinContextMenuStrip1.ItemBorderShow = true;
			this.skinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinContextMenuStrip1.ItemRadius = 4;
			this.skinContextMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
			this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.skinContextMenuStrip1.SkinAllColor = true;
			this.skinContextMenuStrip1.TitleAnamorphosis = true;
			this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
			this.skinContextMenuStrip1.TitleRadius = 4;
			this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(257, 421);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(284, 304);
			this.listBox1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 744);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.target);
			this.Controls.Add(this.source);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CCWin.SkinControl.SkinPictureBox source;
		private CCWin.SkinControl.SkinPictureBox target;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
		private System.Windows.Forms.ListBox listBox1;
	}
}


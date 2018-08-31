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
			this.components = new System.ComponentModel.Container();
			this.source = new CCWin.SkinControl.SkinPictureBox();
			this.target = new CCWin.SkinControl.SkinPictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
			this.SuspendLayout();
			// 
			// source
			// 
			this.source.BackColor = System.Drawing.Color.Transparent;
			this.source.ContextMenuStrip = this.contextMenuStrip1;
			this.source.Location = new System.Drawing.Point(67, 98);
			this.source.Name = "source";
			this.source.Size = new System.Drawing.Size(265, 317);
			this.source.TabIndex = 0;
			this.source.TabStop = false;
			this.source.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Right);
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
			this.button1.Location = new System.Drawing.Point(129, 475);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(548, 475);
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
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 670);
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
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}


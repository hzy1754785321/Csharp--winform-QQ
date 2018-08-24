namespace Server
{
	partial class server
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
			this.StartServer = new System.Windows.Forms.Button();
			this.ip = new System.Windows.Forms.Label();
			this.ip_text = new System.Windows.Forms.TextBox();
			this.port = new System.Windows.Forms.Label();
			this.port_text = new System.Windows.Forms.TextBox();
			server.showWindow = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// StartServer
			// 
			this.StartServer.Location = new System.Drawing.Point(289, 139);
			this.StartServer.Name = "StartServer";
			this.StartServer.Size = new System.Drawing.Size(189, 37);
			this.StartServer.TabIndex = 0;
			this.StartServer.Text = "开启服务器";
			this.StartServer.UseVisualStyleBackColor = true;
			this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
			// 
			// ip
			// 
			this.ip.AutoSize = true;
			this.ip.Location = new System.Drawing.Point(136, 59);
			this.ip.Name = "ip";
			this.ip.Size = new System.Drawing.Size(17, 12);
			this.ip.TabIndex = 1;
			this.ip.Text = "ip";
			// 
			// ip_text
			// 
			this.ip_text.Location = new System.Drawing.Point(193, 56);
			this.ip_text.Name = "ip_text";
			this.ip_text.Size = new System.Drawing.Size(100, 21);
			this.ip_text.TabIndex = 2;
			// 
			// port
			// 
			this.port.AutoSize = true;
			this.port.Location = new System.Drawing.Point(474, 62);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(29, 12);
			this.port.TabIndex = 3;
			this.port.Text = "port";
			// 
			// port_text
			// 
			this.port_text.Location = new System.Drawing.Point(562, 59);
			this.port_text.Name = "port_text";
			this.port_text.Size = new System.Drawing.Size(100, 21);
			this.port_text.TabIndex = 4;
			// 
			// showWindow
			// 
			server.showWindow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			server.showWindow.FormattingEnabled = true;
			server.showWindow.ItemHeight = 12;
			server.showWindow.Location = new System.Drawing.Point(138, 211);
			server.showWindow.Name = "showWindow";
			server.showWindow.Size = new System.Drawing.Size(524, 172);
			server.showWindow.TabIndex = 5;
			server.showWindow.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.showWindow_DrawItem);
			// 
			// server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(server.showWindow);
			this.Controls.Add(this.port_text);
			this.Controls.Add(this.port);
			this.Controls.Add(this.ip_text);
			this.Controls.Add(this.ip);
			this.Controls.Add(this.StartServer);
			this.Name = "server";
			this.Text = "server";
			this.Load += new System.EventHandler(this.ServerForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button StartServer;
		private System.Windows.Forms.Label ip;
		private System.Windows.Forms.TextBox ip_text;
		private System.Windows.Forms.Label port;
		private System.Windows.Forms.TextBox port_text;
		public static System.Windows.Forms.ListBox showWindow;
	}
}


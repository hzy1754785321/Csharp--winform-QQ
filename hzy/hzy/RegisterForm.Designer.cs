namespace hzy
{
	partial class RegisterForm
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
			this.registe = new System.Windows.Forms.Button();
			this.name = new System.Windows.Forms.TextBox();
			this.passwd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// registe
			// 
			this.registe.Location = new System.Drawing.Point(342, 310);
			this.registe.Name = "registe";
			this.registe.Size = new System.Drawing.Size(75, 23);
			this.registe.TabIndex = 0;
			this.registe.Text = "注册";
			this.registe.UseVisualStyleBackColor = true;
			this.registe.Click += new System.EventHandler(this.register);
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(333, 113);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(100, 21);
			this.name.TabIndex = 1;
	//		this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// passwd
			// 
			this.passwd.Location = new System.Drawing.Point(333, 172);
			this.passwd.Name = "passwd";
			this.passwd.Size = new System.Drawing.Size(100, 21);
			this.passwd.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(225, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "密码";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "账号";
			// 
			// back
			// 
			this.back.Location = new System.Drawing.Point(517, 310);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(75, 23);
			this.back.TabIndex = 5;
			this.back.Text = "返回登陆";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.backLogin);
			// 
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwd);
			this.Controls.Add(this.name);
			this.Controls.Add(this.registe);
			this.Name = "RegisterForm";
			this.Text = "注册";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button registe;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox passwd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button back;
	}
}
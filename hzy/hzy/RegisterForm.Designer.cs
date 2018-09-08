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
			this.userId = new System.Windows.Forms.TextBox();
			this.passwd = new System.Windows.Forms.TextBox();
			this.laber3 = new System.Windows.Forms.Label();
			this.laber1 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.laber2 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
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
			// userId
			// 
			this.userId.Location = new System.Drawing.Point(333, 113);
			this.userId.Name = "userId";
			this.userId.Size = new System.Drawing.Size(100, 21);
			this.userId.TabIndex = 1;
			// 
			// passwd
			// 
			this.passwd.Location = new System.Drawing.Point(333, 204);
			this.passwd.Name = "passwd";
			this.passwd.Size = new System.Drawing.Size(100, 21);
			this.passwd.TabIndex = 2;
			// 
			// laber3
			// 
			this.laber3.AutoSize = true;
			this.laber3.Location = new System.Drawing.Point(225, 212);
			this.laber3.Name = "laber3";
			this.laber3.Size = new System.Drawing.Size(29, 12);
			this.laber3.TabIndex = 3;
			this.laber3.Text = "密码";
			// 
			// laber1
			// 
			this.laber1.AutoSize = true;
			this.laber1.Location = new System.Drawing.Point(225, 116);
			this.laber1.Name = "laber1";
			this.laber1.Size = new System.Drawing.Size(29, 12);
			this.laber1.TabIndex = 4;
			this.laber1.Text = "账号";
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
			// laber2
			// 
			this.laber2.AutoSize = true;
			this.laber2.Location = new System.Drawing.Point(225, 164);
			this.laber2.Name = "laber2";
			this.laber2.Size = new System.Drawing.Size(29, 12);
			this.laber2.TabIndex = 6;
			this.laber2.Text = "昵称";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(333, 161);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(100, 21);
			this.name.TabIndex = 7;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.name);
			this.Controls.Add(this.laber2);
			this.Controls.Add(this.back);
			this.Controls.Add(this.laber1);
			this.Controls.Add(this.laber3);
			this.Controls.Add(this.passwd);
			this.Controls.Add(this.userId);
			this.Controls.Add(this.registe);
			this.Name = "RegisterForm";
			this.Text = "注册";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button registe;
		private System.Windows.Forms.TextBox userId;
		private System.Windows.Forms.TextBox passwd;
		private System.Windows.Forms.Label laber3;
		private System.Windows.Forms.Label laber1;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label laber2;
		private System.Windows.Forms.TextBox name;
	}
}
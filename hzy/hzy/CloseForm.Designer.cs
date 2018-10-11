namespace hzy
{
    partial class CloseForm
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
            this.noClose = new CCWin.SkinControl.SkinRadioButton();
            this.close = new CCWin.SkinControl.SkinRadioButton();
            this.SuspendLayout();
            // 
            // noClose
            // 
            this.noClose.AutoSize = true;
            this.noClose.BackColor = System.Drawing.Color.Transparent;
            this.noClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.noClose.DownBack = null;
            this.noClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noClose.LightEffect = false;
            this.noClose.Location = new System.Drawing.Point(70, 39);
            this.noClose.MouseBack = null;
            this.noClose.Name = "noClose";
            this.noClose.NormlBack = null;
            this.noClose.SelectedDownBack = null;
            this.noClose.SelectedMouseBack = null;
            this.noClose.SelectedNormlBack = null;
            this.noClose.Size = new System.Drawing.Size(170, 21);
            this.noClose.TabIndex = 0;
            this.noClose.TabStop = true;
            this.noClose.Text = "最小化到托盘，不退出程序";
            this.noClose.UseVisualStyleBackColor = false;
            this.noClose.CheckedChanged += new System.EventHandler(this.NoCloseCheck);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.close.DownBack = null;
            this.close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Location = new System.Drawing.Point(70, 79);
            this.close.MouseBack = null;
            this.close.Name = "close";
            this.close.NormlBack = null;
            this.close.SelectedDownBack = null;
            this.close.SelectedMouseBack = null;
            this.close.SelectedNormlBack = null;
            this.close.Size = new System.Drawing.Size(74, 21);
            this.close.TabIndex = 0;
            this.close.TabStop = true;
            this.close.Text = "退出程序";
            this.close.UseVisualStyleBackColor = false;
            this.close.CheckedChanged += new System.EventHandler(this.WantClose);
            // 
            // CloseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 150);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.noClose);
            this.Name = "CloseForm";
            this.Text = "关闭程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinRadioButton noClose;
        private CCWin.SkinControl.SkinRadioButton close;
    }
}
namespace hzy
{
    partial class GroupApply
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
            this.components = new System.ComponentModel.Container();
            this.applyListBox = new System.Windows.Forms.ListBox();
            this.agree = new CCWin.SkinControl.SkinButton();
            this.refuse = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // applyListBox
            // 
            this.applyListBox.FormattingEnabled = true;
            this.applyListBox.ItemHeight = 12;
            this.applyListBox.Location = new System.Drawing.Point(1, 27);
            this.applyListBox.Name = "applyListBox";
            this.applyListBox.Size = new System.Drawing.Size(255, 292);
            this.applyListBox.TabIndex = 0;
            // 
            // agree
            // 
            this.agree.BackColor = System.Drawing.Color.Transparent;
            this.agree.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.agree.DownBack = null;
            this.agree.Location = new System.Drawing.Point(12, 344);
            this.agree.MouseBack = null;
            this.agree.Name = "agree";
            this.agree.NormlBack = null;
            this.agree.Size = new System.Drawing.Size(75, 32);
            this.agree.TabIndex = 1;
            this.agree.Text = "同意";
            this.agree.UseVisualStyleBackColor = false;
            // 
            // refuse
            // 
            this.refuse.BackColor = System.Drawing.Color.Transparent;
            this.refuse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.refuse.DownBack = null;
            this.refuse.Location = new System.Drawing.Point(151, 344);
            this.refuse.MouseBack = null;
            this.refuse.Name = "refuse";
            this.refuse.NormlBack = null;
            this.refuse.Size = new System.Drawing.Size(75, 32);
            this.refuse.TabIndex = 2;
            this.refuse.Text = "拒绝";
            this.refuse.UseVisualStyleBackColor = false;
            // 
            // GroupApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 445);
            this.Controls.Add(this.refuse);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.applyListBox);
            this.Name = "GroupApply";
            this.Text = "GroupApply";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox applyListBox;
        private CCWin.SkinControl.SkinButton agree;
        private CCWin.SkinControl.SkinButton refuse;
    }
}
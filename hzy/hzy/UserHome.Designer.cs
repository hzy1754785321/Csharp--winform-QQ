using System.Windows.Forms;

namespace hzy
{
	partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.groupButton = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.friendTitle = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.userName = new CCWin.SkinControl.SkinLabel();
            this.signature = new CCWin.SkinControl.SkinLabel();
            this.UserPhoto = new CCWin.SkinControl.SkinPictureBox();
            this.choosePhoto = new CCWin.SkinControl.SkinContextMenuStrip();
            this.选择图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyTitle = new CCWin.SkinControl.SkinButton();
            this.workTitle = new CCWin.SkinControl.SkinButton();
            this.skinButton7 = new CCWin.SkinControl.SkinButton();
            this.skinButton8 = new CCWin.SkinControl.SkinButton();
            this.skinButton9 = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mineSign = new System.Windows.Forms.Label();
            this.skinPictureBox5 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPictureBox4 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPictureBox3 = new CCWin.SkinControl.SkinPictureBox();
            this.mineName = new System.Windows.Forms.Label();
            this.skinPictureBox2 = new CCWin.SkinControl.SkinPictureBox();
            this.mineInfo = new CCWin.SkinControl.SkinButton();
            this.Setting = new CCWin.SkinControl.SkinPictureBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.entryMyName = new System.Windows.Forms.TextBox();
            this.signText = new System.Windows.Forms.TextBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupButton1 = new CCWin.SkinControl.SkinButton();
            this.groupName1 = new CCWin.SkinControl.SkinLabel();
            this.groupButton2 = new CCWin.SkinControl.SkinButton();
            this.groupName2 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.choosePhoto.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton1.Location = new System.Drawing.Point(12, 142);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(102, 35);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "好友";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.Color.Transparent;
            this.groupButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.groupButton.DownBack = null;
            this.groupButton.Location = new System.Drawing.Point(120, 142);
            this.groupButton.MouseBack = null;
            this.groupButton.Name = "groupButton";
            this.groupButton.NormlBack = null;
            this.groupButton.Size = new System.Drawing.Size(102, 35);
            this.groupButton.TabIndex = 1;
            this.groupButton.Text = "群组";
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(228, 142);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(102, 35);
            this.skinButton3.TabIndex = 2;
            this.skinButton3.Text = "历史会话";
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // friendTitle
            // 
            this.friendTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.friendTitle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.friendTitle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.friendTitle.DownBack = null;
            this.friendTitle.Image = ((System.Drawing.Image)(resources.GetObject("friendTitle.Image")));
            this.friendTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.friendTitle.Location = new System.Drawing.Point(12, 183);
            this.friendTitle.MouseBack = null;
            this.friendTitle.Name = "friendTitle";
            this.friendTitle.NormlBack = null;
            this.friendTitle.Size = new System.Drawing.Size(316, 29);
            this.friendTitle.TabIndex = 3;
            this.friendTitle.Text = "我的好友(1/4)";
            this.friendTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.friendTitle.UseVisualStyleBackColor = false;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "搜索：联系人、讨论组、群"};
            this.skinTextBox1.Location = new System.Drawing.Point(12, 106);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(316, 33);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BackColor = System.Drawing.SystemColors.Window;
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(306, 23);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "搜索：联系人、讨论组、群";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.White;
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 4;
            this.skinTextBox1.Text = "搜索：联系人、讨论组、群";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.White;
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.BorderColor = System.Drawing.Color.White;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(79, 46);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(92, 27);
            this.userName.TabIndex = 6;
            this.userName.Text = "嗨哟阳光";
            this.userName.DoubleClick += new System.EventHandler(this.EntryName);
            // 
            // signature
            // 
            this.signature.BackColor = System.Drawing.Color.Transparent;
            this.signature.BorderColor = System.Drawing.Color.White;
            this.signature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signature.Location = new System.Drawing.Point(12, 85);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(288, 18);
            this.signature.TabIndex = 7;
            this.signature.Text = "这个人还没有个性签名";
            this.signature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signature.DoubleClick += new System.EventHandler(this.EntrySign);
            // 
            // UserPhoto
            // 
            this.UserPhoto.BackColor = System.Drawing.Color.Transparent;
            this.UserPhoto.ContextMenuStrip = this.choosePhoto;
            this.UserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("UserPhoto.Image")));
            this.UserPhoto.Location = new System.Drawing.Point(16, 12);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(60, 60);
            this.UserPhoto.TabIndex = 8;
            this.UserPhoto.TabStop = false;
            this.UserPhoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetNewPhoto);
            // 
            // choosePhoto
            // 
            this.choosePhoto.Arrow = System.Drawing.Color.Black;
            this.choosePhoto.Back = System.Drawing.Color.White;
            this.choosePhoto.BackRadius = 4;
            this.choosePhoto.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.choosePhoto.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.choosePhoto.Fore = System.Drawing.Color.Black;
            this.choosePhoto.HoverFore = System.Drawing.Color.White;
            this.choosePhoto.ItemAnamorphosis = true;
            this.choosePhoto.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.choosePhoto.ItemBorderShow = true;
            this.choosePhoto.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.choosePhoto.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.choosePhoto.ItemRadius = 4;
            this.choosePhoto.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.choosePhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择图片ToolStripMenuItem});
            this.choosePhoto.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.choosePhoto.Name = "choosePhoto";
            this.choosePhoto.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.choosePhoto.Size = new System.Drawing.Size(137, 26);
            this.choosePhoto.SkinAllColor = true;
            this.choosePhoto.TitleAnamorphosis = true;
            this.choosePhoto.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.choosePhoto.TitleRadius = 4;
            this.choosePhoto.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 选择图片ToolStripMenuItem
            // 
            this.选择图片ToolStripMenuItem.Name = "选择图片ToolStripMenuItem";
            this.选择图片ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择图片ToolStripMenuItem.Text = "   选择图片";
            // 
            // familyTitle
            // 
            this.familyTitle.BackColor = System.Drawing.Color.Transparent;
            this.familyTitle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.familyTitle.DownBack = null;
            this.familyTitle.Image = ((System.Drawing.Image)(resources.GetObject("familyTitle.Image")));
            this.familyTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.familyTitle.Location = new System.Drawing.Point(12, 439);
            this.familyTitle.MouseBack = null;
            this.familyTitle.Name = "familyTitle";
            this.familyTitle.NormlBack = null;
            this.familyTitle.Size = new System.Drawing.Size(316, 29);
            this.familyTitle.TabIndex = 9;
            this.familyTitle.Text = "我的家人(0/0)";
            this.familyTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.familyTitle.UseVisualStyleBackColor = false;
            // 
            // workTitle
            // 
            this.workTitle.BackColor = System.Drawing.Color.Transparent;
            this.workTitle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.workTitle.DownBack = null;
            this.workTitle.Image = ((System.Drawing.Image)(resources.GetObject("workTitle.Image")));
            this.workTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.workTitle.Location = new System.Drawing.Point(13, 474);
            this.workTitle.MouseBack = null;
            this.workTitle.Name = "workTitle";
            this.workTitle.NormlBack = null;
            this.workTitle.Size = new System.Drawing.Size(316, 29);
            this.workTitle.TabIndex = 11;
            this.workTitle.Text = "同事(0/0)";
            this.workTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workTitle.UseVisualStyleBackColor = false;
            // 
            // skinButton7
            // 
            this.skinButton7.BackColor = System.Drawing.Color.Transparent;
            this.skinButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton7.Create = true;
            this.skinButton7.DownBack = null;
            this.skinButton7.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinButton7.Location = new System.Drawing.Point(5, 57);
            this.skinButton7.MouseBack = null;
            this.skinButton7.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinButton7.Name = "skinButton7";
            this.skinButton7.NormlBack = null;
            this.skinButton7.Size = new System.Drawing.Size(309, 48);
            this.skinButton7.TabIndex = 1;
            this.skinButton7.UseVisualStyleBackColor = false;
            // 
            // skinButton8
            // 
            this.skinButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton8.DownBack = null;
            this.skinButton8.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButton8.Location = new System.Drawing.Point(5, 111);
            this.skinButton8.MouseBack = null;
            this.skinButton8.Name = "skinButton8";
            this.skinButton8.NormlBack = null;
            this.skinButton8.Size = new System.Drawing.Size(309, 48);
            this.skinButton8.TabIndex = 2;
            this.skinButton8.UseVisualStyleBackColor = false;
            // 
            // skinButton9
            // 
            this.skinButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButton9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton9.DownBack = null;
            this.skinButton9.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButton9.Location = new System.Drawing.Point(4, 165);
            this.skinButton9.MouseBack = null;
            this.skinButton9.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinButton9.Name = "skinButton9";
            this.skinButton9.NormlBack = null;
            this.skinButton9.Size = new System.Drawing.Size(309, 48);
            this.skinButton9.TabIndex = 3;
            this.skinButton9.UseVisualStyleBackColor = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.groupName2);
            this.skinPanel1.Controls.Add(this.groupButton2);
            this.skinPanel1.Controls.Add(this.groupName1);
            this.skinPanel1.Controls.Add(this.groupButton1);
            this.skinPanel1.Controls.Add(this.label12);
            this.skinPanel1.Controls.Add(this.label11);
            this.skinPanel1.Controls.Add(this.label10);
            this.skinPanel1.Controls.Add(this.label8);
            this.skinPanel1.Controls.Add(this.label7);
            this.skinPanel1.Controls.Add(this.label6);
            this.skinPanel1.Controls.Add(this.label5);
            this.skinPanel1.Controls.Add(this.label4);
            this.skinPanel1.Controls.Add(this.label3);
            this.skinPanel1.Controls.Add(this.mineSign);
            this.skinPanel1.Controls.Add(this.skinPictureBox5);
            this.skinPanel1.Controls.Add(this.skinPictureBox4);
            this.skinPanel1.Controls.Add(this.skinPictureBox3);
            this.skinPanel1.Controls.Add(this.mineName);
            this.skinPanel1.Controls.Add(this.skinPictureBox2);
            this.skinPanel1.Controls.Add(this.mineInfo);
            this.skinPanel1.Controls.Add(this.skinButton9);
            this.skinPanel1.Controls.Add(this.skinButton8);
            this.skinPanel1.Controls.Add(this.skinButton7);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(11, 218);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(317, 215);
            this.skinPanel1.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(126, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "（雾雨魔理沙）";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(81, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "（saki）";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(90, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "（雪风）";
            this.label10.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(53, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "这个人很懒,什么都没写!";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(53, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "这个人很懒,什么都没写!";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(55, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "雾雨魔理沙";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "saki";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(53, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "这个人很懒,什么都没写!";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(54, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "雪风";
            this.label3.UseWaitCursor = true;
            // 
            // mineSign
            // 
            this.mineSign.AutoSize = true;
            this.mineSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mineSign.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mineSign.Location = new System.Drawing.Point(54, 30);
            this.mineSign.Name = "mineSign";
            this.mineSign.Size = new System.Drawing.Size(137, 12);
            this.mineSign.TabIndex = 10;
            this.mineSign.Text = "这个人很懒,什么都没写!";
            this.mineSign.UseWaitCursor = true;
            // 
            // skinPictureBox5
            // 
            this.skinPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox5.Image")));
            this.skinPictureBox5.Location = new System.Drawing.Point(3, 57);
            this.skinPictureBox5.Name = "skinPictureBox5";
            this.skinPictureBox5.Size = new System.Drawing.Size(45, 45);
            this.skinPictureBox5.TabIndex = 9;
            this.skinPictureBox5.TabStop = false;
            // 
            // skinPictureBox4
            // 
            this.skinPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox4.Image")));
            this.skinPictureBox4.Location = new System.Drawing.Point(3, 111);
            this.skinPictureBox4.Name = "skinPictureBox4";
            this.skinPictureBox4.Size = new System.Drawing.Size(45, 45);
            this.skinPictureBox4.TabIndex = 8;
            this.skinPictureBox4.TabStop = false;
            // 
            // skinPictureBox3
            // 
            this.skinPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox3.Image")));
            this.skinPictureBox3.Location = new System.Drawing.Point(3, 167);
            this.skinPictureBox3.Name = "skinPictureBox3";
            this.skinPictureBox3.Size = new System.Drawing.Size(45, 45);
            this.skinPictureBox3.TabIndex = 7;
            this.skinPictureBox3.TabStop = false;
            // 
            // mineName
            // 
            this.mineName.AutoSize = true;
            this.mineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mineName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mineName.ForeColor = System.Drawing.Color.Red;
            this.mineName.Location = new System.Drawing.Point(54, 12);
            this.mineName.Name = "mineName";
            this.mineName.Size = new System.Drawing.Size(53, 12);
            this.mineName.TabIndex = 6;
            this.mineName.Text = "嗨哟阳光";
            this.mineName.UseWaitCursor = true;
            // 
            // skinPictureBox2
            // 
            this.skinPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox2.Image")));
            this.skinPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.skinPictureBox2.Name = "skinPictureBox2";
            this.skinPictureBox2.Size = new System.Drawing.Size(45, 45);
            this.skinPictureBox2.TabIndex = 5;
            this.skinPictureBox2.TabStop = false;
            // 
            // mineInfo
            // 
            this.mineInfo.BackColor = System.Drawing.Color.Transparent;
            this.mineInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mineInfo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mineInfo.DownBack = null;
            this.mineInfo.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mineInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mineInfo.Location = new System.Drawing.Point(4, 3);
            this.mineInfo.MouseBack = null;
            this.mineInfo.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mineInfo.Name = "mineInfo";
            this.mineInfo.NormlBack = null;
            this.mineInfo.Size = new System.Drawing.Size(309, 48);
            this.mineInfo.TabIndex = 4;
            this.mineInfo.UseVisualStyleBackColor = false;
            this.mineInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mineInfo_MouseDown);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Setting.ContextMenuStrip = this.Menu;
            this.Setting.Image = ((System.Drawing.Image)(resources.GetObject("Setting.Image")));
            this.Setting.Location = new System.Drawing.Point(0, 512);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(25, 24);
            this.Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Setting.TabIndex = 12;
            this.Setting.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加好友ToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(125, 26);
            // 
            // 添加好友ToolStripMenuItem
            // 
            this.添加好友ToolStripMenuItem.Name = "添加好友ToolStripMenuItem";
            this.添加好友ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加好友ToolStripMenuItem.Text = "添加好友";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // entryMyName
            // 
            this.entryMyName.Location = new System.Drawing.Point(81, 51);
            this.entryMyName.Name = "entryMyName";
            this.entryMyName.Size = new System.Drawing.Size(90, 21);
            this.entryMyName.TabIndex = 13;
            this.entryMyName.Visible = false;
            this.entryMyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetMyName);
            // 
            // signText
            // 
            this.signText.Location = new System.Drawing.Point(11, 85);
            this.signText.Name = "signText";
            this.signText.Size = new System.Drawing.Size(309, 21);
            this.signText.TabIndex = 14;
            this.signText.Visible = false;
            this.signText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetMySign);
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // groupButton1
            // 
            this.groupButton1.BackColor = System.Drawing.Color.Transparent;
            this.groupButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.groupButton1.DownBack = null;
            this.groupButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupButton1.Location = new System.Drawing.Point(3, -31);
            this.groupButton1.MouseBack = null;
            this.groupButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupButton1.Name = "groupButton1";
            this.groupButton1.NormlBack = null;
            this.groupButton1.Size = new System.Drawing.Size(316, 60);
            this.groupButton1.TabIndex = 21;
            this.groupButton1.UseVisualStyleBackColor = false;
            this.groupButton1.Visible = false;
            // 
            // groupName1
            // 
            this.groupName1.AutoSize = true;
            this.groupName1.BackColor = System.Drawing.Color.Transparent;
            this.groupName1.BorderColor = System.Drawing.Color.White;
            this.groupName1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupName1.Location = new System.Drawing.Point(93, -12);
            this.groupName1.Name = "groupName1";
            this.groupName1.Size = new System.Drawing.Size(88, 25);
            this.groupName1.TabIndex = 22;
            this.groupName1.Text = "你的群名";
            this.groupName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupButton2
            // 
            this.groupButton2.BackColor = System.Drawing.Color.Transparent;
            this.groupButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.groupButton2.DownBack = null;
            this.groupButton2.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupButton2.Location = new System.Drawing.Point(4, 45);
            this.groupButton2.MouseBack = null;
            this.groupButton2.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupButton2.Name = "groupButton2";
            this.groupButton2.NormlBack = null;
            this.groupButton2.Size = new System.Drawing.Size(315, 60);
            this.groupButton2.TabIndex = 23;
            this.groupButton2.UseVisualStyleBackColor = false;
            this.groupButton2.Visible = false;
            // 
            // groupName2
            // 
            this.groupName2.AutoSize = true;
            this.groupName2.BackColor = System.Drawing.Color.Transparent;
            this.groupName2.BorderColor = System.Drawing.Color.White;
            this.groupName2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupName2.Location = new System.Drawing.Point(94, 61);
            this.groupName2.Name = "groupName2";
            this.groupName2.Size = new System.Drawing.Size(88, 25);
            this.groupName2.TabIndex = 24;
            this.groupName2.Text = "你的群名";
            this.groupName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(340, 538);
            this.Controls.Add(this.signText);
            this.Controls.Add(this.entryMyName);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.workTitle);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.familyTitle);
            this.Controls.Add(this.UserPhoto);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.friendTitle);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.skinButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseChoose);
            this.Click += new System.EventHandler(this.CloseChild);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.choosePhoto.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinButton skinButton1;
		private CCWin.SkinControl.SkinButton groupButton;
		private CCWin.SkinControl.SkinButton skinButton3;
		private CCWin.SkinControl.SkinButton friendTitle;
		private CCWin.SkinControl.SkinTextBox skinTextBox1;
		private CCWin.SkinControl.SkinLabel userName;
		private CCWin.SkinControl.SkinLabel signature;
		private CCWin.SkinControl.SkinPictureBox UserPhoto;
		private CCWin.SkinControl.SkinButton familyTitle;
		private CCWin.SkinControl.SkinButton workTitle;
		private CCWin.SkinControl.SkinButton skinButton7;
		private CCWin.SkinControl.SkinButton skinButton8;
		private CCWin.SkinControl.SkinButton skinButton9;
		private CCWin.SkinControl.SkinPanel skinPanel1;
		private CCWin.SkinControl.SkinPictureBox skinPictureBox2;
		private CCWin.SkinControl.SkinButton mineInfo;
		private System.Windows.Forms.Label mineName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label mineSign;
		private CCWin.SkinControl.SkinPictureBox skinPictureBox5;
		private CCWin.SkinControl.SkinPictureBox skinPictureBox4;
		private CCWin.SkinControl.SkinPictureBox skinPictureBox3;
		private CCWin.SkinControl.SkinPictureBox Setting;
		private CCWin.SkinControl.SkinContextMenuStrip choosePhoto;
		private System.Windows.Forms.ToolStripMenuItem 选择图片ToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.TextBox entryMyName;
		private System.Windows.Forms.TextBox signText;
		private ContextMenuStrip Menu;
		private ToolStripMenuItem 添加好友ToolStripMenuItem;
        public static NotifyIcon notifyIcon1;
        private CCWin.SkinControl.SkinButton groupButton1;
        private CCWin.SkinControl.SkinLabel groupName2;
        private CCWin.SkinControl.SkinButton groupButton2;
        private CCWin.SkinControl.SkinLabel groupName1;
    }
}
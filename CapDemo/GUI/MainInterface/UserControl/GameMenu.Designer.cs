namespace CapDemo.GUI.User_Controls
{
    partial class GameMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ExitMenu = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pb_UserSetting = new System.Windows.Forms.PictureBox();
            this.cms_UserSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_ChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserSetting)).BeginInit();
            this.cms_UserSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(3, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(1018, 20);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Ten nguoi dung";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CapDemo.Properties.Resources.Hit_Your_Goal_2;
            this.pictureBox1.Location = new System.Drawing.Point(249, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ExitMenu
            // 
            this.btn_ExitMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExitMenu.BackgroundImage = global::CapDemo.Properties.Resources.T_menu;
            this.btn_ExitMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitMenu.Location = new System.Drawing.Point(358, 404);
            this.btn_ExitMenu.Name = "btn_ExitMenu";
            this.btn_ExitMenu.Size = new System.Drawing.Size(319, 63);
            this.btn_ExitMenu.TabIndex = 7;
            this.btn_ExitMenu.UseVisualStyleBackColor = false;
            this.btn_ExitMenu.Click += new System.EventHandler(this.btn_ExitMenu_Click);
            this.btn_ExitMenu.MouseEnter += new System.EventHandler(this.btn_ExitMenu_MouseHover);
            this.btn_ExitMenu.MouseLeave += new System.EventHandler(this.btn_ExitMenu_MouseLeave);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImage = global::CapDemo.Properties.Resources.HD_menu;
            this.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Location = new System.Drawing.Point(358, 327);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(319, 63);
            this.btn_Help.TabIndex = 6;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            this.btn_Help.MouseEnter += new System.EventHandler(this.btn_Help_MouseHover);
            this.btn_Help.MouseLeave += new System.EventHandler(this.btn_Help_MouseLeave);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BackgroundImage = global::CapDemo.Properties.Resources.CD_menu;
            this.btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Location = new System.Drawing.Point(358, 251);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(319, 63);
            this.btn_Setting.TabIndex = 5;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            this.btn_Setting.MouseEnter += new System.EventHandler(this.btn_Setting_MouseHover);
            this.btn_Setting.MouseLeave += new System.EventHandler(this.btn_Setting_MouseLeave);
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BackgroundImage = global::CapDemo.Properties.Resources.BD_menu;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(358, 173);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(319, 63);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            this.btn_Start.MouseEnter += new System.EventHandler(this.btn_Start_MouseHover);
            this.btn_Start.MouseLeave += new System.EventHandler(this.btn_Start_MouseLeave);
            // 
            // pb_UserSetting
            // 
            this.pb_UserSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_UserSetting.BackColor = System.Drawing.Color.Transparent;
            this.pb_UserSetting.BackgroundImage = global::CapDemo.Properties.Resources.setting;
            this.pb_UserSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_UserSetting.Location = new System.Drawing.Point(987, 30);
            this.pb_UserSetting.Name = "pb_UserSetting";
            this.pb_UserSetting.Size = new System.Drawing.Size(34, 35);
            this.pb_UserSetting.TabIndex = 13;
            this.pb_UserSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_UserSetting, "Setting");
            this.pb_UserSetting.Click += new System.EventHandler(this.pb_UserSetting_Click);
            // 
            // cms_UserSetting
            // 
            this.cms_UserSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ChangePass,
            this.tsmi_LogOut});
            this.cms_UserSetting.Name = "cms_UserSetting";
            this.cms_UserSetting.Size = new System.Drawing.Size(147, 48);
            // 
            // tsmi_ChangePass
            // 
            this.tsmi_ChangePass.Name = "tsmi_ChangePass";
            this.tsmi_ChangePass.Size = new System.Drawing.Size(146, 22);
            this.tsmi_ChangePass.Text = "Đổi Mật Khẩu";
            this.tsmi_ChangePass.Click += new System.EventHandler(this.tsmi_ChangePass_Click);
            // 
            // tsmi_LogOut
            // 
            this.tsmi_LogOut.Name = "tsmi_LogOut";
            this.tsmi_LogOut.Size = new System.Drawing.Size(146, 22);
            this.tsmi_LogOut.Text = "Đăng Xuất";
            this.tsmi_LogOut.Click += new System.EventHandler(this.tsmi_LogOut_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_UserSetting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_ExitMenu);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Start);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(1024, 700);
            this.Load += new System.EventHandler(this.GameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserSetting)).EndInit();
            this.cms_UserSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Button btn_ExitMenu;
        public System.Windows.Forms.Button btn_Help;
        public System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_UserSetting;
        private System.Windows.Forms.ContextMenuStrip cms_UserSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangePass;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogOut;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

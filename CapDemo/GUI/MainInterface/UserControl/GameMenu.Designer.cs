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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ChangePass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ExitMenu = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(848, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(902, 5);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(119, 20);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Ten nguoi dung";
            // 
            // lbl_ChangePass
            // 
            this.lbl_ChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChangePass.AutoSize = true;
            this.lbl_ChangePass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChangePass.ForeColor = System.Drawing.Color.White;
            this.lbl_ChangePass.Location = new System.Drawing.Point(848, 33);
            this.lbl_ChangePass.Name = "lbl_ChangePass";
            this.lbl_ChangePass.Size = new System.Drawing.Size(135, 16);
            this.lbl_ChangePass.TabIndex = 10;
            this.lbl_ChangePass.Text = "Thay đổi mật khẩu";
            this.lbl_ChangePass.Click += new System.EventHandler(this.lbl_ChangePass_Click);
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
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ChangePass);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExitMenu);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Start);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(1024, 700);
            this.Load += new System.EventHandler(this.GameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Button btn_ExitMenu;
        public System.Windows.Forms.Button btn_Help;
        public System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_ChangePass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

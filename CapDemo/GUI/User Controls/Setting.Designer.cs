namespace CapDemo.GUI.User_Controls
{
    partial class Setting
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
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.btn_DataManagement = new System.Windows.Forms.Button();
            this.btn_GameSetting = new System.Windows.Forms.Button();
            this.btn_UserManagement = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Setting = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Image = global::CapDemo.Properties.Resources.logo;
            this.ptb_logo.Location = new System.Drawing.Point(17, 19);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(203, 204);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // btn_DataManagement
            // 
            this.btn_DataManagement.BackColor = System.Drawing.Color.Transparent;
            this.btn_DataManagement.BackgroundImage = global::CapDemo.Properties.Resources.quan_ly_du_lieu;
            this.btn_DataManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DataManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DataManagement.Location = new System.Drawing.Point(17, 258);
            this.btn_DataManagement.Name = "btn_DataManagement";
            this.btn_DataManagement.Size = new System.Drawing.Size(203, 48);
            this.btn_DataManagement.TabIndex = 1;
            this.btn_DataManagement.UseVisualStyleBackColor = false;
            this.btn_DataManagement.Click += new System.EventHandler(this.btn_DataManagement_Click);
            // 
            // btn_GameSetting
            // 
            this.btn_GameSetting.BackColor = System.Drawing.Color.Transparent;
            this.btn_GameSetting.BackgroundImage = global::CapDemo.Properties.Resources.thiet_lap_game;
            this.btn_GameSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GameSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GameSetting.Location = new System.Drawing.Point(17, 321);
            this.btn_GameSetting.Name = "btn_GameSetting";
            this.btn_GameSetting.Size = new System.Drawing.Size(203, 48);
            this.btn_GameSetting.TabIndex = 2;
            this.btn_GameSetting.UseVisualStyleBackColor = false;
            this.btn_GameSetting.Click += new System.EventHandler(this.btn_GameSetting_Click);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.BackColor = System.Drawing.Color.Transparent;
            this.btn_UserManagement.BackgroundImage = global::CapDemo.Properties.Resources.quan_ly_tai_khoan;
            this.btn_UserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserManagement.Location = new System.Drawing.Point(17, 384);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Size = new System.Drawing.Size(203, 48);
            this.btn_UserManagement.TabIndex = 3;
            this.btn_UserManagement.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::CapDemo.Properties.Resources.Thoat_setting;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(17, 555);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 48);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_Setting
            // 
            this.pnl_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Setting.Location = new System.Drawing.Point(238, 19);
            this.pnl_Setting.Name = "pnl_Setting";
            this.pnl_Setting.Size = new System.Drawing.Size(710, 584);
            this.pnl_Setting.TabIndex = 5;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.backgroud_setting;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnl_Setting);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_UserManagement);
            this.Controls.Add(this.btn_GameSetting);
            this.Controls.Add(this.btn_DataManagement);
            this.Controls.Add(this.ptb_logo);
            this.DoubleBuffered = true;
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(960, 612);
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Button btn_GameSetting;
        private System.Windows.Forms.Button btn_UserManagement;
        private System.Windows.Forms.Panel pnl_Setting;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_DataManagement;
    }
}

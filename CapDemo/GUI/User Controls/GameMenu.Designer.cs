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
            this.btn_ExitMenu = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ExitMenu
            // 
            this.btn_ExitMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExitMenu.BackgroundImage = global::CapDemo.Properties.Resources.Thoat;
            this.btn_ExitMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitMenu.Location = new System.Drawing.Point(321, 435);
            this.btn_ExitMenu.Name = "btn_ExitMenu";
            this.btn_ExitMenu.Size = new System.Drawing.Size(319, 62);
            this.btn_ExitMenu.TabIndex = 7;
            this.btn_ExitMenu.UseVisualStyleBackColor = false;
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImage = global::CapDemo.Properties.Resources.HuongDan;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Location = new System.Drawing.Point(321, 358);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(319, 62);
            this.btn_Help.TabIndex = 6;
            this.btn_Help.UseVisualStyleBackColor = false;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BackgroundImage = global::CapDemo.Properties.Resources.CaiDat;
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Location = new System.Drawing.Point(321, 282);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(319, 62);
            this.btn_Setting.TabIndex = 5;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BackgroundImage = global::CapDemo.Properties.Resources.BatDau;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(321, 204);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(319, 62);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(776, 82);
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
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(830, 76);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(121, 22);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Ten nguoi dung";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.The_Weightless_World;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExitMenu);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Start);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(960, 612);
            this.Load += new System.EventHandler(this.GameMenu_Load);
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
    }
}

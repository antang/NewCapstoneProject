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
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.The_Weightless_World;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_ExitMenu);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Start);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(960, 612);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitMenu;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Start;
        public System.Windows.Forms.Button btn_Setting;
    }
}

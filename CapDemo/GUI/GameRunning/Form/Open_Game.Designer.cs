namespace CapDemo
{
    partial class Open_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open_Game));
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.ctMenuStrip_Setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnui_Maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnui_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pb_EndGame = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.pb_Setting = new System.Windows.Forms.PictureBox();
            this.pb_Play = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctMenuStrip_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.AutoScroll = true;
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.Location = new System.Drawing.Point(0, 4);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(932, 350);
            this.flp_Team.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(189, 435);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(807, 42);
            this.lbl_Time.TabIndex = 12;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wait time:";
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.SeaShell;
            this.lblHint.Location = new System.Drawing.Point(696, 704);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(287, 20);
            this.lblHint.TabIndex = 13;
            this.lblHint.Text = "Hint";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctMenuStrip_Setting
            // 
            this.ctMenuStrip_Setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnui_Maximize,
            this.mnui_Minimize});
            this.ctMenuStrip_Setting.Name = "ctMenuStrip_Setting";
            this.ctMenuStrip_Setting.ShowCheckMargin = true;
            this.ctMenuStrip_Setting.Size = new System.Drawing.Size(147, 48);
            // 
            // mnui_Maximize
            // 
            this.mnui_Maximize.Image = global::CapDemo.Properties.Resources.maximize;
            this.mnui_Maximize.Name = "mnui_Maximize";
            this.mnui_Maximize.Size = new System.Drawing.Size(146, 22);
            this.mnui_Maximize.Text = "Maximize";
            this.mnui_Maximize.Click += new System.EventHandler(this.mnui_Maximize_Click);
            // 
            // mnui_Minimize
            // 
            this.mnui_Minimize.Image = global::CapDemo.Properties.Resources.minimize;
            this.mnui_Minimize.Name = "mnui_Minimize";
            this.mnui_Minimize.Size = new System.Drawing.Size(146, 22);
            this.mnui_Minimize.Text = "Minimize";
            this.mnui_Minimize.Click += new System.EventHandler(this.mnui_Minimize_Click);
            // 
            // pb_EndGame
            // 
            this.pb_EndGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_EndGame.BackColor = System.Drawing.Color.Transparent;
            this.pb_EndGame.BackgroundImage = global::CapDemo.Properties.Resources.chiec_cup;
            this.pb_EndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_EndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_EndGame.Location = new System.Drawing.Point(470, 442);
            this.pb_EndGame.Name = "pb_EndGame";
            this.pb_EndGame.Size = new System.Drawing.Size(75, 69);
            this.pb_EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_EndGame.TabIndex = 16;
            this.pb_EndGame.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_EndGame, "Finish");
            this.pb_EndGame.Click += new System.EventHandler(this.pb_EndGame_Click);
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = global::CapDemo.Properties.Resources.Button_Close;
            this.pb_Exit.Location = new System.Drawing.Point(955, -1);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(50, 52);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 15;
            this.pb_Exit.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Exit, "Exit");
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // pb_Setting
            // 
            this.pb_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_Setting.Image = global::CapDemo.Properties.Resources.setting;
            this.pb_Setting.Location = new System.Drawing.Point(0, 682);
            this.pb_Setting.Name = "pb_Setting";
            this.pb_Setting.Size = new System.Drawing.Size(52, 42);
            this.pb_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Setting.TabIndex = 18;
            this.pb_Setting.TabStop = false;
            this.pb_Setting.Click += new System.EventHandler(this.pb_Setting_Click);
            // 
            // pb_Play
            // 
            this.pb_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Play.BackColor = System.Drawing.Color.Transparent;
            this.pb_Play.BackgroundImage = global::CapDemo.Properties.Resources.PlayGame;
            this.pb_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Play.Location = new System.Drawing.Point(852, 568);
            this.pb_Play.Name = "pb_Play";
            this.pb_Play.Size = new System.Drawing.Size(131, 128);
            this.pb_Play.TabIndex = 14;
            this.pb_Play.TabStop = false;
            this.pb_Play.Click += new System.EventHandler(this.pb_Play_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chon.png");
            this.imageList1.Images.SetKeyName(1, "dung.png");
            this.imageList1.Images.SetKeyName(2, "dung-2.png");
            // 
            // Open_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pb_Setting);
            this.Controls.Add(this.pb_EndGame);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.pb_Play);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flp_Team);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Open_Game";
            this.Text = "Open_Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Open_Game_Load);
            this.ctMenuStrip_Setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Team;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox pb_Play;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.PictureBox pb_EndGame;
        private System.Windows.Forms.ContextMenuStrip ctMenuStrip_Setting;
        private System.Windows.Forms.ToolStripMenuItem mnui_Maximize;
        private System.Windows.Forms.ToolStripMenuItem mnui_Minimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pb_Setting;
        private System.Windows.Forms.ImageList imageList1;
    }
}
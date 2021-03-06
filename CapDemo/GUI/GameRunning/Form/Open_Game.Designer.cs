﻿namespace CapDemo
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
            this.lblHint = new System.Windows.Forms.Label();
            this.ctMenuStrip_Setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnui_Maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnui_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnui_RestoreDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pb_EndGame = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.pb_Maximize = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Setting = new System.Windows.Forms.PictureBox();
            this.pb_Play = new System.Windows.Forms.PictureBox();
            this.pb_QuestionSub = new System.Windows.Forms.PictureBox();
            this.pb_SubContest = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.gp_Clock = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Seeting = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctMenuStrip_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SubContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.gp_Clock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pb_Seeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.Location = new System.Drawing.Point(1, 4);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(982, 323);
            this.flp_Team.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Time.Location = new System.Drawing.Point(68, 16);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(74, 55);
            this.lbl_Time.TabIndex = 12;
            this.lbl_Time.Text = "30";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbl_Time, "Time show Question");
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.SeaShell;
            this.lblHint.Location = new System.Drawing.Point(112, 695);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(882, 29);
            this.lblHint.TabIndex = 13;
            this.lblHint.Text = "Hint";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctMenuStrip_Setting
            // 
            this.ctMenuStrip_Setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnui_Maximize,
            this.mnui_Minimize,
            this.mnui_RestoreDown});
            this.ctMenuStrip_Setting.Name = "ctMenuStrip_Setting";
            this.ctMenuStrip_Setting.ShowCheckMargin = true;
            this.ctMenuStrip_Setting.Size = new System.Drawing.Size(170, 70);
            // 
            // mnui_Maximize
            // 
            this.mnui_Maximize.Image = global::CapDemo.Properties.Resources.maximize;
            this.mnui_Maximize.Name = "mnui_Maximize";
            this.mnui_Maximize.Size = new System.Drawing.Size(169, 22);
            this.mnui_Maximize.Text = "Maximize";
            this.mnui_Maximize.Click += new System.EventHandler(this.mnui_Maximize_Click);
            // 
            // mnui_Minimize
            // 
            this.mnui_Minimize.Image = global::CapDemo.Properties.Resources.minimize;
            this.mnui_Minimize.Name = "mnui_Minimize";
            this.mnui_Minimize.Size = new System.Drawing.Size(169, 22);
            this.mnui_Minimize.Text = "Minimize";
            this.mnui_Minimize.Click += new System.EventHandler(this.mnui_Minimize_Click);
            // 
            // mnui_RestoreDown
            // 
            this.mnui_RestoreDown.Image = global::CapDemo.Properties.Resources.RestoreDown;
            this.mnui_RestoreDown.Name = "mnui_RestoreDown";
            this.mnui_RestoreDown.Size = new System.Drawing.Size(169, 22);
            this.mnui_RestoreDown.Text = "Restore Down";
            this.mnui_RestoreDown.Click += new System.EventHandler(this.mnui_RestoreDown_Click);
            // 
            // pb_EndGame
            // 
            this.pb_EndGame.BackColor = System.Drawing.Color.Transparent;
            this.pb_EndGame.BackgroundImage = global::CapDemo.Properties.Resources.Rank_New;
            this.pb_EndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_EndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_EndGame.Location = new System.Drawing.Point(7, 16);
            this.pb_EndGame.Name = "pb_EndGame";
            this.pb_EndGame.Size = new System.Drawing.Size(52, 42);
            this.pb_EndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_EndGame.TabIndex = 16;
            this.pb_EndGame.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_EndGame, "Rank");
            this.pb_EndGame.Click += new System.EventHandler(this.pb_EndGame_Click);
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = global::CapDemo.Properties.Resources.Button_Close;
            this.pb_Exit.Location = new System.Drawing.Point(983, 5);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(25, 20);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 15;
            this.pb_Exit.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Exit, "Exit");
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // pb_Maximize
            // 
            this.pb_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.pb_Maximize.BackgroundImage = global::CapDemo.Properties.Resources.maximize_Windown;
            this.pb_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Maximize.Location = new System.Drawing.Point(983, 31);
            this.pb_Maximize.Name = "pb_Maximize";
            this.pb_Maximize.Size = new System.Drawing.Size(25, 20);
            this.pb_Maximize.TabIndex = 20;
            this.pb_Maximize.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Maximize, "Restore Down");
            this.pb_Maximize.Click += new System.EventHandler(this.pb_Maximize_Click);
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.pb_Minimize.BackgroundImage = global::CapDemo.Properties.Resources.minimize_Windown;
            this.pb_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Minimize.Location = new System.Drawing.Point(983, 57);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(25, 20);
            this.pb_Minimize.TabIndex = 19;
            this.pb_Minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Minimize, "Minimize");
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            // 
            // pb_Setting
            // 
            this.pb_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_Setting.BackColor = System.Drawing.Color.Transparent;
            this.pb_Setting.Image = global::CapDemo.Properties.Resources.Setting_New;
            this.pb_Setting.Location = new System.Drawing.Point(6, 113);
            this.pb_Setting.Name = "pb_Setting";
            this.pb_Setting.Size = new System.Drawing.Size(52, 42);
            this.pb_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Setting.TabIndex = 18;
            this.pb_Setting.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Setting, "Setting");
            this.pb_Setting.Click += new System.EventHandler(this.pb_Setting_Click);
            // 
            // pb_Play
            // 
            this.pb_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Play.BackColor = System.Drawing.Color.Transparent;
            this.pb_Play.BackgroundImage = global::CapDemo.Properties.Resources.videoplaybutton;
            this.pb_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Play.Location = new System.Drawing.Point(914, 614);
            this.pb_Play.Name = "pb_Play";
            this.pb_Play.Size = new System.Drawing.Size(91, 69);
            this.pb_Play.TabIndex = 14;
            this.pb_Play.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_Play, "Play");
            this.pb_Play.Click += new System.EventHandler(this.pb_Play_Click);
            // 
            // pb_QuestionSub
            // 
            this.pb_QuestionSub.BackColor = System.Drawing.Color.Transparent;
            this.pb_QuestionSub.BackgroundImage = global::CapDemo.Properties.Resources.Question_New;
            this.pb_QuestionSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_QuestionSub.Location = new System.Drawing.Point(6, 65);
            this.pb_QuestionSub.Name = "pb_QuestionSub";
            this.pb_QuestionSub.Size = new System.Drawing.Size(52, 42);
            this.pb_QuestionSub.TabIndex = 21;
            this.pb_QuestionSub.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_QuestionSub, "Question Screen");
            this.pb_QuestionSub.Click += new System.EventHandler(this.pb_QuestionSub_Click);
            // 
            // pb_SubContest
            // 
            this.pb_SubContest.BackColor = System.Drawing.Color.Transparent;
            this.pb_SubContest.BackgroundImage = global::CapDemo.Properties.Resources.Sub;
            this.pb_SubContest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_SubContest.Location = new System.Drawing.Point(821, 614);
            this.pb_SubContest.Name = "pb_SubContest";
            this.pb_SubContest.Size = new System.Drawing.Size(75, 69);
            this.pb_SubContest.TabIndex = 23;
            this.pb_SubContest.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_SubContest, "Sub Question");
            this.pb_SubContest.Visible = false;
            this.pb_SubContest.Click += new System.EventHandler(this.pb_SubContest_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chon.png");
            this.imageList1.Images.SetKeyName(1, "dung.png");
            this.imageList1.Images.SetKeyName(2, "dung-2.png");
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(7, 365);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(112, 106);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // gp_Clock
            // 
            this.gp_Clock.BackColor = System.Drawing.Color.Transparent;
            this.gp_Clock.Controls.Add(this.pictureBox1);
            this.gp_Clock.Controls.Add(this.lbl_Time);
            this.gp_Clock.Location = new System.Drawing.Point(852, 531);
            this.gp_Clock.Name = "gp_Clock";
            this.gp_Clock.Size = new System.Drawing.Size(153, 79);
            this.gp_Clock.TabIndex = 24;
            this.gp_Clock.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CapDemo.Properties.Resources.Clock;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Seeting
            // 
            this.pb_Seeting.BackColor = System.Drawing.Color.Transparent;
            this.pb_Seeting.Controls.Add(this.pb_EndGame);
            this.pb_Seeting.Controls.Add(this.pb_Setting);
            this.pb_Seeting.Controls.Add(this.pb_QuestionSub);
            this.pb_Seeting.Location = new System.Drawing.Point(5, 563);
            this.pb_Seeting.Name = "pb_Seeting";
            this.pb_Seeting.Size = new System.Drawing.Size(68, 162);
            this.pb_Seeting.TabIndex = 25;
            this.pb_Seeting.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CapDemo.Properties.Resources.w2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(349, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 234);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Open_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::CapDemo.Properties.Resources.Techno;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Seeting);
            this.Controls.Add(this.gp_Clock);
            this.Controls.Add(this.pb_SubContest);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pb_Maximize);
            this.Controls.Add(this.pb_Minimize);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.pb_Play);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.flp_Team);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Open_Game";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều Khiển Trò Chơi";
            this.Load += new System.EventHandler(this.Open_Game_Load);
            this.ctMenuStrip_Setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SubContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.gp_Clock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pb_Seeting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Team;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Time;
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
        private System.Windows.Forms.ToolStripMenuItem mnui_RestoreDown;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Maximize;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pb_QuestionSub;
        private System.Windows.Forms.PictureBox pb_SubContest;
        private System.Windows.Forms.GroupBox gp_Clock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox pb_Seeting;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
﻿namespace CapDemo
{
    partial class Audience_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audience_Screen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_EndGame = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_TeamEndGame = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tab_Map = new System.Windows.Forms.TabPage();
            this.pnl_Phase = new System.Windows.Forms.Panel();
            this.flp_Finish = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Lane = new System.Windows.Forms.Panel();
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_ShowQuestion = new System.Windows.Forms.TabPage();
            this.lbl_typeQ = new System.Windows.Forms.Label();
            this.pnl_QuestionFrame = new System.Windows.Forms.Panel();
            this.lbl_QuestionContent = new System.Windows.Forms.Label();
            this.flp_PlayerAnswers = new System.Windows.Forms.Panel();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Phase = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TimeShowQuestion = new System.Windows.Forms.Label();
            this.flp_AnswerQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tab_EndGame.SuspendLayout();
            this.tab_Map.SuspendLayout();
            this.tab_ShowQuestion.SuspendLayout();
            this.pnl_QuestionFrame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_Map);
            this.tabControl1.Controls.Add(this.tab_ShowQuestion);
            this.tabControl1.Controls.Add(this.tab_EndGame);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 771);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_EndGame
            // 
            this.tab_EndGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.tab_EndGame.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.tab_EndGame.Controls.Add(this.label1);
            this.tab_EndGame.Controls.Add(this.flp_TeamEndGame);
            this.tab_EndGame.Location = new System.Drawing.Point(4, 22);
            this.tab_EndGame.Name = "tab_EndGame";
            this.tab_EndGame.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EndGame.Size = new System.Drawing.Size(1018, 745);
            this.tab_EndGame.TabIndex = 2;
            this.tab_EndGame.Text = "tabPage1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(209, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 125);
            this.label1.TabIndex = 1;
            this.label1.Text = "Congratulation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flp_TeamEndGame
            // 
            this.flp_TeamEndGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_TeamEndGame.BackColor = System.Drawing.Color.Peru;
            this.flp_TeamEndGame.Location = new System.Drawing.Point(209, 159);
            this.flp_TeamEndGame.Name = "flp_TeamEndGame";
            this.flp_TeamEndGame.Size = new System.Drawing.Size(605, 410);
            this.flp_TeamEndGame.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ao-lon.png");
            this.imageList1.Images.SetKeyName(1, "ao-nho.png");
            this.imageList1.Images.SetKeyName(2, "chiec-cup.png");
            this.imageList1.Images.SetKeyName(3, "het-thach-dau.png");
            this.imageList1.Images.SetKeyName(4, "het-y-kien.png");
            this.imageList1.Images.SetKeyName(5, "hinh-tron-dung.png");
            this.imageList1.Images.SetKeyName(6, "hinh-tron-sai.png");
            this.imageList1.Images.SetKeyName(7, "hit-your-goal.png");
            this.imageList1.Images.SetKeyName(8, "khung-doi-thi.png");
            this.imageList1.Images.SetKeyName(9, "khung-vong-thi.png");
            this.imageList1.Images.SetKeyName(10, "nen-doi-thi.png");
            this.imageList1.Images.SetKeyName(11, "nen-vong-thi.png");
            this.imageList1.Images.SetKeyName(12, "thach-dau.png");
            this.imageList1.Images.SetKeyName(13, "trai-tim-dung.png");
            this.imageList1.Images.SetKeyName(14, "trai-tim-sai.png");
            this.imageList1.Images.SetKeyName(15, "y-kien.png");
            // 
            // tab_Map
            // 
            this.tab_Map.BackColor = System.Drawing.Color.Blue;
            this.tab_Map.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.tab_Map.Controls.Add(this.pnl_Phase);
            this.tab_Map.Controls.Add(this.flp_Finish);
            this.tab_Map.Controls.Add(this.pnl_Lane);
            this.tab_Map.Controls.Add(this.flp_Team);
            this.tab_Map.Location = new System.Drawing.Point(4, 22);
            this.tab_Map.Name = "tab_Map";
            this.tab_Map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Map.Size = new System.Drawing.Size(1018, 745);
            this.tab_Map.TabIndex = 0;
            this.tab_Map.Text = "tabPage1";
            // 
            // pnl_Phase
            // 
            this.pnl_Phase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Phase.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Phase.Location = new System.Drawing.Point(3, 89);
            this.pnl_Phase.Name = "pnl_Phase";
            this.pnl_Phase.Size = new System.Drawing.Size(282, 650);
            this.pnl_Phase.TabIndex = 4;
            // 
            // flp_Finish
            // 
            this.flp_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Finish.BackColor = System.Drawing.Color.Transparent;
            this.flp_Finish.BackgroundImage = global::CapDemo.Properties.Resources.chiec_cup;
            this.flp_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flp_Finish.Location = new System.Drawing.Point(283, 2);
            this.flp_Finish.Name = "flp_Finish";
            this.flp_Finish.Size = new System.Drawing.Size(428, 81);
            this.flp_Finish.TabIndex = 0;
            this.flp_Finish.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDoubleClick);
            this.flp_Finish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.flp_Finish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.flp_Finish.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
            // 
            // pnl_Lane
            // 
            this.pnl_Lane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Lane.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Lane.BackgroundImage = global::CapDemo.Properties.Resources.nen_doi_thi;
            this.pnl_Lane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Lane.Location = new System.Drawing.Point(283, 89);
            this.pnl_Lane.Name = "pnl_Lane";
            this.pnl_Lane.Size = new System.Drawing.Size(428, 650);
            this.pnl_Lane.TabIndex = 1;
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.BackgroundImage = global::CapDemo.Properties.Resources.nen_doi_thi;
            this.flp_Team.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Team.Location = new System.Drawing.Point(717, 0);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(300, 738);
            this.flp_Team.TabIndex = 3;
            // 
            // tab_ShowQuestion
            // 
            this.tab_ShowQuestion.BackColor = System.Drawing.Color.Blue;
            this.tab_ShowQuestion.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.tab_ShowQuestion.Controls.Add(this.lbl_typeQ);
            this.tab_ShowQuestion.Controls.Add(this.pnl_QuestionFrame);
            this.tab_ShowQuestion.Controls.Add(this.flp_PlayerAnswers);
            this.tab_ShowQuestion.Controls.Add(this.lbl_Point);
            this.tab_ShowQuestion.Controls.Add(this.lbl_Phase);
            this.tab_ShowQuestion.Controls.Add(this.panel1);
            this.tab_ShowQuestion.Controls.Add(this.flp_AnswerQuiz);
            this.tab_ShowQuestion.Location = new System.Drawing.Point(4, 22);
            this.tab_ShowQuestion.Name = "tab_ShowQuestion";
            this.tab_ShowQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShowQuestion.Size = new System.Drawing.Size(1018, 745);
            this.tab_ShowQuestion.TabIndex = 1;
            this.tab_ShowQuestion.Text = "tabPage2";
            // 
            // lbl_typeQ
            // 
            this.lbl_typeQ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeQ.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeQ.ForeColor = System.Drawing.Color.White;
            this.lbl_typeQ.Location = new System.Drawing.Point(1, 48);
            this.lbl_typeQ.Name = "lbl_typeQ";
            this.lbl_typeQ.Size = new System.Drawing.Size(304, 35);
            this.lbl_typeQ.TabIndex = 10;
            this.lbl_typeQ.Text = "Type:";
            this.lbl_typeQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_QuestionFrame
            // 
            this.pnl_QuestionFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_QuestionFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnl_QuestionFrame.BackgroundImage = global::CapDemo.Properties.Resources.Question;
            this.pnl_QuestionFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_QuestionFrame.Controls.Add(this.lbl_QuestionContent);
            this.pnl_QuestionFrame.Location = new System.Drawing.Point(0, 135);
            this.pnl_QuestionFrame.Name = "pnl_QuestionFrame";
            this.pnl_QuestionFrame.Size = new System.Drawing.Size(1018, 176);
            this.pnl_QuestionFrame.TabIndex = 9;
            // 
            // lbl_QuestionContent
            // 
            this.lbl_QuestionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QuestionContent.BackColor = System.Drawing.Color.Gray;
            this.lbl_QuestionContent.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionContent.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionContent.Location = new System.Drawing.Point(180, 14);
            this.lbl_QuestionContent.Name = "lbl_QuestionContent";
            this.lbl_QuestionContent.Size = new System.Drawing.Size(662, 147);
            this.lbl_QuestionContent.TabIndex = 0;
            // 
            // flp_PlayerAnswers
            // 
            this.flp_PlayerAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_PlayerAnswers.BackColor = System.Drawing.Color.Transparent;
            this.flp_PlayerAnswers.Location = new System.Drawing.Point(0, 320);
            this.flp_PlayerAnswers.Name = "flp_PlayerAnswers";
            this.flp_PlayerAnswers.Size = new System.Drawing.Size(1018, 89);
            this.flp_PlayerAnswers.TabIndex = 8;
            // 
            // lbl_Point
            // 
            this.lbl_Point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Point.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.ForeColor = System.Drawing.Color.White;
            this.lbl_Point.Location = new System.Drawing.Point(713, 3);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(302, 35);
            this.lbl_Point.TabIndex = 7;
            this.lbl_Point.Text = "Point: ";
            this.lbl_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Phase
            // 
            this.lbl_Phase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phase.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phase.ForeColor = System.Drawing.Color.White;
            this.lbl_Phase.Location = new System.Drawing.Point(1, 0);
            this.lbl_Phase.Name = "lbl_Phase";
            this.lbl_Phase.Size = new System.Drawing.Size(304, 35);
            this.lbl_Phase.TabIndex = 5;
            this.lbl_Phase.Text = "Phase";
            this.lbl_Phase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_TimeShowQuestion);
            this.panel1.Location = new System.Drawing.Point(304, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 132);
            this.panel1.TabIndex = 3;
            // 
            // lbl_TimeShowQuestion
            // 
            this.lbl_TimeShowQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TimeShowQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimeShowQuestion.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeShowQuestion.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TimeShowQuestion.Image = global::CapDemo.Properties.Resources.loading_circle;
            this.lbl_TimeShowQuestion.Location = new System.Drawing.Point(131, 0);
            this.lbl_TimeShowQuestion.Name = "lbl_TimeShowQuestion";
            this.lbl_TimeShowQuestion.Size = new System.Drawing.Size(156, 132);
            this.lbl_TimeShowQuestion.TabIndex = 2;
            this.lbl_TimeShowQuestion.Text = "0";
            this.lbl_TimeShowQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_AnswerQuiz
            // 
            this.flp_AnswerQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AnswerQuiz.BackColor = System.Drawing.Color.Transparent;
            this.flp_AnswerQuiz.Location = new System.Drawing.Point(0, 419);
            this.flp_AnswerQuiz.Name = "flp_AnswerQuiz";
            this.flp_AnswerQuiz.Size = new System.Drawing.Size(1018, 288);
            this.flp_AnswerQuiz.TabIndex = 1;
            // 
            // Audience_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Audience_Screen";
            this.Text = "Audience_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Audience_Screen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_EndGame.ResumeLayout(false);
            this.tab_Map.ResumeLayout(false);
            this.tab_ShowQuestion.ResumeLayout(false);
            this.pnl_QuestionFrame.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tab_Map;
        public System.Windows.Forms.TabPage tab_ShowQuestion;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerQuiz;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flp_Team;
        public System.Windows.Forms.TabPage tab_EndGame;
        public System.Windows.Forms.FlowLayoutPanel flp_TeamEndGame;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Point;
        public System.Windows.Forms.Label lbl_Phase;
        public System.Windows.Forms.Label lbl_TimeShowQuestion;
        private System.Windows.Forms.FlowLayoutPanel flp_Finish;
        public System.Windows.Forms.Panel pnl_Lane;
        public System.Windows.Forms.Panel pnl_Phase;
        public System.Windows.Forms.Panel flp_PlayerAnswers;
        public System.Windows.Forms.Label lbl_typeQ;
        public System.Windows.Forms.Panel pnl_QuestionFrame;
        public System.Windows.Forms.Label lbl_QuestionContent;
    }
}
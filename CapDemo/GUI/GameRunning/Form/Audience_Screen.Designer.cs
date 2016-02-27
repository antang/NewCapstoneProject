namespace CapDemo
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
            this.tbc_ShowGame = new System.Windows.Forms.TabControl();
            this.tab_Map = new System.Windows.Forms.TabPage();
            this.flp_Finish = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_PM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.pnl_Phase = new System.Windows.Forms.Panel();
            this.pnl_Lane = new System.Windows.Forms.Panel();
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_ShowQuestion = new System.Windows.Forms.TabPage();
            this.progressBarControl1 = new CapDemo.ProgressBarControl();
            this.lbl_TimeShowQuestion = new System.Windows.Forms.Label();
            this.lbl_typeQ = new System.Windows.Forms.Label();
            this.pnl_QuestionFrame = new System.Windows.Forms.Panel();
            this.lbl_QuestionContent = new System.Windows.Forms.Label();
            this.flp_PlayerAnswers = new System.Windows.Forms.Panel();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Phase = new System.Windows.Forms.Label();
            this.flp_AnswerQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_EndGame = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flp_TeamEndGame = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbc_ShowGame.SuspendLayout();
            this.tab_Map.SuspendLayout();
            this.tab_ShowQuestion.SuspendLayout();
            this.pnl_QuestionFrame.SuspendLayout();
            this.tab_EndGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_ShowGame
            // 
            this.tbc_ShowGame.Controls.Add(this.tab_Map);
            this.tbc_ShowGame.Controls.Add(this.tab_ShowQuestion);
            this.tbc_ShowGame.Controls.Add(this.tab_EndGame);
            this.tbc_ShowGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_ShowGame.Location = new System.Drawing.Point(0, 0);
            this.tbc_ShowGame.Name = "tbc_ShowGame";
            this.tbc_ShowGame.SelectedIndex = 0;
            this.tbc_ShowGame.Size = new System.Drawing.Size(1024, 768);
            this.tbc_ShowGame.TabIndex = 0;
            this.tbc_ShowGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.tbc_ShowGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.tbc_ShowGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // tab_Map
            // 
            this.tab_Map.BackColor = System.Drawing.Color.Blue;
            this.tab_Map.BackgroundImage = global::CapDemo.Properties.Resources.HitYourGoal_GiaoDienKhanGia;
            this.tab_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Map.Controls.Add(this.flp_Finish);
            this.tab_Map.Controls.Add(this.btn_PM);
            this.tab_Map.Controls.Add(this.label1);
            this.tab_Map.Controls.Add(this.lbl_Round);
            this.tab_Map.Controls.Add(this.pnl_Phase);
            this.tab_Map.Controls.Add(this.pnl_Lane);
            this.tab_Map.Controls.Add(this.flp_Team);
            this.tab_Map.Location = new System.Drawing.Point(4, 22);
            this.tab_Map.Name = "tab_Map";
            this.tab_Map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Map.Size = new System.Drawing.Size(1016, 742);
            this.tab_Map.TabIndex = 0;
            this.tab_Map.Text = "Player Information";
            this.tab_Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.tab_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.tab_Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // flp_Finish
            // 
            this.flp_Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_Finish.BackColor = System.Drawing.Color.White;
            this.flp_Finish.BackgroundImage = global::CapDemo.Properties.Resources.cup_1;
            this.flp_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flp_Finish.Location = new System.Drawing.Point(100, 56);
            this.flp_Finish.Name = "flp_Finish";
            this.flp_Finish.Size = new System.Drawing.Size(205, 83);
            this.flp_Finish.TabIndex = 0;
            this.flp_Finish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.flp_Finish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.flp_Finish.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // btn_PM
            // 
            this.btn_PM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PM.BackColor = System.Drawing.Color.White;
            this.btn_PM.BackgroundImage = global::CapDemo.Properties.Resources.PM;
            this.btn_PM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PM.ForeColor = System.Drawing.Color.White;
            this.btn_PM.Location = new System.Drawing.Point(30, 139);
            this.btn_PM.Name = "btn_PM";
            this.btn_PM.Size = new System.Drawing.Size(70, 513);
            this.btn_PM.TabIndex = 7;
            this.btn_PM.Text = "(35)";
            this.btn_PM.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(101, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_Round
            // 
            this.lbl_Round.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Round.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Round.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Round.ForeColor = System.Drawing.Color.White;
            this.lbl_Round.Location = new System.Drawing.Point(735, 690);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(257, 35);
            this.lbl_Round.TabIndex = 5;
            this.lbl_Round.Text = "label2";
            this.lbl_Round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_Round.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_Round.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // pnl_Phase
            // 
            this.pnl_Phase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Phase.BackColor = System.Drawing.Color.White;
            this.pnl_Phase.Location = new System.Drawing.Point(100, 139);
            this.pnl_Phase.Name = "pnl_Phase";
            this.pnl_Phase.Size = new System.Drawing.Size(205, 511);
            this.pnl_Phase.TabIndex = 4;
            this.pnl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.pnl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.pnl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // pnl_Lane
            // 
            this.pnl_Lane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Lane.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Lane.BackgroundImage = global::CapDemo.Properties.Resources.ArrowUp;
            this.pnl_Lane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Lane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Lane.Location = new System.Drawing.Point(308, 69);
            this.pnl_Lane.Name = "pnl_Lane";
            this.pnl_Lane.Size = new System.Drawing.Size(417, 628);
            this.pnl_Lane.TabIndex = 1;
            this.pnl_Lane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.pnl_Lane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.pnl_Lane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.Location = new System.Drawing.Point(735, 206);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(257, 465);
            this.flp_Team.TabIndex = 3;
            this.flp_Team.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.flp_Team.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.flp_Team.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // tab_ShowQuestion
            // 
            this.tab_ShowQuestion.BackColor = System.Drawing.Color.Blue;
            this.tab_ShowQuestion.BackgroundImage = global::CapDemo.Properties.Resources.BackGround_2;
            this.tab_ShowQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_ShowQuestion.Controls.Add(this.progressBarControl1);
            this.tab_ShowQuestion.Controls.Add(this.lbl_TimeShowQuestion);
            this.tab_ShowQuestion.Controls.Add(this.lbl_typeQ);
            this.tab_ShowQuestion.Controls.Add(this.pnl_QuestionFrame);
            this.tab_ShowQuestion.Controls.Add(this.flp_PlayerAnswers);
            this.tab_ShowQuestion.Controls.Add(this.lbl_Point);
            this.tab_ShowQuestion.Controls.Add(this.lbl_Phase);
            this.tab_ShowQuestion.Controls.Add(this.flp_AnswerQuiz);
            this.tab_ShowQuestion.Location = new System.Drawing.Point(4, 22);
            this.tab_ShowQuestion.Name = "tab_ShowQuestion";
            this.tab_ShowQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShowQuestion.Size = new System.Drawing.Size(1016, 742);
            this.tab_ShowQuestion.TabIndex = 1;
            this.tab_ShowQuestion.Text = "Show Question";
            this.tab_ShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.tab_ShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.tab_ShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.BackColor = System.Drawing.Color.Transparent;
            this.progressBarControl1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBarControl1.Location = new System.Drawing.Point(44, 58);
            this.progressBarControl1.Max = 0;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(929, 10);
            this.progressBarControl1.TabIndex = 12;
            this.progressBarControl1.Value = 0F;
            // 
            // lbl_TimeShowQuestion
            // 
            this.lbl_TimeShowQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimeShowQuestion.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeShowQuestion.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TimeShowQuestion.Location = new System.Drawing.Point(477, 3);
            this.lbl_TimeShowQuestion.Name = "lbl_TimeShowQuestion";
            this.lbl_TimeShowQuestion.Size = new System.Drawing.Size(129, 50);
            this.lbl_TimeShowQuestion.TabIndex = 2;
            this.lbl_TimeShowQuestion.Text = "0";
            this.lbl_TimeShowQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TimeShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_TimeShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_TimeShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // lbl_typeQ
            // 
            this.lbl_typeQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_typeQ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeQ.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeQ.ForeColor = System.Drawing.Color.White;
            this.lbl_typeQ.Location = new System.Drawing.Point(365, 0);
            this.lbl_typeQ.Name = "lbl_typeQ";
            this.lbl_typeQ.Size = new System.Drawing.Size(46, 19);
            this.lbl_typeQ.TabIndex = 10;
            this.lbl_typeQ.Text = "Type:";
            this.lbl_typeQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_typeQ.Visible = false;
            this.lbl_typeQ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_typeQ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_typeQ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // pnl_QuestionFrame
            // 
            this.pnl_QuestionFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_QuestionFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnl_QuestionFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_QuestionFrame.BackgroundImage")));
            this.pnl_QuestionFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_QuestionFrame.Controls.Add(this.lbl_QuestionContent);
            this.pnl_QuestionFrame.Location = new System.Drawing.Point(0, 61);
            this.pnl_QuestionFrame.Name = "pnl_QuestionFrame";
            this.pnl_QuestionFrame.Size = new System.Drawing.Size(1018, 256);
            this.pnl_QuestionFrame.TabIndex = 9;
            this.pnl_QuestionFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.pnl_QuestionFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.pnl_QuestionFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // lbl_QuestionContent
            // 
            this.lbl_QuestionContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_QuestionContent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionContent.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionContent.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionContent.Location = new System.Drawing.Point(49, 12);
            this.lbl_QuestionContent.Name = "lbl_QuestionContent";
            this.lbl_QuestionContent.Size = new System.Drawing.Size(924, 232);
            this.lbl_QuestionContent.TabIndex = 0;
            this.lbl_QuestionContent.Text = "abc\r\nabc\r\n}\r\nif\r\n{\r\ncon\r\n}\r\n}\r\nP\r\nP\r\nP\r\nP\r\nP";
            this.lbl_QuestionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_QuestionContent.TextChanged += new System.EventHandler(this.lbl_QuestionContent_TextChanged);
            this.lbl_QuestionContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_QuestionContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_QuestionContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // flp_PlayerAnswers
            // 
            this.flp_PlayerAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_PlayerAnswers.BackColor = System.Drawing.Color.Transparent;
            this.flp_PlayerAnswers.Location = new System.Drawing.Point(0, 323);
            this.flp_PlayerAnswers.Name = "flp_PlayerAnswers";
            this.flp_PlayerAnswers.Size = new System.Drawing.Size(1018, 110);
            this.flp_PlayerAnswers.TabIndex = 8;
            this.flp_PlayerAnswers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.flp_PlayerAnswers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.flp_PlayerAnswers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // lbl_Point
            // 
            this.lbl_Point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Point.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.ForeColor = System.Drawing.Color.White;
            this.lbl_Point.Location = new System.Drawing.Point(713, 3);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(302, 32);
            this.lbl_Point.TabIndex = 7;
            this.lbl_Point.Text = "Point: ";
            this.lbl_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_Point.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_Point.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // lbl_Phase
            // 
            this.lbl_Phase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phase.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phase.ForeColor = System.Drawing.Color.White;
            this.lbl_Phase.Location = new System.Drawing.Point(1, 0);
            this.lbl_Phase.Name = "lbl_Phase";
            this.lbl_Phase.Size = new System.Drawing.Size(358, 35);
            this.lbl_Phase.TabIndex = 5;
            this.lbl_Phase.Text = "Phase";
            this.lbl_Phase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.lbl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.lbl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // flp_AnswerQuiz
            // 
            this.flp_AnswerQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AnswerQuiz.BackColor = System.Drawing.Color.Transparent;
            this.flp_AnswerQuiz.Location = new System.Drawing.Point(0, 436);
            this.flp_AnswerQuiz.Name = "flp_AnswerQuiz";
            this.flp_AnswerQuiz.Size = new System.Drawing.Size(1018, 303);
            this.flp_AnswerQuiz.TabIndex = 1;
            this.flp_AnswerQuiz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.flp_AnswerQuiz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.flp_AnswerQuiz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // tab_EndGame
            // 
            this.tab_EndGame.BackColor = System.Drawing.Color.White;
            this.tab_EndGame.BackgroundImage = global::CapDemo.Properties.Resources.BackGround_2;
            this.tab_EndGame.Controls.Add(this.panel2);
            this.tab_EndGame.Location = new System.Drawing.Point(4, 22);
            this.tab_EndGame.Name = "tab_EndGame";
            this.tab_EndGame.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EndGame.Size = new System.Drawing.Size(1016, 742);
            this.tab_EndGame.TabIndex = 2;
            this.tab_EndGame.Text = "End Game";
            this.tab_EndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.tab_EndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.tab_EndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::CapDemo.Properties.Resources.Congratulation_bg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.flp_TeamEndGame);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 742);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
            // 
            // flp_TeamEndGame
            // 
            this.flp_TeamEndGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_TeamEndGame.BackColor = System.Drawing.Color.Transparent;
            this.flp_TeamEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_TeamEndGame.Location = new System.Drawing.Point(243, 161);
            this.flp_TeamEndGame.Name = "flp_TeamEndGame";
            this.flp_TeamEndGame.Size = new System.Drawing.Size(534, 541);
            this.flp_TeamEndGame.TabIndex = 0;
            this.flp_TeamEndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseDown);
            this.flp_TeamEndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseMove);
            this.flp_TeamEndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbc_ShowGame_MouseUp);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Audience_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tbc_ShowGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Audience_Screen";
            this.ShowInTaskbar = false;
            this.Text = "Hiển thị Game";
            this.Load += new System.EventHandler(this.Audience_Screen_Load);
            this.tbc_ShowGame.ResumeLayout(false);
            this.tab_Map.ResumeLayout(false);
            this.tab_ShowQuestion.ResumeLayout(false);
            this.pnl_QuestionFrame.ResumeLayout(false);
            this.tab_EndGame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tbc_ShowGame;
        public System.Windows.Forms.TabPage tab_Map;
        public System.Windows.Forms.TabPage tab_ShowQuestion;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerQuiz;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.FlowLayoutPanel flp_Team;
        public System.Windows.Forms.TabPage tab_EndGame;
        public System.Windows.Forms.FlowLayoutPanel flp_TeamEndGame;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Round;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btn_PM;
        public ProgressBarControl progressBarControl1;
    }
}
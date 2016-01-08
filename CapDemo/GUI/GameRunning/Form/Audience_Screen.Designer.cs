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
            this.lbl_Round = new System.Windows.Forms.Label();
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
            this.tab_EndGame = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flp_TeamEndGame = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbc_ShowGame.SuspendLayout();
            this.tab_Map.SuspendLayout();
            this.pnl_Phase.SuspendLayout();
            this.tab_ShowQuestion.SuspendLayout();
            this.pnl_QuestionFrame.SuspendLayout();
            this.panel1.SuspendLayout();
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
<<<<<<< HEAD
            this.tbc_ShowGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.tbc_ShowGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.tbc_ShowGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.tbc_ShowGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.tbc_ShowGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.tbc_ShowGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // tab_Map
            // 
            this.tab_Map.BackColor = System.Drawing.Color.Blue;
            this.tab_Map.BackgroundImage = global::CapDemo.Properties.Resources.HitYourGoal_GiaoDienKhanGia;
            this.tab_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
<<<<<<< HEAD
            this.tab_Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.tab_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.tab_Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.tab_Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.tab_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.tab_Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.lbl_Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_Round.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_Round.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_Round.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_Round.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // pnl_Phase
            // 
            this.pnl_Phase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Phase.BackColor = System.Drawing.Color.White;
            this.pnl_Phase.Controls.Add(this.flp_Finish);
            this.pnl_Phase.Location = new System.Drawing.Point(29, 69);
            this.pnl_Phase.Name = "pnl_Phase";
            this.pnl_Phase.Size = new System.Drawing.Size(205, 628);
            this.pnl_Phase.TabIndex = 4;
<<<<<<< HEAD
            this.pnl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.pnl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.pnl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.pnl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.pnl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.pnl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // flp_Finish
            // 
            this.flp_Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_Finish.BackColor = System.Drawing.Color.White;
            this.flp_Finish.BackgroundImage = global::CapDemo.Properties.Resources.chiec_cup;
            this.flp_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flp_Finish.Location = new System.Drawing.Point(1, 2);
            this.flp_Finish.Name = "flp_Finish";
            this.flp_Finish.Size = new System.Drawing.Size(203, 50);
            this.flp_Finish.TabIndex = 0;
            this.flp_Finish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.flp_Finish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.flp_Finish.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
            // 
            // pnl_Lane
            // 
            this.pnl_Lane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Lane.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Lane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Lane.Location = new System.Drawing.Point(235, 69);
            this.pnl_Lane.Name = "pnl_Lane";
            this.pnl_Lane.Size = new System.Drawing.Size(490, 628);
            this.pnl_Lane.TabIndex = 1;
<<<<<<< HEAD
            this.pnl_Lane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.pnl_Lane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.pnl_Lane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.pnl_Lane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.pnl_Lane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.pnl_Lane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.Location = new System.Drawing.Point(735, 206);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(257, 465);
            this.flp_Team.TabIndex = 3;
<<<<<<< HEAD
            this.flp_Team.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.flp_Team.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.flp_Team.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.flp_Team.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.flp_Team.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.flp_Team.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // tab_ShowQuestion
            // 
            this.tab_ShowQuestion.BackColor = System.Drawing.Color.Blue;
            this.tab_ShowQuestion.BackgroundImage = global::CapDemo.Properties.Resources.BackGround_2;
            this.tab_ShowQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tab_ShowQuestion.Size = new System.Drawing.Size(1016, 742);
            this.tab_ShowQuestion.TabIndex = 1;
            this.tab_ShowQuestion.Text = "Show Question";
<<<<<<< HEAD
            this.tab_ShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.tab_ShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.tab_ShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.tab_ShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.tab_ShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.tab_ShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // lbl_typeQ
            // 
            this.lbl_typeQ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeQ.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeQ.ForeColor = System.Drawing.Color.White;
            this.lbl_typeQ.Location = new System.Drawing.Point(1, 48);
            this.lbl_typeQ.Name = "lbl_typeQ";
            this.lbl_typeQ.Size = new System.Drawing.Size(304, 35);
            this.lbl_typeQ.TabIndex = 10;
            this.lbl_typeQ.Text = "Type:";
            this.lbl_typeQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.lbl_typeQ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_typeQ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_typeQ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_typeQ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_typeQ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_typeQ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.pnl_QuestionFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.pnl_QuestionFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.pnl_QuestionFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.pnl_QuestionFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.pnl_QuestionFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.pnl_QuestionFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // lbl_QuestionContent
            // 
            this.lbl_QuestionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QuestionContent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionContent.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionContent.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionContent.Location = new System.Drawing.Point(180, 14);
            this.lbl_QuestionContent.Name = "lbl_QuestionContent";
            this.lbl_QuestionContent.Size = new System.Drawing.Size(662, 147);
            this.lbl_QuestionContent.TabIndex = 0;
            this.lbl_QuestionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.lbl_QuestionContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_QuestionContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_QuestionContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_QuestionContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_QuestionContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_QuestionContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.flp_PlayerAnswers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.flp_PlayerAnswers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.flp_PlayerAnswers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.flp_PlayerAnswers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.flp_PlayerAnswers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.flp_PlayerAnswers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // lbl_Point
            // 
            this.lbl_Point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Point.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.ForeColor = System.Drawing.Color.White;
            this.lbl_Point.Location = new System.Drawing.Point(713, 3);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(302, 35);
            this.lbl_Point.TabIndex = 7;
            this.lbl_Point.Text = "Point: ";
            this.lbl_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
<<<<<<< HEAD
            this.lbl_Point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_Point.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_Point.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_Point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_Point.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_Point.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
            // 
            // lbl_Phase
            // 
            this.lbl_Phase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phase.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phase.ForeColor = System.Drawing.Color.White;
            this.lbl_Phase.Location = new System.Drawing.Point(1, 0);
            this.lbl_Phase.Name = "lbl_Phase";
            this.lbl_Phase.Size = new System.Drawing.Size(304, 35);
            this.lbl_Phase.TabIndex = 5;
            this.lbl_Phase.Text = "Phase";
            this.lbl_Phase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.lbl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_Phase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_Phase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_Phase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.lbl_TimeShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.lbl_TimeShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.lbl_TimeShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.lbl_TimeShowQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.lbl_TimeShowQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.lbl_TimeShowQuestion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.flp_AnswerQuiz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.flp_AnswerQuiz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.flp_AnswerQuiz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.flp_AnswerQuiz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.flp_AnswerQuiz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.flp_AnswerQuiz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.tab_EndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.tab_EndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.tab_EndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.tab_EndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.tab_EndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.tab_EndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
<<<<<<< HEAD
            this.flp_TeamEndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseDown_1);
            this.flp_TeamEndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseMove_1);
            this.flp_TeamEndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Phase_MouseUp_1);
=======
            this.flp_TeamEndGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseDown);
            this.flp_TeamEndGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseMove);
            this.flp_TeamEndGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flp_Finish_MouseUp);
>>>>>>> an1
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
            this.pnl_Phase.ResumeLayout(false);
            this.tab_ShowQuestion.ResumeLayout(false);
            this.pnl_QuestionFrame.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
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
    }
}
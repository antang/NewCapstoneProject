using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using myStruct;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CapDemo.GUI.User_Controls;

namespace CapDemo
{
    public partial class Open_Game : Form
    {
        public Open_Game()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        int iDContest;
        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }
        int teamtTag = 0;
        #region Declare
        Player Player = new Player();
        Contest Contest = new Contest();
        Phase Phase = new Phase();
        Question Question = new Question();
        Log Log = new Log();
        LogBL logBL = new LogBL();

        PlayerBL PlayerBL = new PlayerBL();
        ContestBL ContestBL = new ContestBL();
        PhaseBL PhaseBL = new PhaseBL();
        PhaseQuestionBL PhaseQuestionBl = new PhaseQuestionBL();
        QuestionBL QuestionBL = new QuestionBL();

        List<int> listIDQuestion = new List<int>();
        List<int> listIDPlayer = new List<int>();
        List<int> PlayerNO = new List<int>();

        List<Record> records = new List<Record>();
        Audience_Screen audience = new Audience_Screen();

        int AmountPlayer;
        int AmountPhase;
        int AutoShowQuestion;
        int AutoShowAnswer;
        int AmountSteptoPass;
        int AmountSteptofail;
        int TimeSupport;
        int Bonus;
        int ChallengeScore;
        int NumofChallenge;

        int idPlayer;

        string typequestion = "";
        string CorrectShortAnswer = "";
        string PlayerAnswerShortQuestion = "";
        string CorrectAnswerChallenge= "";
        int step = 1;
        int team = 0;
        bool CheckQuestionPM = false;
        bool CheckChallengeChoice = false;
        bool Done = true;
        bool GameOver = false;
        int IDPhasePM;

        string[] guideline = new string[] 
        {"Bấm để tải sơ đồ cuộc thi",
        "Bấm để đến lượt đội thi đấu tiếp theo",
        "Bấm để hiển thị câu hỏi và các câu trả lời",
        "Bấm để hiển thị đáp án của đội thi đấu chọn",
        "Bấm để hiển thị đáp án đúng nhất",
        "Bấm để hiển thị sơ đồ các đội",
        "Bấm để cập nhật điểm cho đội thi đấu"};
        #endregion      

        //get contest content
        public void GetContestContent()
        {
            //get contest
            Contest.IDContest = iDContest;
            List<Contest> ListContest;
            ListContest = ContestBL.GetContestByID(Contest);
            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    AutoShowQuestion = ListContest.ElementAt(i).TimeShowQuestion;
                    AutoShowAnswer = ListContest.ElementAt(i).TimeShowAnswer;
                    AmountSteptoPass = ListContest.ElementAt(i).TimesTrue;
                    AmountSteptofail = ListContest.ElementAt(i).TimesFalse;
                    TimeSupport = ListContest.ElementAt(i).TimeSupport;
                    Bonus = ListContest.ElementAt(i).Bonus;
                    ChallengeScore = ListContest.ElementAt(i).ChallengceScore;
                    NumofChallenge = ListContest.ElementAt(i).NumberChallenge;
                }
            }

            //get phase
            Phase.IDContest = iDContest;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseNormal(Phase);
            AmountPhase = ListPhase.Count;

            //get player
            Player.IDContest = iDContest;
            List<Player> ListPlayer;
            ListPlayer = PlayerBL.GetPlayerByIDContest(Player);
            AmountPlayer = ListPlayer.Count;
            if (ListPlayer != null)
            {
                for (int i = 0; i < ListPlayer.Count; i++)
                {
                    if (ListPlayer.ElementAt(i) != null)
                    {
                        Team team = new Team();
                        teamtTag++;
                        team.Tag = teamtTag;
                        team.IdPlayerUC = teamtTag;
                        //subcribe event
                        team.checkSupport += team_checkSupport;
                        team.checkQuestionPM += team_checkQuestionPM;
                        team.checkChallenge += team_checkChallenge;
                        team.lbl_TeamName.Text = ListPlayer.ElementAt(i).PlayerName;
                        team.lbl_TeamScore.Text = ListPlayer.ElementAt(i).PlayerScore.ToString();
                        team.lbl_CurrentPhase.Text = ListPhase[0].NamePhase;
                        team.lbl_Sequence.Text = ListPlayer.ElementAt(i).Sequence.ToString();
                        team.lbl_IDPlayer.Text = ListPlayer.ElementAt(i).IDPlayer.ToString();
                        team.gb_team.Visible = false;
                        idPlayer = ListPlayer.ElementAt(i).IDPlayer;
                        
                        Record r = new Record(idPlayer, ListPhase[0].IDPhase, iDContest,AmountSteptoPass,AmountSteptofail,true,true,true,0, ListPlayer.ElementAt(i).PlayerScore,0,i);
                        records.Add(r);

                        flp_Team.Controls.Add(team);
                    }
                }
            }
        }
        #region EventHandler
        //Get evenhanler check challenge choice
        void team_checkChallenge(object sender, EventArgs e)
        {
            int idPlayerUC = (e as MyEventArgs).IDPlayerUC;
            foreach (Team TeamCS in flp_Team.Controls)
            {
                if (TeamCS.IdPlayerUC == idPlayerUC)
                {
                    DialogResult dr = MessageBox.Show("Are you sure to use this choice?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        records.ElementAt(team).Defy = false;
                        //TeamCS.gb_team.Visible = false;
                        TeamCS.chk_defy.Visible = false;
                        CheckChallengeChoice = true;
                        ShowTeamsChallenged();
                    }
                    else
                    {
                        TeamCS.chk_defy.Checked = false;
                    }
                }
            }
        }
        //get eventhadler check question PM
        void team_checkQuestionPM(object sender, EventArgs e)
        {
            int idPlayerUC = (e as MyEventArgs).IDPlayerUC;
            foreach (Team TeamCS in flp_Team.Controls)
            {
                if (TeamCS.IdPlayerUC == idPlayerUC)
                {
                     DialogResult dr = MessageBox.Show("Are you sure to use Question PM?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (dr == DialogResult.Yes)
                     {
                         try
                         {
                             List<Phase> ListPhase;
                             Phase.IDContest = iDContest;
                             ListPhase = PhaseBL.GetPhasePM(Phase);
                             IDPhasePM = ListPhase.ElementAt(0).IDPhase;
                             int countTeamChallenged = 0;
                             //count team is challenged
                             foreach (Team teamCS in flp_Team.Controls)
                             {
                                 if (teamCS.chk_Challenged.Checked == true)
                                 {
                                     countTeamChallenged++;
                                 }
                             }
                             //show question have challenge choice
                             if (CheckChallengeChoice == true)
                             {
                                 if (countTeamChallenged == 0)
                                 {
                                     MessageBox.Show("Please selected challenge team!");
                                     TeamCS.chk_QuestionPM.Checked = false;
                                 }
                                 else
                                 {
                                     foreach (Team teamCS in flp_Team.Controls)
                                     {
                                         if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                                         {
                                             teamCS.gb_team.Visible = false;
                                             CheckQuestionPM = true;
                                             //show audience screen
                                             lblHint.Text = guideline[3].ToString();
                                             audience.tabControl1.SelectedTab = audience.tab_ShowQuestion;
                                             //show question by id phase
                                             ShowQuestionByIDPhase(IDPhasePM);
                                         }
                                     }
                                 }
                             }
                             else
                             {//show question don't have challenge choice
                                 foreach (Team teamCS in flp_Team.Controls)
                                 {
                                     if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                                     {
                                         if (records.ElementAt(team).Support == false)
                                         {
                                             teamCS.gb_team.Visible = false;
                                             teamCS.chk_Support.Visible = false;
                                         }
                                         else
                                         {
                                             teamCS.chk_Support.Visible = true;
                                         }
                                         teamCS.chk_QuestionPM.Visible = false;
                                         teamCS.chk_defy.Visible = false;
                                         CheckQuestionPM = true;
                                         //show audience screen
                                         lblHint.Text = guideline[3].ToString();
                                         audience.tabControl1.SelectedTab = audience.tab_ShowQuestion;
                                         //show question by id phase
                                         ShowQuestionByIDPhase(IDPhasePM);
                                     }
                                 }
                             } 
                         }
                         catch (Exception)
                         {
                             MessageBox.Show("Question is not set up in game. Please choose question in phase");
                             TeamCS.chk_QuestionPM.Checked = false;
                         }
                         
                     }
                     else
                     {
                         TeamCS.chk_QuestionPM.Checked = false;
                     }
                }
            }  
        }
        //get eventhandler check support from audience choice
        void team_checkSupport(object sender, EventArgs e)
        {
            int idPlayerUC = (e as MyEventArgs).IDPlayerUC;
            foreach (Team TeamCS in flp_Team.Controls)
            {
                if (TeamCS.IdPlayerUC == idPlayerUC)
                {
                    timer1.Stop();
                    audience.timer1.Stop();
                    DialogResult dr = MessageBox.Show("Are you sure to use this choice?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        records.ElementAt(team).Support = false;
                        //hide support choice on controller screen
                        TeamCS.chk_Support.Visible = false;
                        //show time on controller screen
                        lbl_Time.Text = (Convert.ToInt32(lbl_Time.Text)+(TimeSupport)).ToString();
                        timer1.Interval = 1000;
                        timer1.Start();
                        //show time on audience screen
                        audience.lbl_TimeShowQuestion.Text = (Convert.ToInt32(audience.lbl_TimeShowQuestion.Text) + (TimeSupport)).ToString();
                        audience.timer1.Interval = 1000;
                        audience.timer1.Start();
                        //hint support choice on controller screen after it has been used

                        foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
                        {
                            if (Convert.ToInt32(teamAdienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                            {
                                teamAdienceScreen.pb_SupportChoice.Image = Properties.Resources.het_y_kien;
                            }
                        }

                    }
                    else
                    {
                        timer1.Start();
                        audience.timer1.Start();
                        TeamCS.chk_Support.Checked = false;
                    }
                }
            }
        }
        #endregion
        //load form
        private void Open_Game_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetContestContent();
            lblHint.Text = guideline[0].ToString();
        }
        
        #region EachStepToControl
        //--1 load Map
        public void loadMap()
        {
            audience.Show();
            audience.flp_PlayerAnswers.Controls.Clear();
            CheckChallengeChoice = false;
            CheckQuestionPM = false;
            typequestion = "";
            CorrectShortAnswer = "";
            PlayerAnswerShortQuestion = "";
            CorrectAnswerChallenge = "";

            if (team == records.Count)
            {
                team = 0;
            }
            int i = 0;
            //show all team on controller screen
            foreach (Team teamControllerScreen in flp_Team.Controls)
            {
                teamControllerScreen.BackColor = Color.Gainsboro;
                teamControllerScreen.lbl_TeamName.Text = nameplayer(records.ElementAt(i).IDPlayer);
                teamControllerScreen.lbl_TeamScore.Text = records.ElementAt(i).TeamScore.ToString();
                teamControllerScreen.lbl_CurrentPhase.Text = NameofPhase(records.ElementAt(i).IDPhase);
                teamControllerScreen.chk_Challenged.Checked = false;
                teamControllerScreen.gb_team.Visible = false;
                teamControllerScreen.chk_QuestionPM.Checked = false;
                teamControllerScreen.chk_defy.Checked = false;
                teamControllerScreen.chk_Support.Checked = false;
                teamControllerScreen.flp_Answer.Controls.Clear();
                teamControllerScreen.flp_Answer.Visible = false;
                
                i++;
            }
            //show lanes in audience screen
            foreach (Player_Lane1 playerLane in audience.pnl_Lane.Controls)
            {
                playerLane.pb_Team.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(playerLane.lbl_IDPlayer.Text)));
                playerLane.HighLight(false);
            }

            int j = 0;
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                teamAdienceScreen.HighLight(false);
                teamAdienceScreen.BackColor = Color.White;
                teamAdienceScreen.lbl_TeamName.Text = nameplayer(records.ElementAt(j).IDPlayer);
                teamAdienceScreen.lbl_TeamScore.Text = records.ElementAt(j).TeamScore.ToString();
                //check support choice exist to show
                if (records.ElementAt(j).Support==true)
                {
                    //keep image
                }
                else
                {
                    teamAdienceScreen.pb_SupportChoice.Image = Properties.Resources.het_y_kien;
                }
                //check challenge choice exist to show
                if (records.ElementAt(j).Defy == true)
                {
                    //keep image
                }
                else
                {
                    teamAdienceScreen.pb_ChallengeChoice.Image = Properties.Resources.het_thach_dau;
                }
                //show heart in player
                if (records.ElementAt(j).NumFail==3)
                {
                    teamAdienceScreen.pb_Heart1.Show();
                    teamAdienceScreen.pb_Heart2.Show();
                    teamAdienceScreen.pb_Heart3.Show();
                }
                else
                {
                    if (records.ElementAt(j).NumFail == 2)
                    {
                        teamAdienceScreen.pb_Heart1.Show();
                        teamAdienceScreen.pb_Heart2.Show();
                        teamAdienceScreen.pb_Heart3.Hide();
                    }
                    else
                    {
                        if (records.ElementAt(j).NumFail == 1)
                        {
                            teamAdienceScreen.pb_Heart1.Show();
                            teamAdienceScreen.pb_Heart2.Hide();
                            teamAdienceScreen.pb_Heart3.Hide();
                        }
                        else
                        {
                            teamAdienceScreen.pb_Heart1.Hide();
                            teamAdienceScreen.pb_Heart2.Hide();
                            teamAdienceScreen.pb_Heart3.Hide();
                        }
                    }
                }
                j++;
            }
            //Clear panel
            audience.flp_AnswerQuiz.Controls.Clear();
            audience.richTextBox1.Text = "";
            audience.lbl_Phase.Text = "";
            audience.lbl_Point.Text = "";
            //move to next step
            step++;
        }
        //--2 Go player will compete
        public void GoPlayer()
        {
            // Get team in turn
            for (int i = 0; i < records.Count; i++)
            {
                if (i== team)
                {
                    if (records.ElementAt(i).Exist == true)
                    {
                        break;
                    }
                    else
                    {
                        team++;
                        if (team== AmountPlayer)
                        {
                            for (int j = 0; j < records.Count; j++)
                            {
                                if (records.ElementAt(j).Exist == true)
                                {
                                    team = j;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            //show on game controller screen
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    teamCS.BackColor = Color.LightPink;
                    teamCS.Enabled = true;
                    teamCS.flp_Answer.Visible = true;
                    teamCS.gb_team.Visible = true;
                    teamCS.chk_QuestionPM.Visible = true;
                    teamCS.chk_Support.Visible = false;
                    if (records.ElementAt(team).Defy ==true)
                    {
                        teamCS.chk_defy.Visible = true;
                    }
                    else
                    {
                        teamCS.chk_defy.Visible = false;
                    }
                    
                }else
	            {
                    teamCS.gb_team.Visible = false;
	            }
            }
            
            //show player lane on audience screen
            foreach (Player_Lane1 item in audience.pnl_Lane.Controls)
            {
                if (Convert.ToInt32(item.lbl_SequencePlayer.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    item.HighLight(true);
                    if (records.ElementAt(team).NumPass == AmountSteptoPass && records.ElementAt(team).NumFail == AmountSteptofail && records.ElementAt(team).PhaseIndex == 0)
                    {
                        item.pb_Team.Location = new Point(item.pb_Team.Location.X + 0, item.pb_Team.Location.Y - 55);                        
                    }
                }
            }
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                if (Convert.ToInt32(teamAdienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                {
                    teamAdienceScreen.HighLight(true);  
                }
                else
                {
                    if (teamAdienceScreen.pb_Heart1.Visible == false && teamAdienceScreen.pb_Heart2.Visible == false && teamAdienceScreen.pb_Heart3.Visible == false)
                    {
                        teamAdienceScreen.lbl_Hint.Visible=true;
                    }
                }
            }
            
            //move to next step
            step++;
        }
        //--3 Show question Answer
        public void ShowQuestion()
        {
            int IDPhase = 0;
            int countTeamChallenged = 0;
            //count team is challenged
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (teamCS.chk_Challenged.Checked == true)
                {
                    countTeamChallenged++;
                }
            }
            //show question have challenge choice
            if (CheckChallengeChoice == true)
            {
                if (countTeamChallenged == 0)
                {
                    MessageBox.Show("Please selected challenge team!");
                }
                else
                {
                    foreach (Team teamCS in flp_Team.Controls)
                    {
                        if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                        {
                            teamCS.gb_team.Visible = false;
                            IDPhase = records.ElementAt(team).IDPhase;
                            //show question by id phase
                            ShowQuestionByIDPhase(IDPhase);
                        }
                    }
                }
            }
            else
            {//show question don't have challenge choice
                foreach (Team teamCS in flp_Team.Controls)
                {
                    if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                    {
                        if (records.ElementAt(team).Support == false)
                        {
                            teamCS.gb_team.Visible = false;
                        }
                        else
                        {
                            teamCS.chk_Support.Visible = true;
                        }
                        teamCS.chk_QuestionPM.Visible = false;
                        teamCS.chk_defy.Visible = false;
                        IDPhase = records.ElementAt(team).IDPhase;
                        //show question by id phase
                        ShowQuestionByIDPhase(IDPhase);
                    }
                }
            } 
            //show question by id phase
           
        }
        //--4 Show Correct Answer
        public void EnterAnswer()
        {
            if (CheckChallengeChoice == false)
            {
                EnterAnswerNotChallenge();
            }
            else
            {
                EnterAnswerChallenge();
            }
            step++;
        }
        //--5 show correct answer
        int CorrectAnswer ;
        int PlayerCheck ;
        public void ShowCorrectAnswer()
        {
            //show correct answer with question type: onechoie or multichoice
            if (typequestion =="onechoice" || typequestion == "multichoice")
            {
                foreach (ShowAnswer answer in audience.flp_AnswerQuiz.Controls)
                {
                    if (answer.lbl_Correct.Text.ToLower() == "true")
                    {
                        answer.BackColor = Color.LightGreen;
                        if (typequestion == "onechoice")
                        {
                            CorrectAnswerChallenge = answer.rdb1.Text;
                        }
                        else
                        {
                            CorrectAnswerChallenge += answer.chk1.Text;
                        }
                        CorrectAnswer++;
                    }
                    if (answer.chk1.Checked == true)
                    {
                        if (answer.lbl_Correct.Text.ToLower() == "true")
                        {
                            PlayerCheck++;
                        }
                        else
                        {
                            PlayerCheck--;
                        }
                    }
                    if (answer.rdb1.Checked == true)
                    {
                        if (answer.lbl_Correct.Text.ToLower() == "true")
                        {
                            PlayerCheck++;
                        }
                    }
                }
            }
            else
            {
                TextBox txt_Answer = new TextBox();
                txt_Answer.Text = CorrectShortAnswer;
                CorrectAnswerChallenge = CorrectShortAnswer;
                txt_Answer.Font = new Font("Verdana",32.0f,FontStyle.Bold);
                txt_Answer.BackColor = Color.LightGreen;
                txt_Answer.ReadOnly = true;
                audience.flp_AnswerQuiz.Controls.Add(txt_Answer);
            }

            //check player correct or incorrect
            if (typequestion == "multichoice")
            {
                foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                {
                    if (playerAnswer.lbl_TeamAnswer.Text.Trim().Replace(" ","") == CorrectAnswerChallenge)
                    {
                        playerAnswer.lbl_Check.Text = "true";
                    }
                    else
                    {
                        playerAnswer.lbl_Check.Text = "false";
                    }
                }
            }
            else
            {
                foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                {
                    if (playerAnswer.lbl_TeamAnswer.Text == CorrectAnswerChallenge)
                    {
                        playerAnswer.lbl_Check.Text = "true";
                    }
                    else
                    {
                        playerAnswer.lbl_Check.Text = "false";
                    }
                }
            }
            step++;
        }
        //--7 Update point for player
        public void CalculteScore()
        {
            if (CheckChallengeChoice == true)
            {
                CalculateScoreChallenge();
            }
            else
            {
                CalculateScoreNotChallenge();
            }
            int NumPlayerEndGame = 0;
            //check number of player end game
            foreach (Record record in records)
            {
                if (record.Exist == false)
                {
                    NumPlayerEndGame++;
                }
            }
            //End Game
            if (NumPlayerEndGame == AmountPlayer)
            {
                MessageBox.Show("End Game!");
                this.Close();
            }
            else
            {
                //move to another player
                CorrectAnswer = 0;
                PlayerCheck = 0;
                if (GameOver == true)
                {
                    if (records.ElementAt(team).SequecePlayer == LastPlayerRun())
                    {
                        pb_EndGame.Visible = true;
                        pb_Play.Enabled = false;
                        //update status contest id this contest have run
                        Contest.EndContest = 1;
                        ContestBL.EditStatusContestbyID(Contest);
                    }
                }
                team++;
                step = 1;
            }
        }
        #endregion
        ////method
        /////update score, position, record after player have correct answer in phase
        public void PassQuestionInPhase(int score)
        {
            records.ElementAt(team).NumPass -= 1;
            records.ElementAt(team).TotalPass++;
            records.ElementAt(team).TeamScore += score;
            MoveNextPhaseHaveChallenge();
            UpdateScreenAfterChallenge();
        }
        /////update score, position, record after player have incorrect answer in phase
        public void FailQuestionInPhase(int score)
        {
            //minus life if team fail in question
            records.ElementAt(team).NumFail -= 1;
            records.ElementAt(team).TeamScore -= score;
            //MoveNextPhaseHaveChallenge();
            UpdateScreenAfterChallenge();
        }
        ////Pass question PM
        public void PassQuestionPM(int score)
        {
            records.ElementAt(team).TeamScore += score;
            UpdateScreenAfterChallenge();
        }
        //// Fail quesion pm
        public void FailQuestionPM(int score)
        {
            records.ElementAt(team).TeamScore -= score;
            UpdateScreenAfterChallenge();
        }
        //show question by id question
        public void ShowQuestionByIDPhase(int id)
        {
            //declare
            List<Phase> ListPhase;
            List<Question> ListQuestion;
            List<Answer> ListAnswer;
            int idquestion = 0;
            int a = 65;
            Phase.IDPhase = id;

            ListPhase = PhaseQuestionBl.getquestionRunGame(Phase);
            if (ListPhase != null)
            {
                try
                {
                    idquestion = ListPhase.ElementAt(0).IDQuestion;

                    //show question in phase
                    Question.IDQuestion = idquestion;
                    ListQuestion = QuestionBL.GetQuestionByID(Question);
                    ListAnswer = QuestionBL.GetAnswerByQuestionID(Question);
                    //////show question on audience screen
                    if (ListQuestion != null)
                    {
                        /////display question on audience screen
                        audience.richTextBox1.Text = ListQuestion.ElementAt(0).NameQuestion;
                        audience.lbl_Phase.Text = NameofPhase(records.ElementAt(team).IDPhase) + "/" +(ListPhase.Count-1) +" Question";
                        audience.lbl_Point.Text = "Point: "+ BonusScoreofPhase(records.ElementAt(team).IDPhase).ToString();
                        typequestion = ListQuestion.ElementAt(0).TypeQuestion.ToLower();

                        /////question is onechoice type
                        if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                ShowAnswer ShowAnswer = new ShowAnswer();
                                ShowAnswer.Size = new System.Drawing.Size(audience.flp_AnswerQuiz.Width / 2 - 10, audience.flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)ListAnswer.Count / 2)) - 10);
                                ShowAnswer.rdb1.Visible = true;
                                ShowAnswer.rdb1.Text = Convert.ToChar(a + h).ToString();
                                ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                audience.flp_AnswerQuiz.Controls.Add(ShowAnswer);
                            }
                        }
                        else
                        {   //question is multichoice type
                            if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "multichoice")
                            {
                                for (int h = 0; h < ListAnswer.Count; h++)
                                {
                                    ShowAnswer ShowAnswer = new ShowAnswer();
                                    ShowAnswer.Size = new System.Drawing.Size(audience.flp_AnswerQuiz.Width / (2) - 10, audience.flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)ListAnswer.Count / 2)) - 10);
                                    ShowAnswer.chk1.Visible = true;
                                    ShowAnswer.chk1.Text = Convert.ToChar(a + h).ToString();
                                    ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                    ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                    audience.flp_AnswerQuiz.Controls.Add(ShowAnswer);
                                }
                            }
                            else
                            {
                                //question is short answer type
                                audience.flp_AnswerQuiz.BackColor = Color.Transparent;
                                CorrectShortAnswer = ListAnswer.ElementAt(0).ContentAnswer;
                            }
                        }
                        //update 
                        Phase.IDQuestion = idquestion;
                        //Check question have been showed
                        PhaseQuestionBl.EditQuestionStatus(Phase);
                        step++;
                    }

                    if (CheckChallengeChoice == true)
                    {
                        TableAnswerMultiTeam(ListQuestion, ListAnswer);
                    }
                    else
                    {
                        TableAnswerOneTeam(ListQuestion, ListAnswer);
                    }
                    
                    ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
                    //show countdown time on game controller screen
                    lbl_Time.Text = ListPhase.ElementAt(0).TimePhase.ToString();
                    timer1.Interval = 1000;
                    timer1.Start();
                    //show time conut down on audience screen
                    audience.lbl_TimeShowQuestion.Text = ListPhase.ElementAt(0).TimePhase.ToString();
                    audience.timer1.Interval = 1000;
                    audience.timer1.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Run Out of Question");
                }
            } 
        }
        //show table answer on controller screen
        void TableAnswerOneTeam(List<Question> ListQuestion, List<Answer>ListAnswer)
        {
            int a = 65;
            
            /////show answer one on control screen
            foreach (Team teamCS in flp_Team.Controls)
            {
                //show table answer
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    //dislay team will answer question
                    PlayerAnswer PlayerAnswer = new PlayerAnswer();
                    PlayerAnswer.pb_TeamShirt.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(teamCS.lbl_IDPlayer.Text)));
                    PlayerAnswer.lbl_IDPlayer.Text = teamCS.lbl_IDPlayer.Text;
                    audience.flp_PlayerAnswers.Controls.Add(PlayerAnswer);

                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = Convert.ToChar(a + h).ToString();
                            radioButton.AutoSize = true;
                            teamCS.flp_Answer.Controls.Add(radioButton);
                        }
                    }
                    else
                    {
                        if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "multichoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                CheckBox checkBox = new CheckBox();
                                checkBox.Text = Convert.ToChar(a + h).ToString();
                                checkBox.AutoSize = true;
                                teamCS.flp_Answer.Controls.Add(checkBox);
                            }
                        }
                        else
                        {
                            TextBox textBox = new TextBox();
                            textBox.AutoSize = false;
                            textBox.Anchor = AnchorStyles.Top;
                            textBox.Anchor = AnchorStyles.Left;
                            textBox.Location = new Point(textBox.Location.X + 0, textBox.Location.Y +0);
                            textBox.Size = new System.Drawing.Size(teamCS.flp_Answer.Width-7, teamCS.flp_Answer.Height-7);
                            textBox.Font = new Font("Verdana", 14.0f, FontStyle.Bold);
                            teamCS.flp_Answer.Controls.Add(textBox);
                        }
                    }
                }
            }
        }
        //show table answer on controller screen while the challenge
        void TableAnswerMultiTeam(List<Question> ListQuestion, List<Answer> ListAnswer)
        {
            int a = 65;
            /////show answer one on control screen
            foreach (Team teamCS in flp_Team.Controls)
            {
                teamCS.chk_Challenged.Visible = false;
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked==true)
                {
                    PlayerAnswer PlayerAnswer = new PlayerAnswer();
                    PlayerAnswer.pb_TeamShirt.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(teamCS.lbl_IDPlayer.Text)));
                    PlayerAnswer.lbl_IDPlayer.Text = teamCS.lbl_IDPlayer.Text;
                    audience.flp_PlayerAnswers.Controls.Add(PlayerAnswer);
                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.Text = Convert.ToChar(a + h).ToString();
                            radioButton.AutoSize = true;
                            teamCS.flp_Answer.Controls.Add(radioButton);
                            //panelAnswer.Controls.Add(radioButton);
                        }
                    }
                    else
                    {
                        if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "multichoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                CheckBox checkBox = new CheckBox();
                                checkBox.Text = Convert.ToChar(a + h).ToString();
                                checkBox.AutoSize = true;
                                teamCS.flp_Answer.Controls.Add(checkBox);
                            }
                        }
                        else
                        {
                            TextBox textBox = new TextBox();
                            textBox.AutoSize = false;
                            textBox.Anchor = AnchorStyles.Top;
                            textBox.Anchor = AnchorStyles.Left;
                            textBox.Location = new Point(textBox.Location.X + 0, textBox.Location.Y + 0);
                            textBox.Size = new System.Drawing.Size(teamCS.flp_Answer.Width - 7, teamCS.flp_Answer.Height - 7);
                            textBox.Font = new Font("Verdana", 14.0f, FontStyle.Bold);
                            teamCS.flp_Answer.Controls.Add(textBox);
                        }
                    }
                }
            }
        }
        //Input answer for not challenge choice
        public void EnterAnswerNotChallenge()
        {
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    if (typequestion == "onechoice")
                    {
                        foreach (ShowAnswer showAnswer in audience.flp_AnswerQuiz.Controls)
                        {
                            foreach (RadioButton oneChoice in teamCS.flp_Answer.Controls)
                            {
                                if (oneChoice.Checked == true)
                                {
                                    if (oneChoice.Text == showAnswer.rdb1.Text)
                                    {
                                        showAnswer.rdb1.Checked = true;
                                        showAnswer.BackColor = Color.FromArgb(colorplayer(records.ElementAt(team).IDPlayer));
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (typequestion == "multichoice")
                        {
                            //string[] multianswer;
                            foreach (ShowAnswer showAnswer in audience.flp_AnswerQuiz.Controls)
                            {
                                foreach (CheckBox multiChoice in teamCS.flp_Answer.Controls)
                                {
                                    if (multiChoice.Checked == true)
                                    {
                                        if (multiChoice.Text == showAnswer.chk1.Text)
                                        {
                                            showAnswer.chk1.Checked = true;
                                            showAnswer.BackColor = Color.FromArgb(colorplayer(records.ElementAt(team).IDPlayer));
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (TextBox shortanswer in teamCS.flp_Answer.Controls)
                            {
                                shortanswer.ReadOnly = true;
                                shortanswer.Font = new Font("Verdana", 32.0f, FontStyle.Bold);
                                shortanswer.AutoSize = true;
                                audience.flp_AnswerQuiz.Controls.Add(shortanswer);
                                PlayerAnswerShortQuestion = shortanswer.Text;
                            }
                        }
                    }
                    teamCS.gb_team.Visible = false;
                }
                else
                {
                    teamCS.gb_team.Visible = false;
                }
            }
        }
        //Input answer for chanllenge choice
        public void EnterAnswerChallenge()
        {
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked==true)
                {
                    if (typequestion == "onechoice")
                    {
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            //check team on controller screen and TeamAnswer on audience screen is equal
                            if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                            {
                                foreach (RadioButton oneChoice in teamCS.flp_Answer.Controls)
                                {
                                    if (oneChoice.Checked == true)
                                    {
                                        playerAnswer.lbl_TeamAnswer.Text = oneChoice.Text;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (typequestion == "multichoice")
                        {
                            foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                            {
                                //check team on controller screen and TeamAnswer on audience screen is equal
                                if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                                {
                                    foreach (CheckBox multiChoice in teamCS.flp_Answer.Controls)
                                    {
                                        if (multiChoice.Checked == true)
                                        {
                                            playerAnswer.lbl_TeamAnswer.Text += multiChoice.Text + " ";
                                        }
                                    }
                                }
                                
                            }
                        }
                        else
                        {
                            foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                            {
                                //check team on controller screen and TeamAnswer on audience screen is equal
                                if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                                {
                                    foreach (TextBox shortanswer in teamCS.flp_Answer.Controls)
                                    {
                                        playerAnswer.lbl_TeamAnswer.Text = shortanswer.Text;
                                        //PlayerAnswerShortQuestion = shortanswer.txt_ShortAnswer.Text;
                                    }
                                }
                            }
                        }
                    }
                    teamCS.gb_team.Visible = false;
                }
                else
                {
                    teamCS.gb_team.Visible = false;
                }
            }
        }
        //Update score, position, record after player have correct answer in phase have challenge
        public void UpdatePlayerChallengeInPhase()
        {
            int countTeamTrue = 0;
            int countTeamFalse = 0;
            int BonusScoreInPhase = BonusScoreofPhase(records.ElementAt(team).IDPhase);
            int MinusScoreInPhase = MinusScoreofPhase(records.ElementAt(team).IDPhase);
            bool ownerChallenge = false;

            foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
            {
                if (playerAnswer.lbl_Check.Text == "true")
                {
                    if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                    {
                        ownerChallenge = true;
                    }
                    countTeamTrue++;
                }
                else
                {
                    if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                    {
                        ownerChallenge = false;
                    }
                    countTeamFalse++;
                }
            }
            //all team is correct
            if (countTeamTrue == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).NumPass -= 1;
                records.ElementAt(team).TotalPass++;
                records.ElementAt(team).TeamScore += BonusScoreInPhase;
                MoveNextPhaseHaveChallenge();
            }
            //all team is incorrect
            if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).NumFail -= 1;
                records.ElementAt(team).TeamScore -= MinusScoreInPhase;
                if (records.ElementAt(team).NumFail == 0)
                {
                    records.ElementAt(team).Exist = false;
                }
            }
            //
            if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
            {
                //owner challenge win
                if (ownerChallenge == true)
                {
                    records.ElementAt(team).TeamScore += BonusScoreInPhase;
                    records.ElementAt(team).NumPass -= 1;
                    records.ElementAt(team).TotalPass++;
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore -= ChallengeScore;
                                    records.ElementAt(team).TeamScore += ChallengeScore;
                                }
                            }

                        }
                    }
                    MoveNextPhaseHaveChallenge();
                }
                else
                {//Owner challenge lose
                    records.ElementAt(team).TeamScore -= MinusScoreInPhase;
                    records.ElementAt(team).NumFail -= 1;
                    if (records.ElementAt(team).NumFail == 0)
                    {
                        records.ElementAt(team).Exist = false;
                    }
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore += ChallengeScore;
                                    records.ElementAt(team).TeamScore -= ChallengeScore;
                                    
                                }
                            }

                        }
                    }
                }
            }

        }
        //Update score, position, record after player have correct answer in PM question have challenge
        public void UpdatePlayerChallengeInPM()
        {
            int countTeamTrue = 0;
            int countTeamFalse = 0;
            int BonusScoreQuestionPM = BonusScoreofPhase(IDPhasePM);
            int MinusScoreQuestionPM = MinusScoreofPhase(IDPhasePM);
            bool ownerChallenge = false;
            foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
            {
                if (playerAnswer.lbl_Check.Text == "true")
                {
                    if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                    {
                        ownerChallenge = true;
                    }
                    countTeamTrue++;
                }
                else
                {
                    if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                    {
                        ownerChallenge = false;
                    }
                    countTeamFalse++;
                }
            }
            //all team is correct
            if (countTeamTrue == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).TeamScore += BonusScoreQuestionPM;
                //update screen
            }
            //all team is incorrect
            if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).TeamScore -= MinusScoreQuestionPM;
                //update screen
            }
            //
            if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
            {
                //owner challenge win
                if (ownerChallenge == true)
                {
                    records.ElementAt(team).TeamScore += BonusScoreQuestionPM;
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore -= ChallengeScore;
                                    records.ElementAt(team).TeamScore += ChallengeScore;
                                }
                            }

                        }
                    }
                    //update screen
                }
                else
                {//Owner challenge lose
                    records.ElementAt(team).TeamScore -= MinusScoreQuestionPM;
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore += ChallengeScore;
                                    records.ElementAt(team).TeamScore -= ChallengeScore;
                                }
                            }

                        }
                    }
                }
            }
        }
        //Calculate score and update player information for not challengece choice
        public void CalculateScoreNotChallenge()
        {
            //Update score, position between question into phase and question PM
            if (CheckQuestionPM == false)
            {
                int BonusScore = BonusScoreofPhase(records.ElementAt(team).IDPhase);
                int MinusScore = MinusScoreofPhase(records.ElementAt(team).IDPhase);
                //player answer with question onechoice or multichoice
                if (typequestion == "onechoice" || typequestion == "multichoice")
                {
                    //player answer correct
                    if (PlayerCheck == CorrectAnswer)
                    {
                        PassQuestionInPhase(BonusScore);
                    }
                    else
                    {
                        FailQuestionInPhase(MinusScore);
                    }
                }
                else
                {//player answer with question shortanswer
                    if (PlayerAnswerShortQuestion.Equals(CorrectShortAnswer) == true)
                    {
                        PassQuestionInPhase(BonusScore);
                    }
                    else
                    {
                        FailQuestionInPhase(MinusScore);
                    }
                }
            }
            else
            {
                int BonusScoreQuestionPM = BonusScoreofPhase(IDPhasePM);
                int MinusScoreQuestionPM = MinusScoreofPhase(IDPhasePM);
                //player answer with question onechoice or multichoice
                if (typequestion == "onechoice" || typequestion == "multichoice")
                {
                    //player answer correct
                    if (PlayerCheck == CorrectAnswer)
                    {
                        PassQuestionPM(BonusScoreQuestionPM);
                    }
                    else
                    {
                        FailQuestionPM(MinusScoreQuestionPM);
                    }
                }
                else
                {//player answer with question shortanswer
                    if (PlayerAnswerShortQuestion.Equals(CorrectShortAnswer) == true)
                    {
                        PassQuestionPM(BonusScoreQuestionPM);
                    }
                    else
                    {
                        FailQuestionPM(MinusScoreQuestionPM);
                    }
                }
            }
        }
        //Calculate score and update player information for challengece choice
        public void CalculateScoreChallenge()
        {
            //Update score, position between question into phase and question PM
            if (CheckQuestionPM == true)
            {
                UpdatePlayerChallengeInPM();
                UpdateScreenAfterChallenge();
            }
            else
            {
                UpdatePlayerChallengeInPhase();
                UpdateScreenAfterChallenge();
            }
        }
        //move to next phase when have challenge
        public void MoveNextPhaseHaveChallenge()
        {
            //Update team location in lane on audience screen
            foreach (Player_Lane1 PlayerLane in audience.pnl_Lane.Controls)
            {
                if (Convert.ToInt32(PlayerLane.lbl_SequencePlayer.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    if (records.ElementAt(team).TotalPass == AmountPhase * AmountSteptoPass)
                    {//move out lane when done all question in all phase
                        //get  bonus when team is the first champion
                        if (Done == true)
                        {
                            records.ElementAt(team).TeamScore += Bonus;
                            Done = false;
                            GameOver = true;
                            //show  icon to end when team have finished
                            //pb_EndGame.Visible = true;
                        }
                        
                        PlayerLane.pb_Team.Location = new Point(PlayerLane.pb_Team.Location.X + 0, PlayerLane.pb_Team.Location.Y - PlayerLane.Height);

                        PictureBox pBoxTeamShirt = new PictureBox();
                        pBoxTeamShirt.Image = Properties.Resources.ao_nho;
                        pBoxTeamShirt.BackColor = Color.FromArgb(colorplayer(records.ElementAt(team).IDPlayer));

                        // Properties
                        pBoxTeamShirt.Width = 39;
                        pBoxTeamShirt.Height = 45;
                        pBoxTeamShirt.Anchor = AnchorStyles.None;
                        pBoxTeamShirt.Location = new Point(pBoxTeamShirt.Location.X + PlayerLane.Location.X + PlayerLane.pb_Team.Location.X, pBoxTeamShirt.Location.Y + 5);

                        audience.pnl_FinishLane.Controls.Add(pBoxTeamShirt);
                      
                        
                    }
                    else
                    {//move after done each question
                        PlayerLane.pb_Team.Location = new Point(PlayerLane.pb_Team.Location.X + 0, PlayerLane.pb_Team.Location.Y - 50);
                    }
                }
            }
            //move to next phase
            if (records.ElementAt(team).NumPass == 0)
            {
                //get phase
                Phase.IDContest = iDContest;
                List<Phase> ListPhase;
                ListPhase = PhaseBL.GetPhaseNormal(Phase);
                records.ElementAt(team).PhaseIndex += 1;
                records.ElementAt(team).NumFail = AmountSteptofail;
                records.ElementAt(team).NumPass = AmountSteptoPass;
                if (records.ElementAt(team).PhaseIndex < AmountPhase)
                {
                    records.ElementAt(team).IDPhase = ListPhase.ElementAt(records.ElementAt(team).PhaseIndex).IDPhase;
                }
                else
                {
                    //if phase out of range
                }
            }
        }
        ////Update Gui after have challenge
        public void UpdateScreenAfterChallenge()
        {
            int i = 0;
            //show all team on controller screen
                foreach (Team teamControllerScreen in flp_Team.Controls)
                {
                    teamControllerScreen.lbl_TeamName.Text = nameplayer(records.ElementAt(i).IDPlayer);
                    teamControllerScreen.lbl_TeamScore.Text = records.ElementAt(i).TeamScore.ToString();
                    teamControllerScreen.lbl_CurrentPhase.Text = NameofPhase(records.ElementAt(i).IDPhase);
                    //teamControllerScreen.chk_Challenged.Checked = false;
                    teamControllerScreen.gb_team.Visible = false;
                    teamControllerScreen.chk_QuestionPM.Checked = false;
                    teamControllerScreen.chk_defy.Checked = false;
                    teamControllerScreen.chk_Support.Checked = false;
                    teamControllerScreen.flp_Answer.Controls.Clear();
                    teamControllerScreen.flp_Answer.Visible = false;
                    i++;
                }
            //show lanes in audience screen
            foreach (Player_Lane1 playerLane in audience.pnl_Lane.Controls)
            {
                playerLane.pb_Team.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(playerLane.lbl_IDPlayer.Text)));
            }

            int j = 0;
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                teamAdienceScreen.lbl_TeamName.Text = nameplayer(records.ElementAt(j).IDPlayer);
                teamAdienceScreen.lbl_TeamScore.Text = records.ElementAt(j).TeamScore.ToString();
                //check support choice exist to show
                if (records.ElementAt(j).Support == true)
                {
                    //keep image
                }
                else
                {
                    teamAdienceScreen.pb_SupportChoice.Image = Properties.Resources.het_y_kien;
                }
                //check challenge choice exist to show
                if (records.ElementAt(j).Defy == true)
                {
                    //keep image
                }
                else
                {
                    teamAdienceScreen.pb_ChallengeChoice.Image = Properties.Resources.het_thach_dau;
                }
                //show heart in player
                if (records.ElementAt(j).NumFail == 3)
                {
                    teamAdienceScreen.pb_Heart1.Show();
                    teamAdienceScreen.pb_Heart2.Show();
                    teamAdienceScreen.pb_Heart3.Show();
                }
                else
                {
                    if (records.ElementAt(j).NumFail == 2)
                    {
                        teamAdienceScreen.pb_Heart1.Show();
                        teamAdienceScreen.pb_Heart2.Show();
                        teamAdienceScreen.pb_Heart3.Hide();
                    }
                    else
                    {
                        if (records.ElementAt(j).NumFail == 1)
                        {
                            teamAdienceScreen.pb_Heart1.Show();
                            teamAdienceScreen.pb_Heart2.Hide();
                            teamAdienceScreen.pb_Heart3.Hide();
                        }
                        else
                        {
                            teamAdienceScreen.pb_Heart1.Hide();
                            teamAdienceScreen.pb_Heart2.Hide();
                            teamAdienceScreen.pb_Heart3.Hide();
                        }
                    }
                }
                j++;
            }
        }
        //show teams are challenged
        public void ShowTeamsChallenged()
        {
            //foreach (Team item in flp_Team.Controls)
           // {
               // if (Convert.ToInt32(item.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                //{
                    for (int i = 0; i < records.Count; i++)
                    {
                        if (records.ElementAt(i).Exist == true)
                        {
                            foreach (Team teamCS in flp_Team.Controls)
                            {
                                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(i).IDPlayer) && i!=team)
                                {
                                    teamCS.chk_Challenged.Visible = true;
                                }
                            }
                        }
                    }
                //}
            //}
            
        }

        
        #region Property in game
        //Get bonus score of phase by id phase
        public int BonusScoreofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).ScorePhase;
        }
        //Get minus score of phase by id phase
        public int MinusScoreofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).MinusPhase;
        }
        //Get name phase by id phase
        public string NameofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).NamePhase;
        }
        //Get time of phase
        public int TimeofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).TimePhase;
        }
        //Get sequence of player by id player
        public int sequenceplayer(int idplayer)
        {
            Player.IDPlayer = idplayer;
            List<Player> Listplayer;
            Listplayer = PlayerBL.GetPlayerByIDplayer(Player);
            return Listplayer.ElementAt(0).Sequence;   
        }
        //Get name of player by id player
        public string nameplayer(int idplayer)
        {
            Player.IDPlayer = idplayer;
            List<Player> Listplayer;
            Listplayer = PlayerBL.GetPlayerByIDplayer(Player);
            return Listplayer.ElementAt(0).PlayerName;
        }
        //Get color of player by id player
        public int colorplayer(int idplayer)
        {
            Player.IDPlayer = idplayer;
            List<Player> Listplayer;
            Listplayer = PlayerBL.GetPlayerByIDplayer(Player);
            return Convert.ToInt32(Listplayer.ElementAt(0).Color);
        }
        #endregion
        //update log
        public void UpdateLog(int idPla, int idpha,int score, int NumTrue, int NumFalse, int check)
        {
            Log.PlayerID = idPla;
            Log.PhaseID = idpha;
            Log.PlayerScore = score;
            Log.CurrentNumofTrue = NumTrue;
            Log.CurrentNumofFalse = NumFalse;
            Log.Check = check;
            logBL.EditLogbyIDPlayer(Log);
        }
        //each step to controller control game
        public void StartGame()
        {
            //Rungame.IdContest = iDContest;
            audience.IdContest = iDContest;
            if (step ==1)
            {
                lblHint.Text = guideline[1].ToString();
                loadMap();
            }
            else if (step == 2)
            {
                lblHint.Text = guideline[2].ToString();
                GoPlayer();
            }
            else if (step ==3)
            {
                lblHint.Text = guideline[3].ToString();
                audience.tabControl1.SelectedTab = audience.tab_ShowQuestion;
                ShowQuestion();
            }
            else if (step ==4)
            {
                lblHint.Text = guideline[4].ToString();
                EnterAnswer();
            }
            else if (step ==5)
            {
                lblHint.Text = guideline[5].ToString();
                ShowCorrectAnswer();
            }
            else if (step == 6)
            {
                step++;
                UpdateScreenAfterChallenge();
                audience.tabControl1.SelectedTab = audience.tab_Map;
                lblHint.Text = guideline[6].ToString();
            }
            else if (step ==7)
            {
                lblHint.Text = guideline[0].ToString();
                audience.tabControl1.SelectedTab = audience.tab_Map;
                CalculteScore();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = (int.Parse(lbl_Time.Text) - 1).ToString(); //lowering the value - explained above
            if (int.Parse(lbl_Time.Text) == 0)  //if the countdown reaches '0', we stop it
                timer1.Stop();
        }
        //exit game
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit Contest?", "Close Contest", MessageBoxButtons.OKCancel);
            if (dr==DialogResult.OK)
            {
                this.Close();
                audience.Close();
            } 
        }
        //Click play to execute game
        private void pb_Play_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        //End game and report Result
        public void EndGame()
        {
            //Sort player assending in list player
            int length = records.Count;
            Record temp = records[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (records.ElementAt(i).TeamScore < records.ElementAt(j).TeamScore)
                    {
                        temp = records[i];

                        records[i] = records[j];

                        records[j] = temp;
                    }
                }
            }
            //Declare data
            string[] Rank = new string[] {"st","nd","rd","th","th"};
            int width = audience.flp_TeamEndGame.Width/AmountPlayer;
            int height = audience.flp_TeamEndGame.Height;
            //Show player
            for (int i = 0; i < records.Count; i++)
            {
                TeamEndGame teamEndGame = new TeamEndGame();
                if (i==0)
                {
                    teamEndGame.lbl_Winner.Visible = true;
                }
                teamEndGame.lbl_Position.Text = (i + 1).ToString()+ Rank[i].ToString();
                teamEndGame.lbl_Score.Text = records.ElementAt(i).TeamScore.ToString();
                teamEndGame.lbl_Name.Text = nameplayer(records.ElementAt(i).IDPlayer);
                teamEndGame.pb_TeamShirt.BackColor = Color.FromArgb(colorplayer(records.ElementAt(i).IDPlayer));
                teamEndGame.Size = new System.Drawing.Size(width -10, height);
                audience.flp_TeamEndGame.Controls.Add(teamEndGame);
            }
        }

        private void pb_EndGame_Click(object sender, EventArgs e)
        {
            audience.tabControl1.SelectedTab = audience.tab_EndGame;
            EndGame();
        }

        public int LastPlayerRun()
        {
            int check = 0;
            for (int i = 0; i < records.Count; i++)
            {
                if (records.ElementAt(i).Exist == true)
                {
                    check = i;
                }
            }
            return check;
        }
    }
}

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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CapDemo.GUI.User_Controls;
using System.Media;

namespace CapDemo
{
    public partial class Open_Game : Form
    {
        public Open_Game()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        //SoundPlayer sound;
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
        RecordBL RecordBL = new RecordBL();

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
        bool Run;

        int idPlayer;
        int time;

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
        bool GameOverAll = false;
        bool SoundWelcome = true;
        //bool ExistPM;
        int IDPhasePM;

        //Score
        int _BonusPhase;
        int _MinusPhase;
        //Correct answer and Player answer
        int CorrectAnswer;
        int PlayerCheck;
        //Note to click play
        string[] guideline = new string[] 
        {"Bấm để tải sơ đồ cuộc thi",
        "Bấm để đến lượt đội thi đấu tiếp theo",
        "Bấm để hiển thị câu hỏi và các câu trả lời",
        "Bấm để hiển thị đáp án của đội thi đấu chọn",
        "Bấm để hiển thị đáp án đúng nhất",
        "Bấm để hiển thị sơ đồ các đội",
        "Bấm để cập nhật điểm cho đội thi đấu"};
        #endregion      

        //Get contest content
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
                    Run = ListContest.ElementAt(i).Run;
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

            Record Restore = new Record();
            Restore.AmountTeam = AmountPlayer;

            if (Run ==  false)
            {
                if (ListPlayer != null)
                {
                    for (int i = 0; i < ListPlayer.Count; i++)
                    {
                        if (ListPlayer.ElementAt(i) != null)
                        {
                            Team teamCS = new Team();
                            teamtTag++;
                            teamCS.Tag = teamtTag;
                            teamCS.IdPlayerUC = teamtTag;
                            //subcribe event
                            teamCS.checkSupport += team_checkSupport;
                            teamCS.checkQuestionPM += team_checkQuestionPM;
                            teamCS.checkChallenge += team_checkChallenge;
                            teamCS.ChoiceChallengedTeam += team_ChoiceChallengedTeam;
                            teamCS.checkCorrect += team_checkCorrect;
                            //properties
                            teamCS.BackColor = Color.FromArgb(colorplayer(ListPlayer.ElementAt(i).IDPlayer));
                            teamCS.lbl_TeamName.Text = ListPlayer.ElementAt(i).PlayerName;
                            teamCS.lbl_TeamScore.Text = ListPlayer.ElementAt(i).PlayerScore.ToString();
                            teamCS.lbl_CurrentPhase.Text = ListPhase[0].NamePhase;
                            teamCS.lbl_Sequence.Text = ListPlayer.ElementAt(i).Sequence.ToString();
                            teamCS.lbl_IDPlayer.Text = ListPlayer.ElementAt(i).IDPlayer.ToString();
                            teamCS.gb_team.Visible = false;
                            idPlayer = ListPlayer.ElementAt(i).IDPlayer;

                            if (AmountSteptofail == 0)
                            {
                                Record r = new Record(idPlayer, ListPhase[0].IDPhase, iDContest, AmountSteptoPass, AmountSteptofail, true, true, true, 0, ListPlayer.ElementAt(i).PlayerScore, 0, i, true, true);
                                records.Add(r);
                                //record
                                Restore.IDContest = iDContest;
                                Restore.IDPlayer = idPlayer;
                                Restore.IDPhase = ListPhase[0].IDPhase;
                                Restore.NumPass = AmountSteptoPass;
                                Restore.NumFail = AmountSteptofail;
                                Restore.Defy_I = 1;
                                Restore.Support_I = 1;
                                Restore.Exist_I = 1;
                                Restore.PhaseIndex = 0;
                                Restore.TeamScore = ListPlayer.ElementAt(i).PlayerScore;
                                Restore.TotalPass = 0;
                                Restore.SequecePlayer = ListPlayer.ElementAt(i).Sequence;
                                Restore.PM_I = 1;
                                Restore.Undie_I = 1;
                                Restore.Turn = i;

                                RecordBL.AddRecord(Restore);
                            }
                            else
                            {
                                Record r = new Record(idPlayer, ListPhase[0].IDPhase, iDContest, AmountSteptoPass, AmountSteptofail, true, true, true, 0, ListPlayer.ElementAt(i).PlayerScore, 0, i, true, false);
                                records.Add(r);

                                //record
                                Restore.IDContest = iDContest;
                                Restore.IDPlayer = idPlayer;
                                Restore.IDPhase = ListPhase[0].IDPhase;
                                Restore.NumPass = AmountSteptoPass;
                                Restore.NumFail = AmountSteptofail;
                                Restore.Defy_I = 1;
                                Restore.Support_I = 1;
                                Restore.Exist_I = 1;
                                Restore.PhaseIndex = 0;
                                Restore.TeamScore = ListPlayer.ElementAt(i).PlayerScore;
                                Restore.TotalPass = 0;
                                Restore.SequecePlayer = ListPlayer.ElementAt(i).Sequence;
                                Restore.PM_I = 1;
                                Restore.Undie_I = 0;
                                Restore.Turn = i;

                                RecordBL.AddRecord(Restore);

                            }

                            flp_Team.Controls.Add(teamCS);
                        }
                    }
                }
            }
            else
            {
                Restore.IDContest = iDContest;
                List<Record> ListRestore;
                ListRestore = RecordBL.GetRecordByIDContest(Restore);

                if (ListPlayer != null)
                {
                    for (int i = 0; i < ListPlayer.Count; i++)
                    {
                        if (ListPlayer.ElementAt(i) != null)
                        {
                            Team teamCS = new Team();
                            teamtTag++;
                            teamCS.Tag = teamtTag;
                            teamCS.IdPlayerUC = teamtTag;
                            //subcribe event
                            teamCS.checkSupport += team_checkSupport;
                            teamCS.checkQuestionPM += team_checkQuestionPM;
                            teamCS.checkChallenge += team_checkChallenge;
                            teamCS.ChoiceChallengedTeam += team_ChoiceChallengedTeam;
                            teamCS.checkCorrect += team_checkCorrect;
                            //properties
                            teamCS.BackColor = Color.FromArgb(colorplayer(ListPlayer.ElementAt(i).IDPlayer));
                            teamCS.lbl_TeamName.Text = ListPlayer.ElementAt(i).PlayerName;
                            //
                            teamCS.lbl_TeamScore.Text = ListRestore[i].TeamScore.ToString();
                            teamCS.lbl_CurrentPhase.Text = NameofPhase(ListRestore[i].IDPhase);
                            teamCS.lbl_Sequence.Text = ListPlayer.ElementAt(i).Sequence.ToString();
                            teamCS.lbl_IDPlayer.Text = ListRestore[i].IDPlayer.ToString();
                            teamCS.gb_team.Visible = false;

                            if (ListRestore[i].PlayerTurn == true)
                            {
                                team = ListRestore[i].Turn;
                            }
                            //idPlayer = ListPlayer.ElementAt(i).IDPlayer;

                            if (AmountSteptofail == 0)
                            {
                                Record r = new Record(ListRestore.ElementAt(i).IDPlayer, ListRestore.ElementAt(i).IDPhase
                                    , ListRestore.ElementAt(i).IDContest, ListRestore.ElementAt(i).NumPass
                                    , ListRestore.ElementAt(i).NumFail, ListRestore.ElementAt(i).Defy, ListRestore.ElementAt(i).Support
                                    , ListRestore.ElementAt(i).Exist, ListRestore.ElementAt(i).PhaseIndex, ListRestore.ElementAt(i).TeamScore
                                    , ListRestore.ElementAt(i).TotalPass, ListRestore.ElementAt(i).SequecePlayer
                                    , ListRestore.ElementAt(i).PM, ListRestore.ElementAt(i).Undie);
                                records.Add(r);
                            }
                            else
                            {
                                Record r = new Record(ListRestore.ElementAt(i).IDPlayer, ListRestore.ElementAt(i).IDPhase
                                    , ListRestore.ElementAt(i).IDContest, ListRestore.ElementAt(i).NumPass
                                    , ListRestore.ElementAt(i).NumFail, ListRestore.ElementAt(i).Defy, ListRestore.ElementAt(i).Support
                                    , ListRestore.ElementAt(i).Exist, ListRestore.ElementAt(i).PhaseIndex, ListRestore.ElementAt(i).TeamScore
                                    , ListRestore.ElementAt(i).TotalPass, ListRestore.ElementAt(i).SequecePlayer
                                    , ListRestore.ElementAt(i).PM, ListRestore.ElementAt(i).Undie);
                                records.Add(r);
                            }

                            flp_Team.Controls.Add(teamCS);
                        }
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
                    DialogResult dr = MessageBox.Show("Are you sure to use Challenged Choice?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        //record
                        Record Restore = new Record();
                        Restore.Defy_I = 0;
                        Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                        Restore.IDContest = iDContest;
                        RecordBL.UpdateDefy(Restore);

                        records.ElementAt(team).Defy = false;
                        //TeamCS.gb_team.Visible = false;
                        TeamCS.chk_defy.Visible = false;
                        CheckChallengeChoice = true;
                        ShowTeamsChallenged();

                        //sound challenged
                        try
                        {
                            axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\CapNhatDiem.wav";
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        catch (Exception)
                        {
                        }

                        foreach (Team_AudienceScreeen TeamAS in audience.flp_Team.Controls)
                        {
                            if (TeamCS.lbl_IDPlayer.Text ==  TeamAS.lbl_ID.Text)
                            {
                                TeamAS.HighLightChallenge(true);
                            }
                        }
                    }
                    else
                    {
                        TeamCS.chk_defy.Checked = false;
                    }
                }
            }
        }
        //check team challenged
        void team_ChoiceChallengedTeam(object sender, EventArgs e)
        {
            int idPlayerUC = (e as MyEventArgs).IDPlayerUC;
            foreach (Team TeamCS in flp_Team.Controls)
            {
                if (TeamCS.IdPlayerUC == idPlayerUC)
                {
                    if (TeamCS.chk_Challenged.Checked == true)
                    {
                        foreach (Team_AudienceScreeen TeamAS in audience.flp_Team.Controls)
                        {
                            if (TeamCS.lbl_IDPlayer.Text == TeamAS.lbl_ID.Text)
                            {
                                //sound challenged
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\CapNhatDiem.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }
                                

                                TeamAS.BackColor = Color.LightCoral;
                                TeamAS.btn_ChallengeChoice.BackColor = Color.LightCoral;
                                TeamAS.btn_SupportChoice.BackColor = Color.LightCoral;
                            }
                        }
                    }
                    else
                    {
                        foreach (Team_AudienceScreeen TeamAS in audience.flp_Team.Controls)
                        {
                            if (TeamCS.lbl_IDPlayer.Text == TeamAS.lbl_ID.Text)
                            {
                                TeamAS.BackColor = Color.Transparent;
                                TeamAS.btn_ChallengeChoice.BackColor = Color.SkyBlue;
                                TeamAS.btn_SupportChoice.BackColor = Color.SkyBlue;
                            }
                        }
                    } 
                }
            }
        }
        //Get eventhadler check question PM
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
                                 if (countTeamChallenged == 0 || countTeamChallenged > NumofChallenge)
                                 {
                                     if (countTeamChallenged == 0)
                                     {
                                         MessageBox.Show("Please selected challenged team!");
                                         TeamCS.chk_QuestionPM.Checked = false;
                                     }
                                     else
                                     {
                                         MessageBox.Show("Maxmimum number of team will be challenged is " + NumofChallenge);
                                         TeamCS.chk_QuestionPM.Checked = false;
                                     }
                                 }
                                 else
                                 {
                                     foreach (Team teamCS in flp_Team.Controls)
                                     {
                                         if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                                         {
                                             
                                             //show question by id phase
                                             if (ShowQuestionByIDPhase(IDPhasePM) == true)
                                             {
                                                 teamCS.gb_team.Visible = false;
///////
                                                 records.ElementAt(team).PM = false;
                                                 //Record
                                                 Record Restore = new Record();
                                                 Restore.PM_I = 0;
                                                 Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                                 Restore.IDContest = iDContest;
                                                 RecordBL.UpdatePM(Restore);

                                                 CheckQuestionPM = true;
                                                 //show audience screen
                                                 lblHint.Text = guideline[3].ToString();
                                                 audience.tbc_ShowGame.SelectedTab = audience.tab_ShowQuestion;
                                                 //sound show question
                                                 try
                                                 {
                                                     axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\HienThiCauHoi.wav";
                                                     axWindowsMediaPlayer1.Ctlcontrols.play();
                                                 }
                                                 catch (Exception)
                                                 {
                                                 }
                                                 
                                                 //axWindowsMediaPlayer1.settings.setMode("Loop", true);
                                                 step++;
                                             }
                                             else
                                             {
                                                 MessageBox.Show("Run out of questions PM. Please choose questions in phase");
                                                 OutOfQuestion();
                                             }
                                             
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
                                         

                                         //show question by id phase
                                         if (ShowQuestionByIDPhase(IDPhasePM) == true)
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
///////
                                             records.ElementAt(team).PM = false;
                                             //Record
                                             Record Restore = new Record();
                                             Restore.PM_I = 0;
                                             Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                             Restore.IDContest = iDContest;
                                             RecordBL.UpdatePM(Restore);

                                             CheckQuestionPM = true;
                                             pb_Play.Enabled = true;
                                             //show audience screen
                                             lblHint.Text = guideline[3].ToString();
                                             audience.tbc_ShowGame.SelectedTab = audience.tab_ShowQuestion;
                                             //sound show question
                                             try
                                             {
                                                 axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\HienThiCauHoi.wav";
                                                 axWindowsMediaPlayer1.Ctlcontrols.play();
                                             }
                                             catch (Exception)
                                             {
                                             }
                                             step++;
                                         }
                                         else
                                         {
                                             MessageBox.Show("Run out of questions PM. Please choose questions in phase");
                                             OutOfQuestion();
                                         }
                                         
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
                    DialogResult dr = MessageBox.Show("Are you sure to use supported choice?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        //record
                        Record Restore = new Record();
                        Restore.Support_I = 0;
                        Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                        Restore.IDContest = iDContest;
                        RecordBL.UpdateSupport(Restore);

                        records.ElementAt(team).Support = false;
                        //hide support choice on controller screen
                        TeamCS.chk_Support.Visible = false;
                        //show time on controller screen
                        lbl_Time.Text = (Convert.ToInt32(lbl_Time.Text)+(TimeSupport)).ToString();
                        timer1.Interval = 1000;
                        timer1.Start();
                        //show time on audience screen
                        audience.lbl_TimeShowQuestion.Text = (Convert.ToInt32(audience.lbl_TimeShowQuestion.Text) + (TimeSupport)).ToString();
                        audience.prgb_Question.Maximum = time + (TimeSupport);
                        audience.timer1.Interval = 1000;
                        audience.timer1.Start();
                        //hint support choice on controller screen after it has been used

                        foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
                        {
                            if (Convert.ToInt32(teamAdienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                            {
                                teamAdienceScreen.btn_SupportChoice.BackgroundImage = Properties.Resources.End_Support;
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
        //Get eventhandler check team always correct
        void team_checkCorrect(object sender, EventArgs e)
        {
            int idPlayerUC = (e as MyEventArgs).IDPlayerUC;
            foreach (Team TeamCS in flp_Team.Controls)
            {
                if (TeamCS.IdPlayerUC == idPlayerUC)
                {
                    DialogResult dr = MessageBox.Show("Are you sure to assign this player is coccrect?", "Game Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (TeamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                            {
                                //sound challenged
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\CapNhatDiem.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                playerAnswer.lbl_TeamAnswer1.Text = CorrectAnswerChallenge;
                                PlayerAnswerShortQuestion = CorrectAnswerChallenge;
                                CorrectAnswer = 0;
                                PlayerCheck = 0;
                                AssignPlayerCorrect();
                                TeamCS.chk_Correct.Visible = false;

                            }
                        }

                        //show answer follow player
                        if (typequestion == "onechoice")
                        {
                            foreach (ShowAnswer showAnswer in audience.flp_AnswerQuiz.Controls)
                            {
                                foreach (RadioButton oneChoice in TeamCS.flp_Answer.Controls)
                                {
                                    if (oneChoice.Checked == true)
                                    {
                                        if (oneChoice.Text == showAnswer.rdb1.Text)
                                        {
                                            showAnswer.BackgroundImage = Properties.Resources.dung_2;
                                        }
                                        else
                                        {
                                            showAnswer.BackgroundImage = Properties.Resources.Answer;
                                        }
                                    }
                                }
                            }
                        }
                        if (typequestion == "multichoice")
                        {
                            foreach (ShowAnswer showAnswer in audience.flp_AnswerQuiz.Controls)
                            {
                                foreach (CheckBox multiChoice in TeamCS.flp_Answer.Controls)
                                {
                                    if (multiChoice.Checked == true)
                                    {
                                        if (multiChoice.Text.ToLower() == showAnswer.chk1.Text.ToLower())
                                        {
                                            showAnswer.BackgroundImage = Properties.Resources.dung_2;
                                        }
                                        else
                                        {
                                            showAnswer.BackgroundImage = Properties.Resources.Answer;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        TeamCS.chk_Correct.Checked = false;
                    }  
                }
            }
        }
        #endregion

        //Load Form Open_Game
        private void Open_Game_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
            GetContestContent();
            lblHint.Text = guideline[0].ToString();
        }

        //show teams are challenged
        public void ShowTeamsChallenged()
        {
                    for (int i = 0; i < records.Count; i++)
                    {
                        //if (records.ElementAt(i).Exist == true)
                        //{
                            foreach (Team teamCS in flp_Team.Controls)
                            {
                                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(i).IDPlayer) && i!=team)
                                {
                                    teamCS.chk_Challenged.Visible = true;
                                }
                            }
                        //}
                    }
            
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
        //Update log
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
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = (int.Parse(lbl_Time.Text) - 1).ToString(); //lowering the value - explained above
            if (int.Parse(lbl_Time.Text)<10 && int.Parse(lbl_Time.Text) >1)
            {
                try
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DongHo.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception)
                {
                }
                
            }
            if (int.Parse(lbl_Time.Text) == 1)
            {
                try
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\HetGio.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception)
                {
                }
            }

            if (int.Parse(lbl_Time.Text) == 0)  //if the countdown reaches '0', we stop it
                timer1.Stop();
        }

        //Get last player when there is team go to finish lane
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

        #region Control Audience Screen
//show setting audience screen
        private void pb_Setting_Click(object sender, EventArgs e)
        {
            Point ptLowerLeft = new Point(0, pb_Setting.Height);
            ptLowerLeft = pb_Setting.PointToScreen(ptLowerLeft);
            ctMenuStrip_Setting.Show(ptLowerLeft);
        }
//Maximize audience screen
        private void mnui_Maximize_Click(object sender, EventArgs e)
        {
            audience.WindowState = FormWindowState.Maximized;
        }
//Minimize audience screen
        private void mnui_Minimize_Click(object sender, EventArgs e)
        {
            audience.WindowState = FormWindowState.Minimized;
        }
//Restore down audience Screen
        private void mnui_RestoreDown_Click(object sender, EventArgs e)
        {
            audience.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Control Controller Screen
//Minimize controller screen
        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
//Maximize controller screen
        private void pb_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.toolTip1.SetToolTip(this.pb_Maximize, "Maximize");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.toolTip1.SetToolTip(this.pb_Maximize, "Restore Down");
            }

        }
//Closed Controller Screen and Audience screen
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit Contest?", "Close Contest", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                this.Close();
                audience.Close();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }
        #endregion

        #region Play Game and Statictis Game
//Click play to execute game
        private void pb_Play_Click(object sender, EventArgs e)
        {
            StartGame();
        }
//Click to statistic the result of game
        bool finish = true;
        int tab;
        private void pb_EndGame_Click(object sender, EventArgs e)
        {
            if (finish)
            {
                tab = audience.tbc_ShowGame.SelectedIndex;
                audience.tbc_ShowGame.SelectedTab = audience.tab_EndGame;
                EndGame();
                finish = false;
                pb_Play.Visible = false;
            }
            else
            {
                audience.flp_TeamEndGame.Controls.Clear();
                pb_Play.Visible = true;
                int length = records.Count;
                Record temp = records[0];

                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (records.ElementAt(i).SequecePlayer > records.ElementAt(j).SequecePlayer)
                        {
                            temp = records[i];

                            records[i] = records[j];

                            records[j] = temp;
                        }
                    }
                }
                if (GameOverAll == true)
                {
                    pb_Play.Visible = false;
                }
                audience.tbc_ShowGame.SelectedIndex = tab;
                finish = true;
            }
            
        }
        ////Each step to controller control game
        public void StartGame()
        {
            //Rungame.IdContest = iDContest;
            audience.IdContest = iDContest;
            if (step == 1)
            {
                
                //this.SuspendLayout();
                audience.SuspendLayout();
                lblHint.Text = guideline[1].ToString();
                loadMap();

                Contest.Run_I = 1;
                ContestBL.CheckRunContestbyID(Contest);
                //Sound
                if (SoundWelcome == true)
                {
                    try
                    {
                        axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\ChaoMung.wav";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        SoundWelcome = false;
                    }
                    catch (Exception)
                    {
                    }
                    
                }
                audience.ResumeLayout();
                //this.ResumeLayout();

            }
            else if (step == 2)
            {
                //sound to player's turn
                try
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Click.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception)
                {
                }

                lblHint.Text = guideline[2].ToString();
                GoPlayer();
            }
            else if (step == 3)
            {
                lblHint.Text = guideline[3].ToString();
                ShowQuestion();
            }
            else if (step == 4)
            {
                //sound enter answer
                try
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\CapNhatDiem.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception)
                {
                }

                lblHint.Text = guideline[4].ToString();
                EnterAnswer();
                //turn off  time
                lbl_Time.Text = "1";
                audience.lbl_TimeShowQuestion.Text = "1";
                //Hide table answer
                foreach (Team teamCS in flp_Team.Controls)
                {
                    teamCS.flp_Answer.Visible = false;
                }
            }
            else if (step == 5)
            {
                //Sound show corect answer when challenged
                if (CheckChallengeChoice == true)
                {
                    try
                    {
                        axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch (Exception)
                    {
                    }
                }
                lblHint.Text = guideline[5].ToString();
                ShowCorrectAnswer();
            }
            else if (step == 6)
            {
                step++;
                loadNumberQuestionInPhase();
                UpdateScreenAfterChallenge();
                audience.tbc_ShowGame.SelectedTab = audience.tab_Map;
                lblHint.Text = guideline[6].ToString();
                DisplayScorePlayerGet();
                //hide check correct
                foreach (Team teamCS in flp_Team.Controls)
                {
                    teamCS.chk_Correct.Visible = false;
                }
            }
            else if (step == 7)
            {
                //sound check score
                try
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\CapNhatDiem.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception)
                {
                }

                lblHint.Text = guideline[0].ToString();
                UpdateScreenAfterChallenge();
                CalculteScore();
                audience.tbc_ShowGame.SelectedTab = audience.tab_Map;
                foreach (Team_AudienceScreeen teamAS in audience.flp_Team.Controls)
                {
                    teamAS.lbl_Score.Text = "";
                    teamAS.lbl_Score.Visible = false;
                }
            }
        }
//End game and report Result
        public void EndGame()
        {
            //Sort player assending in list player
            int length = records.Count;
            Record temp = records[0];
            //Declare data
            string[] Rank = new string[] { "st", "nd", "rd", "th", "th" };

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
            int width = audience.flp_TeamEndGame.Width;
            //Show player
            for (int i = 0; i < records.Count; i++)
            {
                TeamEndGame teamEndGame = new TeamEndGame();
                teamEndGame.lbl_Score.Text = records.ElementAt(i).TeamScore.ToString();
                teamEndGame.lbl_Name.Text = nameplayer(records.ElementAt(i).IDPlayer);
                teamEndGame.pb_TeamShirt.BackColor = Color.FromArgb(colorplayer(records.ElementAt(i).IDPlayer));
                teamEndGame.Size = new System.Drawing.Size(width - 10, teamEndGame.Height);
                if (i == 0)
                {
                    teamEndGame.BackgroundImage = Properties.Resources.First;
                }
                if (i == 1)
                {
                    if (records.ElementAt(1).TeamScore == records.ElementAt(0).TeamScore)
                    {
                        teamEndGame.BackgroundImage = Properties.Resources.First;
                    }
                    else
                    {
                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                    }
                }
                if (i == 2)
                {
                    if (records.ElementAt(2).TeamScore == records.ElementAt(0).TeamScore)
                    {
                        teamEndGame.BackgroundImage = Properties.Resources.First;
                    }
                    else
                    {
                        if (records.ElementAt(2).TeamScore == records.ElementAt(1).TeamScore)
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                        }
                        else
                        {
                            if (records.ElementAt(0).TeamScore == records.ElementAt(1).TeamScore)
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                            }
                            else
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                            }
                        }
                    }
                }
                if (i == 3)
                {
                    if (records.ElementAt(3).TeamScore == records.ElementAt(0).TeamScore)
                    {
                        teamEndGame.BackgroundImage = Properties.Resources.First;
                    }
                    else
                    {
                        if (records.ElementAt(3).TeamScore == records.ElementAt(1).TeamScore)
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                        }
                        else
                        {
                            if (records.ElementAt(1).TeamScore == records.ElementAt(0).TeamScore)
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                            }
                            else
                            {
                                if (records.ElementAt(3).TeamScore == records.ElementAt(2).TeamScore)
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                }
                                else
                                {
                                    if (records.ElementAt(2).TeamScore == records.ElementAt(1).TeamScore)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                        teamEndGame.lbl_Position.Visible = true;
                                    }
                                }
                            }
                            
                        }
                    }
                    
                }
                audience.flp_TeamEndGame.Controls.Add(teamEndGame);
            }
        }
        #endregion

        #region Step 1: Load Map in game
        //--1 load Map in game
        public void loadMap()
        {
            Screen[] screens = Screen.AllScreens;
            if (screens.Count() > 1)
            {
                Rectangle bounds = screens[1].Bounds;
                audience.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                audience.StartPosition = FormStartPosition.Manual;
                audience.Show();
            }
            else
            {
                audience.Show();
            }

            //audience.Show();
            audience.flp_PlayerAnswers.Controls.Clear();
            audience.prgb_Question.Value = 0;
            audience.btn_PM.Text = "";
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
                teamControllerScreen.BackgroundImage = Properties.Resources.team_2;
                teamControllerScreen.BackColor = Color.FromArgb(colorplayer(records.ElementAt(i).IDPlayer));
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
                teamControllerScreen.chk_Correct.Checked = false;
                teamControllerScreen.chk_Correct.Visible = false;

                i++;
            }
            //show lanes in audience screen
            Record Restore = new Record();
            Restore.IDContest = iDContest;
            List<Record> ListRestore;
            ListRestore = RecordBL.GetRecordByIDContest(Restore);
            int k = 0;

            foreach (Player_Lane1 playerLane in audience.pnl_Lane.Controls)
            {
                
                playerLane.btn_Team.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(playerLane.lbl_IDPlayer.Text)));
                playerLane.BackColor = Color.Transparent;
                playerLane.HighLight(false);
                //show player lane on audience screen
                if (Run == true && SoundWelcome== true)
                {
                    int H_Phase = (playerLane.Height - playerLane.btn_Team.Height - playerLane.lbl_Finish.Location.Y - playerLane.lbl_Finish.Height) / (AmountPhase * AmountSteptoPass);
                    playerLane.btn_Team.Location = new Point(playerLane.btn_Team.Location.X + 0, playerLane.btn_Team.Location.Y - (H_Phase / 2 + playerLane.btn_Team.Height / 2) - H_Phase*ListRestore.ElementAt(k).TotalPass);
                }
                k++;
            }

            int j = 0;
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                teamAdienceScreen.HighLight(false);
                teamAdienceScreen.HighLightChallenge(false);
                teamAdienceScreen.BackColor = Color.Transparent;
                teamAdienceScreen.lbl_TeamName.Text = nameplayer(records.ElementAt(j).IDPlayer);
                teamAdienceScreen.lbl_TeamScore.Text = records.ElementAt(j).TeamScore.ToString();
                teamAdienceScreen.lbl_TeamScore.ForeColor = Color.White;
                teamAdienceScreen.lbl_TeamName.ForeColor = Color.White;
                teamAdienceScreen.btn_SupportChoice.BackColor = Color.SkyBlue;
                teamAdienceScreen.btn_ChallengeChoice.BackColor = Color.SkyBlue;
                //check support choice exist to show
                if (records.ElementAt(j).Support == true)
                {
                    //keep image
                }
                else
                {
                    //teamAdienceScreen.pb_SupportChoice.Image = Properties.Resources.het_y_kien;
                    teamAdienceScreen.btn_SupportChoice.BackgroundImage = Properties.Resources.End_Support;
                }
                //check challenge choice exist to show
                if (records.ElementAt(j).Defy == true)
                {
                    //keep image
                }
                else
                {
                    //teamAdienceScreen.pb_ChallengeChoice.Image = Properties.Resources.het_thach_dau;
                    teamAdienceScreen.btn_ChallengeChoice.BackgroundImage = Properties.Resources.Shield_Grey;
                }
                //show heart in player
////////
                if (records.ElementAt(team).Undie == false)
                {
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
                }
                else
                {
                    teamAdienceScreen.pb_Heart1.Hide();
                    teamAdienceScreen.pb_Heart2.Hide();
                    teamAdienceScreen.pb_Heart3.Hide();
                }
                
                j++;
            }
            //Clear panel
            audience.flp_AnswerQuiz.Controls.Clear();
            audience.lbl_QuestionContent.Text = "";
            audience.lbl_Phase.Text = "";
            audience.lbl_typeQ.Text = "";
            audience.lbl_Point.Text = "";

            loadNumberQuestionInPhase();
            //move to next step
            step++;
        }
        #endregion

        #region Step 2: Go to Player's turn
        //--2 Go to player's turn
        public void GoPlayer()
        {
            // Get team in turn
            //if (OutOfQuestionPM == true && OutOfQuestionInPhase == true)
            //{
            //    for (int i = 0; i < records.Count; i++)
            //    {
            //        if (i == team)
            //        {
            //            if (records.ElementAt(i).Exist == true)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                team++;
            //                if (team == AmountPlayer)
            //                {
            //                    for (int j = 0; j < records.Count; j++)
            //                    {
            //                        if (records.ElementAt(j).Exist == true)
            //                        {
            //                            team = j;
            //                            break;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
////////    
            if (records.ElementAt(team).Undie == false)
            {
                if (records.ElementAt(team).Exist == false)
                {
                    pb_Play.Enabled = false;
                }
            }
            else
            {
                ////////
            }

            Record Restore = new Record();
            //show on game controller screen
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    teamCS.BackgroundImage = Properties.Resources.Team;
                    teamCS.Enabled = true;
                    teamCS.flp_Answer.Visible = true;
                    teamCS.gb_team.Visible = true;
                    if (ExistPM()==false)
                    {
                        teamCS.chk_QuestionPM.Visible = false;
                    }
                    else
                    {
                        teamCS.chk_QuestionPM.Visible = true;
                    }
                    
                    teamCS.chk_Support.Visible = false;
                    if (records.ElementAt(team).Defy == true)
                    {
                        teamCS.chk_defy.Visible = true;
                    }
                    else
                    {
                        teamCS.chk_defy.Visible = false;
                    }
                    
                    Restore.PlayerTurn_I = 1;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTurn(Restore);
                    
                    
                }
                else
                {
                    teamCS.gb_team.Visible = false;
                    Restore.PlayerTurn_I = 0;
                    Restore.IDPlayer = Convert.ToInt32(teamCS.lbl_IDPlayer.Text);
                    Restore.IDContest = iDContest;

                    RecordBL.UpdateTurn(Restore);
                    
                }
            }

            //show player lane on audience screen
            foreach (Player_Lane1 Playerlane in audience.pnl_Lane.Controls)
            {
                if (Convert.ToInt32(Playerlane.lbl_SequencePlayer.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    Playerlane.HighLight(true);

                    if (records.ElementAt(team).NumPass == AmountSteptoPass && records.ElementAt(team).NumFail == AmountSteptofail && records.ElementAt(team).PhaseIndex == 0 && records.ElementAt(team).PM == true && Run==false)
                    {
                        int H_Phase = (Playerlane.Height - Playerlane.btn_Team.Height - Playerlane.lbl_Finish.Location.Y - Playerlane.lbl_Finish.Height) / (AmountPhase * AmountSteptoPass);
                        Playerlane.btn_Team.Location = new Point(Playerlane.btn_Team.Location.X + 0, Playerlane.btn_Team.Location.Y - (H_Phase / 2 + Playerlane.btn_Team.Height / 2));
                    }
                }
            }
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                if (Convert.ToInt32(teamAdienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                {
                    teamAdienceScreen.HighLight(true);
                    teamAdienceScreen.lbl_TeamScore.ForeColor = Color.Black;
                    teamAdienceScreen.lbl_TeamName.ForeColor = Color.Black;
                }
                else
                {
                    //if (teamAdienceScreen.pb_Heart1.Visible == false && teamAdienceScreen.pb_Heart2.Visible == false && teamAdienceScreen.pb_Heart3.Visible == false)
                    //{
                    //    //teamAdienceScreen.btn_Stop.BackgroundImage = Properties.Resources.Icon_stop;
                    //    teamAdienceScreen.BackgroundImage = Properties.Resources.Team_Over;
                    //}
                }
            }
            //move to next step
            step++;
        }
        #endregion

        #region Step 3: Show Question
        //--3 Show Question
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
                if (countTeamChallenged == 0 || countTeamChallenged > NumofChallenge)
                {
                    if (countTeamChallenged == 0)
                    {
                        MessageBox.Show("Please selected challenged team!");
                    }
                    else
                    {
                        MessageBox.Show("Maximum number of team will be challenged is " + NumofChallenge);
                    }
                }
                else
                {
                    foreach (Team teamCS in flp_Team.Controls)
                    {
                        if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                        {
                            
                            IDPhase = records.ElementAt(team).IDPhase;
                            //show question by id phase
                            if (ShowQuestionByIDPhase(IDPhase) == true)
                            {
                                teamCS.gb_team.Visible = false;
////////
                                audience.tbc_ShowGame.SelectedTab = audience.tab_ShowQuestion;
                                //sound show question
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\HienThiCauHoi.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }
                                step++;
                            }
                            else
                            {
                                MessageBox.Show("Run Out of Question");
                                OutOfQuestion();
                            }
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
                        
                        IDPhase = records.ElementAt(team).IDPhase;
                        //show question by id phase
                        if (ShowQuestionByIDPhase(IDPhase) == true)
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
////////
                            audience.tbc_ShowGame.SelectedTab = audience.tab_ShowQuestion;
                            //sund show question
                            try
                            {
                                axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\HienThiCauHoi.wav";
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            catch (Exception)
                            {
                            }
                            step++;
                        }
                        else
                        {
                            MessageBox.Show("Run Out of Question");
                            OutOfQuestion();
                        }
                    }
                }
            }
        }
//show question by id question
        public bool ShowQuestionByIDPhase(int id)
        {
            //declare
            List<Phase> ListPhase;
            List<Question> ListQuestion;
            List<Answer> ListAnswer;
            int idquestion = 0;
            int a = 65;
            Phase.IDPhase = id;

            ListPhase = PhaseQuestionBl.getquestionRunGame(Phase);
            //if (ListPhase != null)
            //{
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
                    audience.lbl_QuestionContent.Text = ListQuestion.ElementAt(0).NameQuestion;
                    FixSizeText();
                    //audience.lbl_QuestionContent.Size = new System.Drawing.Size(audience.pnl_QuestionFrame.Width * 66 / 100, audience.lbl_QuestionContent.Height);
                    //audience.lbl_QuestionContent.Location = new Point(audience.lbl_QuestionContent.Location.X - audience.lbl_QuestionContent.Location.X + (audience.pnl_QuestionFrame.Width / 2) * 35 / 100, audience.lbl_QuestionContent.Location.Y);
                    audience.lbl_Phase.Text = NameofPhase(id) + "(" + (ListPhase.Count - 1) + ")";
                    audience.lbl_Point.Text = "Point: " + BonusScoreofPhase(id).ToString();
                    //get score
                    _BonusPhase = BonusScoreofPhase(id);
                    _MinusPhase = MinusScoreofPhase(id);
                    typequestion = ListQuestion.ElementAt(0).TypeQuestion.ToLower();
                    if (typequestion == "multichoice")
                    {
                        audience.lbl_typeQ.Text = "Type: Choose one answer";
                    }
                    else
                    {
                        if (typequestion == "onechoice")
                        {
                            audience.lbl_typeQ.Text = "Type: Choose multi answer";
                        }
                        else
                        {
                            audience.lbl_typeQ.Text = "Type: Fill short answer";
                        }
                    }

                    /////question is onechoice type
                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            ShowAnswer ShowAnswer = new ShowAnswer();
                            ShowAnswer.Size = new System.Drawing.Size(audience.flp_AnswerQuiz.Width / 2 - 10, audience.flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)ListAnswer.Count / 2)) - 10);
                            ShowAnswer.rdb1.Text = Convert.ToChar(a + h).ToString();
                            ShowAnswer.lbl_labelAnswer.Text = Convert.ToChar(a + h).ToString() + ":";
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
                                ShowAnswer.chk1.Text = Convert.ToChar(a + h).ToString();
                                ShowAnswer.lbl_labelAnswer.Text = Convert.ToChar(a + h).ToString() + ":";
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
                //timer1.Interval = 1000;
                timer1.Start();
                //show time conut down on audience screen
                audience.lbl_TimeShowQuestion.Text = ListPhase.ElementAt(0).TimePhase.ToString();
                audience.prgb_Question.Maximum = Convert.ToInt32(audience.lbl_TimeShowQuestion.Text);
                time = Convert.ToInt32(audience.lbl_TimeShowQuestion.Text);
                //audience.timer1.Interval = 1000;
                audience.timer1.Start();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //} 
        }
//Show table answer for one player. When Not Challenge
        void TableAnswerOneTeam(List<Question> ListQuestion, List<Answer> ListAnswer)
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
                    PlayerAnswer.pb_Result.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(teamCS.lbl_IDPlayer.Text)));
                    PlayerAnswer.lbl_IDPlayer.Text = teamCS.lbl_IDPlayer.Text;
                    PlayerAnswer.lbl_TeamName.Text = teamCS.lbl_TeamName.Text;
                    PlayerAnswer.Location = new Point(PlayerAnswer.Location.X + (audience.flp_PlayerAnswers.Width / 2 - PlayerAnswer.Width / 2), PlayerAnswer.Location.Y + 5);
                    audience.flp_PlayerAnswers.Controls.Add(PlayerAnswer);

                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.ForeColor = Color.White;
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
                                checkBox.ForeColor = Color.White;
                                checkBox.Text = Convert.ToChar(a + h).ToString();
                                checkBox.AutoSize = true;
                                teamCS.flp_Answer.Controls.Add(checkBox);
                            }
                        }
                        else
                        {
                            TextBox textBox = new TextBox();
                            textBox.ForeColor = Color.Black;
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
//Show table answer for multiteam. When Have challenge
        void TableAnswerMultiTeam(List<Question> ListQuestion, List<Answer> ListAnswer)
        {
            int a = 65;
            int No = 0;
            int D = 0;
            foreach (Team teamCS in flp_Team.Controls)
            {
                teamCS.chk_Challenged.Visible = false;
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked == true)
                {
                    D++;
                }
            }
            int D1 = D - 1;
            /////show answer one on control screen
            foreach (Team teamCS in flp_Team.Controls)
            {
                teamCS.chk_Challenged.Visible = false;
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked == true)
                {
                    PlayerAnswer PlayerAnswer = new PlayerAnswer();
                    PlayerAnswer.pb_Result.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(teamCS.lbl_IDPlayer.Text)));
                    PlayerAnswer.lbl_IDPlayer.Text = teamCS.lbl_IDPlayer.Text;
                    PlayerAnswer.lbl_TeamName.Text = teamCS.lbl_TeamName.Text;
                    PlayerAnswer.Location = new Point(PlayerAnswer.Location.X + (audience.flp_PlayerAnswers.Width / (D) / 2 - PlayerAnswer.Width / 2) + audience.flp_PlayerAnswers.Width / D * No, PlayerAnswer.Location.Y + 5);
                    audience.flp_PlayerAnswers.Controls.Add(PlayerAnswer);
                    No++;
                    D1--;
                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            RadioButton radioButton = new RadioButton();
                            radioButton.ForeColor = Color.White;
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
                                checkBox.ForeColor = Color.White;
                                checkBox.Text = Convert.ToChar(a + h).ToString();
                                checkBox.AutoSize = true;
                                teamCS.flp_Answer.Controls.Add(checkBox);
                            }
                        }
                        else
                        {
                            TextBox textBox = new TextBox();
                            textBox.ForeColor = Color.Black;
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
        #endregion

        #region Step 4: Enter Answer From Player
//--4 Enter answer from player
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
//Enter answer for Not challenge choice
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
                                        showAnswer.BackgroundImage = Properties.Resources.chon;

                                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                                        {
                                            //check team on controller screen and TeamAnswer on audience screen is equal
                                            if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                                            {
                                                playerAnswer.lbl_TeamAnswer.Text = oneChoice.Text;
                                            }
                                        }
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
                                            showAnswer.BackgroundImage = Properties.Resources.chon;

                                            foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                                            {
                                                if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                                                {
                                                    playerAnswer.lbl_TeamAnswer.Text += multiChoice.Text + " ";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (TextBox shortanswer in teamCS.flp_Answer.Controls)
                            {
                                PlayerAnswerShortQuestion = shortanswer.Text;

                                foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                                {
                                    //check team on controller screen and TeamAnswer on audience screen is equal
                                    if (teamCS.lbl_IDPlayer.Text == playerAnswer.lbl_IDPlayer.Text)
                                    {
                                        playerAnswer.lbl_TeamAnswer.Text = shortanswer.Text;
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
//Enter answer for chanllenge choice
        public void EnterAnswerChallenge()
        {
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked == true)
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
        #endregion

        #region Step 5: Show Correct Answer
//--5 Show correct answer
        public void ShowCorrectAnswer()
        {
            //show correct answer with question type: onechoie or multichoice
            if (typequestion == "onechoice" || typequestion == "multichoice")
            {
                foreach (ShowAnswer answer in audience.flp_AnswerQuiz.Controls)
                {
                    if (answer.lbl_Correct.Text.ToLower() == "true")
                    {
                        answer.BackgroundImage = Properties.Resources.dung_2;
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
                CorrectAnswerChallenge = CorrectShortAnswer;
            }

            //check player correct or incorrect
            if (typequestion == "multichoice")
            {
                foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                {
                    if (playerAnswer.lbl_TeamAnswer.Text.Trim().Replace(" ", "").ToLower() == CorrectAnswerChallenge.ToLower())
                    {
                        playerAnswer.lbl_Check.Text = "true";
                        playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                        //Show Score team have receive
                        if (CheckChallengeChoice == false)
                        {
                            //Sound
                            try
                            {
                                axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            catch (Exception)
                            {
                            }
                            

                            if (_BonusPhase ==0)
                            {
                                playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                            }
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            ReceiveScoreChallenge();
                        }
                    }
                    else
                    {
                        playerAnswer.lbl_Check.Text = "false";
                        playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;

                        //sound wrong answer
                        if (CheckChallengeChoice == false)
                        {
                            //Sound
                            try
                            {
                                axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnSai.wav";
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            catch (Exception)
                            {
                            }
                            
                            if (_MinusPhase==0)
                            {
                                playerAnswer.lbl_Score.Text = "" + _MinusPhase;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "-" + _MinusPhase;
                            }
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            ReceiveScoreChallenge();
                        }
                    }
                }


            }
            else
            {
                if (typequestion == "onechoice")
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (playerAnswer.lbl_TeamAnswer.Text.ToLower() == CorrectAnswerChallenge.ToLower())
                        {
                            playerAnswer.lbl_Check.Text = "true";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                            //Show Score team have receive
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                if (_BonusPhase==0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                        else
                        {
                            playerAnswer.lbl_Check.Text = "false";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;

                            //sound wrong answer
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnSai.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                if (_MinusPhase == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _MinusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + _MinusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                    }
                }
                else
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (playerAnswer.lbl_TeamAnswer.Text.ToLower() == CorrectAnswerChallenge.ToLower())
                        {
                            playerAnswer.lbl_Check.Text = "true";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                            //Show Score team have receive
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                if (_BonusPhase == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                        else
                        {
                            playerAnswer.lbl_Check.Text = "false";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;

                            //sound wrong answer
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnSai.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                if (_MinusPhase == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _MinusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + _MinusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                    }
                }
            }

            //Show check correct
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer) || teamCS.chk_Challenged.Checked == true)
                {
                    teamCS.chk_Correct.Visible = true;
                }
            }
            step++;
        }
        #endregion

        #region Step 6: Load Map Again
//Update Number question in phase on audience screen
        public void loadNumberQuestionInPhase()
        {
            audience.btn_PM.Text = "";
            //get phase
            Phase.IDContest = iDContest;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseNormal(Phase);
            AmountPhase = ListPhase.Count;
            int i = 0;
            foreach (Phase_Lane PhaseLane in audience.pnl_Phase.Controls)
            {
                Phase.IDPhase = ListPhase.ElementAt(i).IDPhase;
                List<Phase> ListPhase1;
                ListPhase1 = PhaseQuestionBl.getquestionRunGame(Phase);
                PhaseLane.lbl_NamePhase.Text = ListPhase.ElementAt(i).NamePhase + "\n" + "(" + ListPhase1.Count + ")";
                i++;
            }

            List<Phase> ListPM;
            ListPM = PhaseBL.GetPhasePM(Phase);
            try
            {
                Phase.IDPhase = ListPM.ElementAt(0).IDPhase;
                List<Phase> ListPM1;
                ListPM1 = PhaseQuestionBl.getquestionRunGame(Phase);
                string namephase = ListPM.ElementAt(0).NamePhase;
                for (int j = 0; j < namephase.Length; j++)
                {
                    audience.btn_PM.Text += namephase[j] + "\n";
                }
                audience.btn_PM.Text += "\n"+"(" + ListPM1.Count + ")";
            }
            catch (Exception)
            {

                audience.btn_PM.Visible = false;
            }
        }
//Update Gui after have challenge
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
                playerLane.btn_Team.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(playerLane.lbl_IDPlayer.Text)));
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
                    teamAdienceScreen.btn_SupportChoice.BackgroundImage = Properties.Resources.End_Support;
                }
                //check challenge choice exist to show
                if (records.ElementAt(j).Defy == true)
                {
                    //keep image
                }
                else
                {
                    teamAdienceScreen.btn_ChallengeChoice.BackgroundImage = Properties.Resources.Shield_Grey;
                }

                //check to stop game player
                if (records.ElementAt(j).Exist == false)
                {
                    //teamAdienceScreen.btn_Stop.BackgroundImage = Properties.Resources.Icon_stop;
                    teamAdienceScreen.BackColor = Color.Transparent;
                    teamAdienceScreen.btn_ChallengeChoice.BackColor = Color.Transparent;
                    teamAdienceScreen.btn_SupportChoice.BackColor = Color.Transparent;
                    teamAdienceScreen.lbl_TeamScore.BackColor = Color.Transparent;
                    teamAdienceScreen.lbl_TeamName.BackColor = Color.Transparent;
                    teamAdienceScreen.flp_Heart.BackColor = Color.Transparent;
                    teamAdienceScreen.BackgroundImage = Properties.Resources.Team_Over;
                    if (step == 7 && records.ElementAt(j).IDPlayer == records.ElementAt(team).IDPlayer)
                    {
                        //sound.Stop();
                        //sound = new SoundPlayer(Properties.Resources.game_over);
                        //sound.Play();
                    }

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
        #endregion

        #region Step 7: Update Score
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
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.pb_Play, "Game Over");

                pb_Play.Visible = false;
                //pb_EndGame.Visible = true;
                UpdateScreenAfterChallenge();
                Contest.EndContest = 1;
                ContestBL.EditStatusContestbyID(Contest);
/////////
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //move to another player
                CorrectAnswer = 0;
                PlayerCheck = 0;
                if (GameOver == true)
                {
                    if (records.ElementAt(team).SequecePlayer == records.ElementAt(records.Count-1).SequecePlayer)
                    {
                        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                        ToolTip1.SetToolTip(this.pb_Play, "Game Over");
                        pb_Play.Visible = false;
                        GameOverAll = true;
                        UpdateScreenAfterChallenge();
                        //update status contest id this contest have run
                        Contest.EndContest = 1;
                        ContestBL.EditStatusContestbyID(Contest);
/////////
                        this.DialogResult = DialogResult.OK;
                    }
                }
                team++;

                Record Restore = new Record();
                //show on game controller screen
                foreach (Team teamCS in flp_Team.Controls)
                {
                    if (Convert.ToInt32(teamCS.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                    {
                        Restore.PlayerTurn_I = 1;
                        Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                        Restore.IDContest = iDContest;
                        RecordBL.UpdateTurn(Restore);
                    }
                    else
                    {
                        Restore.PlayerTurn_I = 0;
                        Restore.IDPlayer = Convert.ToInt32(teamCS.lbl_IDPlayer.Text);
                        Restore.IDContest = iDContest;
                        RecordBL.UpdateTurn(Restore);
                    }
                }

                step = 1;
            }
        }
//Calculate score and update player information for challengece choice
        public void CalculateScoreChallenge()
        {
            //foreach (Team teamCS in flp_Team.Controls)
            //{
            //    if (teamCS.chk_Correct.Checked == true)
            //    {
            //        foreach (PlayerAnswer PlayerAnswer in audience.flp_PlayerAnswers.Controls)
            //        {
            //            if (teamCS.lbl_IDPlayer.Text == PlayerAnswer.lbl_IDPlayer.Text)
            //            {
            //                PlayerAnswer.lbl_Check.Text = "true";
            //            }
            //        }
            //    }
            //}

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
        ////Update score, position, record after player have correct answer in PM question have challenge
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
                //Record
                Record Restore = new Record();
                //Team Score
                Restore.TeamScore = records.ElementAt(team).TeamScore;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateTeamScore(Restore);
                //update screen
            }
            //all team is incorrect
            if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).TeamScore -= MinusScoreQuestionPM;
                //Record
                Record Restore = new Record();
                //Team Score
                Restore.TeamScore = records.ElementAt(team).TeamScore;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateTeamScore(Restore);
                //update screen
            }
            //
            if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
            {
                //owner challenge win
                if (ownerChallenge == true)
                {
                    records.ElementAt(team).TeamScore += BonusScoreQuestionPM;
                    //Record
                    Record Restore = new Record();
                    //Team Score
                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTeamScore(Restore);

                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore -= ChallengeScore;
                                    //Record score for challenged team
                                    Restore.TeamScore = records.ElementAt(i).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(i).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);

                                    records.ElementAt(team).TeamScore += ChallengeScore;
                                    //Record score for defying team
                                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);
                                }
                            }

                        }
                    }
                    //update screen
                }
                else
                {//Owner challenge lose
                    records.ElementAt(team).TeamScore -= MinusScoreQuestionPM;
                    //Record
                    Record Restore = new Record();
                    //Team Score
                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTeamScore(Restore);

                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore += ChallengeScore;
                                    //Record score for challenged team
                                    Restore.TeamScore = records.ElementAt(i).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(i).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);

                                    records.ElementAt(team).TeamScore -= ChallengeScore;
                                    //Record score for defying team
                                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);
                                }
                            }

                        }
                    }
                }
            }
        }
        ////Update score, position, record after player have correct answer in phase have challenge
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
                //Record
                Record Restore = new Record();
                //Number of Correct
                Restore.NumPass = records.ElementAt(team).NumPass;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateNumofCorrect(Restore);

                records.ElementAt(team).TotalPass++;
                //Total correct
                Restore.TotalPass = records.ElementAt(team).TotalPass;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateTotalCorrect(Restore);

                records.ElementAt(team).TeamScore += BonusScoreInPhase;
                //Team score
                Restore.TeamScore = records.ElementAt(team).TeamScore;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateTeamScore(Restore);

                MoveNextPhaseHaveChallenge();
            }
            //all team is incorrect
            if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
            {
                records.ElementAt(team).NumFail -= 1;
                //Record
                Record Restore = new Record();
                //Number of incorrect
                Restore.NumFail = records.ElementAt(team).NumFail;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateNumofIncorrect(Restore);

                records.ElementAt(team).TeamScore -= MinusScoreInPhase;
                //Team score
                Restore.TeamScore = records.ElementAt(team).TeamScore;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateTeamScore(Restore);

                if (records.ElementAt(team).NumFail == 0 && records.ElementAt(team).Undie == false)
                {
                    records.ElementAt(team).Exist = false;
                    records.ElementAt(team).Defy = false;
                    records.ElementAt(team).Support = false;
                    //record
                    Restore.Defy_I = 0;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateDefy(Restore);

                    Restore.Support_I = 0;
                    RecordBL.UpdateSupport(Restore);

                    Restore.Exist_I = 0;
                    RecordBL.UpdateSupport(Restore);
                }
            }
            //
            if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
            {
                //owner challenge win
                if (ownerChallenge == true)
                {
                    records.ElementAt(team).TeamScore += BonusScoreInPhase;
                    //Record
                    Record Restore = new Record();
                    //Team score
                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTeamScore(Restore);

                    records.ElementAt(team).NumPass -= 1;
                    //Number of correct
                    Restore.NumPass = records.ElementAt(team).NumPass;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateNumofCorrect(Restore);

                    records.ElementAt(team).TotalPass++;
                    //Total correct
                    Restore.TotalPass = records.ElementAt(team).TotalPass;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTotalCorrect(Restore);

                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records.ElementAt(i).IDPlayer == Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text))
                                {
                                    records.ElementAt(i).TeamScore -= ChallengeScore;
                                    //Team score for challenged team
                                    Restore.TeamScore = records.ElementAt(i).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(i).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);

                                    records.ElementAt(team).TeamScore += ChallengeScore;
                                    //Team score for defying team
                                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);
                                }
                            }

                        }
                    }
                    MoveNextPhaseHaveChallenge();
                }
                else
                {//Owner challenge lose
                    records.ElementAt(team).TeamScore -= MinusScoreInPhase;
                    //Record
                    Record Restore = new Record();
                    //Team score
                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateTeamScore(Restore);

                    records.ElementAt(team).NumFail -= 1;
                    //Number of incorrect
                    Restore.NumFail = records.ElementAt(team).NumFail;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateNumofIncorrect(Restore);
////////
                    if (records.ElementAt(team).NumFail == 0 && records.ElementAt(team).Undie == false)
                    {
                        records.ElementAt(team).Exist = false;
                        records.ElementAt(team).Defy = false;
                        records.ElementAt(team).Support = false;
                        //record
                        Restore.Defy_I = 0;
                        Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                        Restore.IDContest = iDContest;
                        RecordBL.UpdateDefy(Restore);

                        Restore.Support_I = 0;
                        RecordBL.UpdateSupport(Restore);

                        Restore.Exist_I = 0;
                        RecordBL.UpdateSupport(Restore);
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
                                    //Team score for challenged team
                                    Restore.TeamScore = records.ElementAt(i).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(i).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);

                                    records.ElementAt(team).TeamScore -= ChallengeScore;
                                    //Team score for defying team
                                    Restore.TeamScore = records.ElementAt(team).TeamScore;
                                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                                    Restore.IDContest = iDContest;
                                    RecordBL.UpdateTeamScore(Restore);

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
            foreach (Team teamCS in flp_Team.Controls)
            {
                if (Convert.ToInt32(teamCS.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                {//player alway correct because question is mistake
                    //if (teamCS.chk_Correct.Checked == true)
                    //{
                    //    if (CheckQuestionPM == false)
                    //    {
                    //        int BonusScoreQuestionInPhase = BonusScoreofPhase(records.ElementAt(team).IDPhase);
                    //        PassQuestionInPhase(BonusScoreQuestionInPhase);
                    //    }
                    //    else
                    //    {
                    //        int BonusScoreQuestionPM = BonusScoreofPhase(IDPhasePM);
                    //        PassQuestionPM(BonusScoreQuestionPM);
                    //    }
                    //}
                    //else
                    //{// Calculate score for player when not use challenge choice
                        if (CheckQuestionPM == false)
                        {
                            int BonusScoreQuestionInPhase = BonusScoreofPhase(records.ElementAt(team).IDPhase);
                            int MinusScoreQuestionInPhase = MinusScoreofPhase(records.ElementAt(team).IDPhase);
                            //player answer with question onechoice or multichoice
                            if (typequestion == "onechoice" || typequestion == "multichoice")
                            {
                                //player answer correct
                                if (PlayerCheck == CorrectAnswer)
                                {
                                    PassQuestionInPhase(BonusScoreQuestionInPhase);
                                }
                                else
                                {
                                    FailQuestionInPhase(MinusScoreQuestionInPhase);
                                }
                            }
                            else
                            {//player answer with question shortanswer
                                if (PlayerAnswerShortQuestion.ToLower().Equals(CorrectShortAnswer.ToLower()) == true)
                                {
                                    PassQuestionInPhase(BonusScoreQuestionInPhase);
                                }
                                else
                                {
                                    FailQuestionInPhase(MinusScoreQuestionInPhase);
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
                                if (PlayerAnswerShortQuestion.ToLower().Equals(CorrectShortAnswer.ToLower()) == true)
                                {
                                    PassQuestionPM(BonusScoreQuestionPM);
                                }
                                else
                                {
                                    FailQuestionPM(MinusScoreQuestionPM);
                                }
                            }
                        }
                    //}
                }
            }
        }
        ////Pass question PM
        public void PassQuestionPM(int score)
        {
            records.ElementAt(team).TeamScore += score;
            //Record
            Record Restore = new Record();
            //Team score
            Restore.TeamScore = records.ElementAt(team).TeamScore;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateTeamScore(Restore);

            UpdateScreenAfterChallenge();
        }
        //// Fail quesion pm
        public void FailQuestionPM(int score)
        {
            records.ElementAt(team).TeamScore -= score;
            //Record
            Record Restore = new Record();
            //Team score
            Restore.TeamScore = records.ElementAt(team).TeamScore;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateTeamScore(Restore);

            UpdateScreenAfterChallenge();
        }
        ////Update score, position, record after player have correct answer in phase
        public void PassQuestionInPhase(int score)
        {
            //Record
            Record Restore = new Record();

            records.ElementAt(team).NumPass -= 1;
            //Number of correct
            Restore.NumPass = records.ElementAt(team).NumPass;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateNumofCorrect(Restore);

            records.ElementAt(team).TotalPass++;
            //Total correct
            Restore.TotalPass = records.ElementAt(team).TotalPass;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateTotalCorrect(Restore);

            records.ElementAt(team).TeamScore += score;
            //Team score
            Restore.TeamScore = records.ElementAt(team).TeamScore;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateTeamScore(Restore);

            MoveNextPhaseHaveChallenge();
            UpdateScreenAfterChallenge();
        }
        ////Update score, position, record after player have incorrect answer in phase
        public void FailQuestionInPhase(int score)
        {
            //Record
            Record Restore = new Record();
            //minus life if team fail in question
            records.ElementAt(team).NumFail -= 1;
            //Number of incorrect
            Restore.NumFail = records.ElementAt(team).NumFail;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateNumofIncorrect(Restore);

            records.ElementAt(team).TeamScore -= score;
            //Team score
            Restore.TeamScore = records.ElementAt(team).TeamScore;
            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
            Restore.IDContest = iDContest;
            RecordBL.UpdateTeamScore(Restore);
            
            

            if (records.ElementAt(team).NumFail == 0 && records.ElementAt(team).Undie == false)
            {
                records.ElementAt(team).Exist = false;
                records.ElementAt(team).Defy = false;
                records.ElementAt(team).Support = false;
                //Record
                Restore.Defy_I = 0;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateDefy(Restore);

                Restore.Support_I = 0;
                RecordBL.UpdateSupport(Restore);

                Restore.Exist_I = 0;
                RecordBL.UpdateSupport(Restore);
            }
            UpdateScreenAfterChallenge();
        }
        //////move to next phase when have challenge
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
                            //Record
                            Record Restore = new Record();
                            //Team score
                            Restore.TeamScore = records.ElementAt(team).TeamScore;
                            Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                            Restore.IDContest = iDContest;
                            RecordBL.UpdateTeamScore(Restore);

                            Done = false;
                            GameOver = true;
                            //show  icon to end when team have finished
                            //pb_EndGame.Visible = true;
                        }
                        int H_Phase = (PlayerLane.Height - PlayerLane.btn_Team.Height - PlayerLane.lbl_Finish.Location.Y - PlayerLane.lbl_Finish.Height) / (AmountPhase * AmountSteptoPass);
                        PlayerLane.btn_Team.Location = new Point(PlayerLane.btn_Team.Location.X + 0, PlayerLane.btn_Team.Location.Y - (H_Phase / 2 - PlayerLane.btn_Team.Height / 2) - PlayerLane.lbl_Finish.Height - PlayerLane.btn_Team.Height - 2);
                    }
                    else
                    {//move after done each question
                        int H_Phase = (PlayerLane.Height - PlayerLane.btn_Team.Height - PlayerLane.lbl_Finish.Location.Y - PlayerLane.lbl_Finish.Height) / (AmountPhase * AmountSteptoPass);
                        PlayerLane.btn_Team.Location = new Point(PlayerLane.btn_Team.Location.X + 0, PlayerLane.btn_Team.Location.Y - H_Phase);
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

                //Record
                Record Restore = new Record();
                //Number of correct
                Restore.NumPass = records.ElementAt(team).NumPass;
                Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                Restore.IDContest = iDContest;
                RecordBL.UpdateNumofCorrect(Restore);
                //Number of incorrect
                Restore.NumFail = records.ElementAt(team).NumFail;
                RecordBL.UpdateNumofIncorrect(Restore);
                //Phase index
                Restore.PhaseIndex = records.ElementAt(team).PhaseIndex;
                RecordBL.UpdatePhaseIndex(Restore);

                if (records.ElementAt(team).PhaseIndex < AmountPhase)
                {
                    records.ElementAt(team).IDPhase = ListPhase.ElementAt(records.ElementAt(team).PhaseIndex).IDPhase;
                    //Record
                    Restore.IDPhase = ListPhase.ElementAt(records.ElementAt(team).PhaseIndex).IDPhase;
                    Restore.IDPlayer = records.ElementAt(team).IDPlayer;
                    Restore.IDContest = iDContest;
                    RecordBL.UpdateIDPhase(Restore);
                }
                else
                {
                    //if phase out of range
                }
            }
        }
        
#endregion

        //Receive score - and + for each player when have challenge
        public void ReceiveScoreChallenge()
        {
            //Question PM
            if (CheckQuestionPM == true)
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
                //All team is correct
                if (countTeamTrue == audience.flp_PlayerAnswers.Controls.Count)
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                        {
                            
                            if (BonusScoreQuestionPM == 0)
                            {
                                playerAnswer.lbl_Score.Text = "" + BonusScoreQuestionPM;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "+" + BonusScoreQuestionPM;
                            }
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            playerAnswer.lbl_Score.Text = "0";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                    }
                }
                //All team is incorrect
                if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                        {
                            if (MinusScoreQuestionPM == 0)
                            {
                                playerAnswer.lbl_Score.Text = "" + MinusScoreQuestionPM;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "-" + MinusScoreQuestionPM;
                            }
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            playerAnswer.lbl_Score.Text = "0";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                    }
                }
                // There are some team correct and some team incorrect
                if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
                {
                    //Owner challenge win
                    if (ownerChallenge == true)
                    {
                        int NumTeamFail = 0;
                        //Receive score for team was challenged
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                            {
                                
                                if (ChallengeScore==0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + ChallengeScore;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + ChallengeScore;
                                }
                                NumTeamFail++;
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }

                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                            {
                                playerAnswer.lbl_Score.Text = "0";
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                        //Receive score for challenged owner
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                            {
                                
                                if ((BonusScoreQuestionPM + (NumTeamFail * ChallengeScore)) == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + (BonusScoreQuestionPM + (NumTeamFail * ChallengeScore));
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + (BonusScoreQuestionPM + (NumTeamFail * ChallengeScore));
                                }
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                    }
                    else
                    {//Owner challenge lose
                        int NumTeamTrue = 0;
                        //Receive score for team was challenged
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                            {
                                playerAnswer.lbl_Score.Text = "0";
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }

                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                            {
                                
                                if (ChallengeScore == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + ChallengeScore;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + ChallengeScore;
                                }
                                NumTeamTrue++;
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                        //Receive score for challenged owner
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                            {
                                if ((MinusScoreQuestionPM + (NumTeamTrue * ChallengeScore)) == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + (MinusScoreQuestionPM + (NumTeamTrue * ChallengeScore));
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + (MinusScoreQuestionPM + (NumTeamTrue * ChallengeScore));
                                }
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                    }
                }
            }
            else
            {//Question in Phase
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
                //All team is correct
                if (countTeamTrue == audience.flp_PlayerAnswers.Controls.Count)
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                        {
                            if (BonusScoreInPhase == 0)
                            {
                                playerAnswer.lbl_Score.Text = "" + BonusScoreInPhase;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "+" + BonusScoreInPhase;
                            }
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            playerAnswer.lbl_Score.Text = "0";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                    }
                }
                //All team is incorrect
                if (countTeamFalse == audience.flp_PlayerAnswers.Controls.Count)
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                        {
                            if (MinusScoreInPhase == 0)
                            {
                                playerAnswer.lbl_Score.Text = "" + MinusScoreInPhase;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "-" + MinusScoreInPhase;
                            }
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            playerAnswer.lbl_Score.Text = "0";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            playerAnswer.lbl_Score.Visible = true;
                        }
                    }
                }
                // There are some team correct and some team incorrect
                if (countTeamTrue != audience.flp_PlayerAnswers.Controls.Count && countTeamFalse != audience.flp_PlayerAnswers.Controls.Count)
                {
                    //owner challenge win
                    if (ownerChallenge == true)
                    {
                        int NumTeamFail = 0;
                        //Receive score for team was challenged
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                            {
                                if (ChallengeScore==0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + ChallengeScore;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + ChallengeScore;
                                }
                                NumTeamFail++;
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }

                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                            {
                                playerAnswer.lbl_Score.Text = "0";
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                        //Receive score for challenged owner
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                            {
                                if ((BonusScoreInPhase + (NumTeamFail * ChallengeScore)) == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + (BonusScoreInPhase + (NumTeamFail * ChallengeScore));
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + (BonusScoreInPhase + (NumTeamFail * ChallengeScore));
                                }
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                    }
                    else
                    {//Owner challenge lose

                        int NumTeamTrue = 0;
                        //Receive score for team was challenged
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "false")
                            {
                                playerAnswer.lbl_Score.Text = "0";
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }

                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) != records.ElementAt(team).IDPlayer && playerAnswer.lbl_Check.Text == "true")
                            {
                                if (ChallengeScore == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + ChallengeScore;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + ChallengeScore;
                                }
                                NumTeamTrue++;
                                playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                        //Receive score for challenged owner
                        foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                        {
                            if (Convert.ToInt32(playerAnswer.lbl_IDPlayer.Text) == records.ElementAt(team).IDPlayer)
                            {
                                if ((MinusScoreInPhase + (NumTeamTrue * ChallengeScore)) == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + (MinusScoreInPhase + (NumTeamTrue * ChallengeScore));
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "-" + (MinusScoreInPhase + (NumTeamTrue * ChallengeScore));
                                }
                                playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                                playerAnswer.lbl_Score.Visible = true;
                            }
                        }
                    }
                }
            }
            
        }

        //Check player always true
        public void AssignPlayerCorrect()
        {
            //show correct answer with question type: onechoie or multichoice
            if (typequestion == "onechoice" || typequestion == "multichoice")
            {
                foreach (ShowAnswer answer in audience.flp_AnswerQuiz.Controls)
                {
                    if (answer.lbl_Correct.Text.ToLower() == "true")
                    {
                        //answer.BackgroundImage = Properties.Resources.dung_2;
                        //if (typequestion == "onechoice")
                        //{
                        //    CorrectAnswerChallenge = answer.rdb1.Text;
                        //}
                        //else
                        //{
                        //    CorrectAnswerChallenge += answer.chk1.Text;
                        //}
                        CorrectAnswer++;
                        PlayerCheck++;
                    }
                }
            }
            else
            {
                CorrectAnswerChallenge = CorrectShortAnswer;
            }

            //check player correct or incorrect
            if (typequestion == "multichoice")
            {
                foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                {
                    if (playerAnswer.lbl_TeamAnswer1.Text.ToLower() == CorrectAnswerChallenge.ToLower() || playerAnswer.lbl_Check.Text == "true")
                    {
                        playerAnswer.lbl_Check.Text = "true";
                        playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                        //Show Score team have receive
                        if (CheckChallengeChoice == false)
                        {
                            //Sound
                            try
                            {
                                axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            catch (Exception)
                            {
                            }

                            if (_BonusPhase == 0)
                            {
                                playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                            }
                            else
                            {
                                playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                            }
                            playerAnswer.lbl_Score.Visible = true;
                        }
                        else
                        {
                            ReceiveScoreChallenge();
                        }
                    }
                    else
                    {
                        playerAnswer.lbl_Check.Text = "false";
                        playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;

                        //sound wrong answer
                        if (CheckChallengeChoice == true)
                        {
                            ReceiveScoreChallenge();
                        }
                    }
                }
            }
            else
            {
                if (typequestion == "onechoice")
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (playerAnswer.lbl_TeamAnswer1.Text.ToLower() == CorrectAnswerChallenge.ToLower() || playerAnswer.lbl_Check.Text == "true")
                        {
                            playerAnswer.lbl_Check.Text = "true";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                            //Show Score team have receive
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }

                                if (_BonusPhase == 0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                        else
                        {
                            playerAnswer.lbl_Check.Text = "false";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            //sound wrong answer
                            if (CheckChallengeChoice == true)
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                    }
                }
                else
                {
                    foreach (PlayerAnswer playerAnswer in audience.flp_PlayerAnswers.Controls)
                    {
                        if (playerAnswer.lbl_TeamAnswer1.Text.ToLower() == CorrectAnswerChallenge.ToLower() || playerAnswer.lbl_Check.Text == "true")
                        {
                            playerAnswer.lbl_Check.Text = "true";
                            playerAnswer.pb_Result.Image = Properties.Resources.Correct_ico;

                            //Show Score team have receive
                            if (CheckChallengeChoice == false)
                            {
                                //Sound
                                try
                                {
                                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\DapAnDung.wav";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                }
                                catch (Exception)
                                {
                                }
                                
                                if (_BonusPhase ==0)
                                {
                                    playerAnswer.lbl_Score.Text = "" + _BonusPhase;
                                }
                                else
                                {
                                    playerAnswer.lbl_Score.Text = "+" + _BonusPhase;
                                }
                                playerAnswer.lbl_Score.Visible = true;
                            }
                            else
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                        else
                        {
                            playerAnswer.lbl_Check.Text = "false";
                            playerAnswer.pb_Result.Image = Properties.Resources.X_icon_vien;
                            //sound wrong answer
                            if (CheckChallengeChoice == true)
                            {
                                ReceiveScoreChallenge();
                            }
                        }
                    }
                }
            }
        }
        //Display score bonus or minus score for player on audience screen
        public void DisplayScorePlayerGet()
        {
            foreach (PlayerAnswer playerAnswer  in audience.flp_PlayerAnswers.Controls)
            {
                foreach (Team_AudienceScreeen TeamAS in audience.flp_Team.Controls)
                {
                    if (TeamAS.lbl_ID.Text == playerAnswer.lbl_IDPlayer.Text)
                    {
                        TeamAS.lbl_Score.Text = playerAnswer.lbl_Score.Text;
                        TeamAS.lbl_Score.Visible = true;
                    }
                }
            }
        }
        //Fix size text in question frame
        public void FixSizeText()
        {
            string []NewLine= audience.lbl_QuestionContent.Text.Split('\n');

            if (audience.lbl_QuestionContent.Text.Count() > 585 || NewLine.Length > 9)
            {
                audience.lbl_QuestionContent.Font = new Font(audience.lbl_QuestionContent.Font.FontFamily, 11.0f, audience.lbl_QuestionContent.Font.Style);
            }
            else
            {
                if (audience.lbl_QuestionContent.Text.Count() > 280 || NewLine.Length>7)
                {
                    audience.lbl_QuestionContent.Font = new Font(audience.lbl_QuestionContent.Font.FontFamily, 15.0f, audience.lbl_QuestionContent.Font.Style);
                }
                else
                {
                    audience.lbl_QuestionContent.Font = new Font(audience.lbl_QuestionContent.Font.FontFamily, 21.0f, audience.lbl_QuestionContent.Font.Style);
                }
            }
        }

        //out of question to move to next player
        public void OutOfQuestion()
        {
            if (ExistPM() == true)
            {
                if (NumofQuestionPM() == 0 && NumofQuestionInPhase(records.ElementAt(team).IDPhase) == 0)
                {
                    axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Click.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    lblHint.Text = guideline[2].ToString();
                    step = 2;
                    team++;
                    if (team == records.Count)
                    {
                        team = 0;
                    }
                    GoPlayer();

                }
                //sound to player's turn
            }
            else
            {
                if (NumofQuestionInPhase(records.ElementAt(team).IDPhase) == 0)
                {
                    try
                    {
                        axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Click.wav";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch (Exception)
                    {
                    }

                    lblHint.Text = guideline[2].ToString();
                    step = 2;
                    team++;
                    if (team == records.Count)
                    {
                        team = 0;
                    }
                    GoPlayer(); 
                }
            }
        }

        //check phase PM exist
        public bool ExistPM()
        {
            try
            {
                List<Phase> ListPhase;
                Phase.IDContest = iDContest;
                ListPhase = PhaseBL.GetPhasePM(Phase);
                IDPhasePM = ListPhase.ElementAt(0).IDPhase;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //numbe question in phase PM
        public int NumofQuestionPM()
        {
            List<Phase> ListPhase;
            Phase.IDContest = iDContest;
            ListPhase = PhaseBL.GetPhasePM(Phase);
            Phase.IDPhase = ListPhase.ElementAt(0).IDPhase;
            ListPhase = PhaseQuestionBl.getquestionRunGame(Phase);
            return ListPhase.Count;
        }
        public int NumofQuestionInPhase(int id)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = id;
            ListPhase = PhaseQuestionBl.getquestionRunGame(Phase);
            return ListPhase.Count;
        }
        
    }
}

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
        Run_Game Rungame = new Run_Game();
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
        int step = 1;
        int team = 0;

        string[] guideline = new string[] 
        {"Bấm để tải sơ đồ cuộc thi",
        "Bấm để đến lượt đội thi đấu tiếp theo",
        "Bấm để hiển thị câu hỏi và các câu trả lời",
        "Bấm để hiển thị đáp án của đội thi đấu chọn",
        "Bấm để hiển thị đáp án đúng nhất",
        "Bấm để cập nhật điểm cho đội thi đấu"};
        #endregion      
        //int idPhase;


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
                    TimeSupport = ListContest.ElementAt(i).RequestTime;
                    Bonus = ListContest.ElementAt(i).Bonus;
                    ChallengeScore = ListContest.ElementAt(i).ChallengceScore;
                    NumofChallenge = ListContest.ElementAt(i).NumberChallenge;
                }
            }

            //get phase
            Phase.IDContest = iDContest;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseByIDContest(Phase);
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
                        team.lbl_TeamName.Text = ListPlayer.ElementAt(i).PlayerName;
                        team.lbl_TeamScore.Text = ListPlayer.ElementAt(i).PlayerScore.ToString();
                        team.lbl_CurrentPhase.Text = ListPhase[0].NamePhase;
                        team.lbl_Sequence.Text = ListPlayer.ElementAt(i).Sequence.ToString();
                        idPlayer = ListPlayer.ElementAt(i).IDPlayer;
                        
                        Record r = new Record(idPlayer, ListPhase[0].IDPhase, iDContest,AmountSteptoPass,AmountSteptofail);
                        records.Add(r);

                        flp_Team.Controls.Add(team);
                    }
                }
            }
        }
        public void LoadForm()
        {
            this.Dock = DockStyle.Fill;
            GetContestContent();
        }
        private void Open_Game_Load(object sender, EventArgs e)
        {
            LoadForm(); 
            lblHint.Text = guideline[0].ToString();
        }
        
        //load Map
        public void loadMap()
        {
            audience.Show();
            if (team == records.Count)
            {
                team = 0;
            }
            //show all team on controller screen
            foreach (Team teamControllerScreen in flp_Team.Controls)
            {
                teamControllerScreen.BackColor = Color.Gainsboro;
                teamControllerScreen.flp_Answer.Controls.Clear();
            }
            //show lanes in audience screen
            foreach (Player_Lane1 playerLane in audience.pnl_Lane.Controls)
            {
                playerLane.pb_Team.BackColor = Color.FromArgb(colorplayer(Convert.ToInt32(playerLane.lbl_IDPlayer.Text)));
                playerLane.HighLight(false);
            }
            //show player information on audience screen
            foreach (Team_AudienceScreeen teamAdienceScreen in audience.flp_Team.Controls)
            {
                    teamAdienceScreen.HighLight(false);
            }
            //Clear panel
            audience.flp_AnswerQuiz.Controls.Clear();
            audience.richTextBox1.Text = "";
            //move to next step
            step++;
        }
        // Go player will compete
        public void GoPlayer()
        {
            //show on game controller screen
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) ==  sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    item.BackColor = Color.LightPink;
                    item.Enabled = true;
                }else
	            {
                    item.Enabled = false;
	            }
            }
            
            //show player lane on audience screen
            foreach (Player_Lane1 item in audience.pnl_Lane.Controls)
            {
                if (Convert.ToInt32(item.lbl_SequencePlayer.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    item.HighLight(true);
                    if (records.ElementAt(team).NumPass  == AmountSteptoPass && records.ElementAt(team).NumFail == AmountSteptofail)
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
            }
            
            //move to next step
            step++;
        }
        //Show question Answer
        public void ShowQuestion()
        {
            List<Phase> ListPhase;
            List<Question> ListQuestion;
            List<Answer> ListAnswer;
            int idquestion= 0;
            int a = 65;

            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    Phase.IDPhase = records.ElementAt(team).IDPhase;
                }
            }
            //get list question in phase
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
                        typequestion = ListQuestion.ElementAt(0).TypeQuestion.ToLower();

                        /////question is onechoice type
                        if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                ShowAnswer ShowAnswer = new ShowAnswer();
                                ShowAnswer.Size = new System.Drawing.Size(audience.flp_AnswerQuiz.Width / 2-10, audience.flp_AnswerQuiz.Height / 2-10);
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
                                    ShowAnswer.Size = new System.Drawing.Size(audience.flp_AnswerQuiz.Width / 2 - 10, audience.flp_AnswerQuiz.Height / 2 -10);
                                    ShowAnswer.chk1.Visible = true;
                                    ShowAnswer.chk1.Text = Convert.ToChar(a + h).ToString();
                                    ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                    ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                    audience.flp_AnswerQuiz.Controls.Add(ShowAnswer);
                                }
                            }
                            else
                            {

                            }
                        }
                        //update 
                        Phase.IDQuestion = idquestion;
                        //PhaseQuestionBl.EditQuestionStatus(Phase);
                        step++;
                    }

                    /////show answer one on control screen
                    foreach (Team item in flp_Team.Controls)
                    {
                        if (Convert.ToInt32(item.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                        {
                            if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                            {
                                for (int h = 0; h < ListAnswer.Count; h++)
                                {
                                    onechoice one = new onechoice();
                                    one.radioButton1.Text = Convert.ToChar(a + h).ToString();
                                    item.flp_Answer.Controls.Add(one);
                                }
                            }
                            else
                            {
                                if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "multichoice")
                                {
                                    for (int h = 0; h < ListAnswer.Count; h++)
                                    {
                                        multichoice multi = new multichoice();
                                        multi.checkBox1.Text = Convert.ToChar(a + h).ToString();
                                        item.flp_Answer.Controls.Add(multi);
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
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
                    MessageBox.Show("Out of Question");
                }
            } 
        }
        //Show Correct Answer
        public void EnterAnswer()
        {
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                {
                    if (typequestion == "onechoice")
                    {
                        foreach (ShowAnswer item1 in audience.flp_AnswerQuiz.Controls)
                        {
                            foreach (onechoice item2 in item.flp_Answer.Controls)
                            {
                                if (item2.radioButton1.Checked == true)
                                {
                                    if (item2.radioButton1.Text == item1.rdb1.Text)
                                    {
                                        item1.rdb1.Checked = true;
                                        item1.BackColor = Color.Blue;
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
                            foreach (ShowAnswer item1 in audience.flp_AnswerQuiz.Controls)
                            {
                                foreach (multichoice item2 in item.flp_Answer.Controls)
                                {
                                    if (item2.checkBox1.Checked == true)
                                    {
                                        if (item2.checkBox1.Text == item1.chk1.Text)
                                        {
                                            item1.chk1.Checked = true;
                                            item1.BackColor = Color.Blue;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                }
            }
            step++;
        }
        //show correct answer
        int CorrectAnswer ;
        int PlayerCheck ;
        public void ShowCorrectAnswer()
        {
            //show correct answer
            foreach (ShowAnswer item in audience.flp_AnswerQuiz.Controls)
            {
                if (item.lbl_Correct.Text.ToLower() == "true")
                {
                    item.BackColor = Color.LightGreen;
                    CorrectAnswer++;
                }
                if (item.chk1.Checked == true)
                {
                    if (item.lbl_Correct.Text.ToLower() == "true")
                    {
                        PlayerCheck++;
                    }
                }
                if (item.rdb1.Checked == true)
                {
                    if (item.lbl_Correct.Text.ToLower() == "true")
                    {
                        PlayerCheck++;
                    }
                }
            }
            step++;
        }
        //Update point for player
        public void CalculteScore()
        {
            if (PlayerCheck == CorrectAnswer)
            {
                int score = 0;
                records.ElementAt(team).NumPass -= 1;
                //update team score on controller screen
                foreach (Team item in flp_Team.Controls)
                {
                    if (Convert.ToInt32(item.lbl_Sequence.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                    {
                        score = ScoreofPhase(records.ElementAt(team).IDPhase);
                        item.lbl_TeamScore.Text = (Convert.ToInt32(item.lbl_TeamScore.Text) + score).ToString();
                    }
                }
                //Update team location in lane on audience screen
                foreach (Player_Lane1 item in audience.pnl_Lane.Controls)
                {
                    if (Convert.ToInt32(item.lbl_SequencePlayer.Text) == sequenceplayer(records.ElementAt(team).IDPlayer))
                    {
                        item.pb_Team.Location = new Point(item.pb_Team.Location.X + 0, item.pb_Team.Location.Y - 50);
                    }
                }
                //Update team information in audience screen 
                foreach (Team_AudienceScreeen teamAudienceScreen in audience.flp_Team.Controls)
                {
                    if (Convert.ToInt32(teamAudienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                    {
                        teamAudienceScreen.lbl_TeamScore.Text = (Convert.ToInt32(teamAudienceScreen.lbl_TeamScore.Text) + score).ToString();
                    }
                }     
                ////update log
                //NumTrue = NumT(idpla)-1;

                //if (NumTrue == 0)
                //{
                //    Log.PlayerID = idpla;
                //    Log.PlayerScore = ScoreofPlayer(idpla) + score;
                //    Log.CurrentNumofTrue = AmountSteptoPass;
                //    Log.CurrentNumofFalse = AmountSteptofail;
                //    //get current sequence of phase

                //    Log.PhaseID = IDofPhase(iDContest,SeqPhase+1);
                //    logBL.EditLogbyIDPlayer(Log);
                //}
                //else
                //{
                //    Log.PlayerID = idpla;
                //    Log.CurrentNumofTrue = NumTrue;
                //    Log.PlayerScore = ScoreofPlayer(idpla)+ score;
                //    logBL.EditLogbyIDPlayer(Log);
                //}

            }
            else
            {
                records.ElementAt(team).NumFail -= 1;
                foreach (Team_AudienceScreeen teamAudienceScreen in audience.flp_Team.Controls)
                {
                    if (Convert.ToInt32(teamAudienceScreen.lbl_ID.Text) == records.ElementAt(team).IDPlayer)
                    {
                        if (records.ElementAt(team).NumFail ==1)
                        {
                            teamAudienceScreen.pb_Heart2.Hide();
                        }
                        else
                        {
                            if (records.ElementAt(team).NumFail ==2)
                            {
                                teamAudienceScreen.pb_Heart3.Hide();
                            }
                            else
                            {
                                teamAudienceScreen.pb_Heart1.Hide();
                            }
                        }
                    }
                } 
            }
            //move to another player
            CorrectAnswer =0;
            PlayerCheck = 0;
            team++;
            step = 1;
        }
        //Get point for phase by id contest and sequence of phase
        public int ScoreofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).ScorePhase;
        }
        //Get time of phase
        public int TimeofPhase(int idpha)
        {
            List<Phase> ListPhase;
            Phase.IDPhase = idpha;
            ListPhase = PhaseBL.GetPhaseByIDPhase(Phase);
            return ListPhase.ElementAt(0).TimePhase;
        }
        //Get id of phase by id contest and sequence of phase
        public int IDofPhase(int idCon, int Seq)
        {
            List<Phase> ListPhase;
            Phase.IDContest = idCon;
            Phase.Sequence = Seq;
            ListPhase = PhaseBL.GetPhaseByIDContestSequence(Phase);
            return ListPhase.ElementAt(0).IDPhase;
        }
        //get position of player
        public int PlayerPosition(int idCon, int idPla)
        {
            int position = 0;
            List<Log> ListLog;
            Log.ContestID = idCon;
            ListLog = logBL.GetLogByIdContest(Log);
            if (ListLog!= null)
            {
                for (int i = 0; i < ListLog.Count; i++)
                {
                    if (ListLog.ElementAt(i).PlayerID == idPla)
                    {
                        position = ListLog.ElementAt(i).PhaseID;
                    }
                }
            }
            return position;
        }
        //get sequence of phase
        public int SequencePhase(int idPha)
        {
            int sequence = 0;
            Phase.IDPhase = idPha;
            List<Phase> Listphase;
            Listphase = PhaseBL.GetPhaseByIDPhase(Phase);
            if (Listphase!= null)
            {
                for (int i = 0; i < Listphase.Count; i++)
                {
                    sequence = Listphase.ElementAt(i).Sequence;
                }
            }
            return sequence;
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
        //get number of true from player
        public int NumT(int idPla)
        {
            int NumTrue = 0;
            List<Log> ListLog ;
            Log.PlayerID = idPla;
            ListLog= logBL.GetLogByIdPlayer(Log);
            if (ListLog!= null)
            {
                for (int i = 0; i < ListLog.Count; i++)
                {
                    NumTrue = ListLog.ElementAt(i).CurrentNumofTrue;
                    MessageBox.Show("" + ListLog.ElementAt(i).CurrentNumofTrue);
                }
            }
            return NumTrue;
        }
        //get number of true from player
        public int NumF(int idPla)
        {
            List<Log> ListLog;
            Log.PlayerID = idPla;
            ListLog = logBL.GetLogByIdPlayer(Log);
            return ListLog.ElementAt(0).CurrentNumofFalse;
        }
        //get point from player
        public int ScoreofPlayer(int idPla)
        {
            List<Log> ListLog;
            Log.PlayerID = idPla;
            ListLog = logBL.GetLogByIdPlayer(Log);
            return ListLog.ElementAt(0).PlayerScore;
        }
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
            else if (step ==6)
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
            } 
        }
        //Click play to execute game
        private void pb_Play_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}

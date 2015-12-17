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

        string typequestion = "";
        int step = 1;
        int team = 1;
        int idPhase;
        Run_Game Rungame = new Run_Game();
        List<int> PlayerNO = new List<int>();

        //get contest content
        public void GetContestContent()
        {
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
        }
        //get Player content
        public void GetPlayer()
        {
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
                        team.lbl_Sequence.Text = ListPlayer.ElementAt(i).Sequence.ToString();
                        team.lbl_TeamID.Text = ListPlayer.ElementAt(i).IDPlayer.ToString();

                        Log.ContestID = iDContest;
                        Log.PlayerID = ListPlayer.ElementAt(i).IDPlayer;
                        Log.PlayerScore = ListPlayer.ElementAt(i).PlayerScore;
                        Log.CurrentNumofTrue = AmountSteptoPass;
                        Log.CurrentNumofFalse = AmountSteptofail;
                        Log.Check = 1;
                        logBL.AddLog(Log);

                        flp_Team.Controls.Add(team);
                    }
                }
            }
        }
        //Get phase content
        public void GetPhase()
        {
            Phase.IDContest = iDContest;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseByIDContest(Phase);
            AmountPhase = ListPhase.Count;
            if (ListPhase != null)
            {
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    if (ListPhase.ElementAt(i).Sequence == 1)
                    {
                        foreach (Team item in flp_Team.Controls)
                        {
                            item.lbl_CurrentPhase.Text = ListPhase.ElementAt(i).NamePhase; 
                        }
                        Log.ContestID = iDContest;
                        Log.PhaseID = ListPhase.ElementAt(i).IDPhase;
                        logBL.UpdatePhase(Log);
                    }
                }
            }
        }
        //record
        public void LoadForm()
        {
            this.Dock = DockStyle.Fill;
            GetContestContent();
            GetPlayer();
            GetPhase();
        }
        private void Open_Game_Load(object sender, EventArgs e)
        {
            LoadForm(); 
        }
        //exit form
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //show game
        private void btn_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        
        //load Map
        public void loadMap()
        {
            Rungame.Show();
            foreach (Player_Lane item in Rungame.pnl_GameMap.Controls)
            {
                item.BackColor = Color.Tan;
            }

            foreach (Team item in flp_Team.Controls)
            {
                    item.BackColor = Color.White;
                    item.textBox1.Text = "";
            }
            Rungame.flp_AnswerContent.Controls.Clear();
            Rungame.rtxt_QuestionContent.Text = "";
            step++;
        }
        // Go player
        public void GoPlayer()
        {
            Rungame.Show();
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) == team)
                {
                    item.BackColor = Color.Yellow;
                    item.Enabled = true;
                }else
	            {
                    item.Enabled = false;
	            }
            }

            foreach (Player_Lane item in Rungame.pnl_GameMap.Controls)
            {
                if (Convert.ToInt32(item.lbl_SequencePlayer.Text) == team)
                {
                    item.BackColor = Color.Yellow;
                }
            }
            
            Rungame.Show();
            step++;
        }
        //Show question Answer
        public void ShowQuestion()
        {
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) == team)
                {
                    Phase.Sequence = SequencePhase(PlayerPosition(iDContest,Convert.ToInt32(item.lbl_TeamID.Text)));
                }
            }
            Phase.IDContest = iDContest;

            List<Phase> ListPhase;
            List<Question> ListQuestion;
            List<Answer> ListAnswer;

            ListPhase = PhaseBL.GetPhaseByIDContestSequence(Phase);
            for (int i = 0; i < ListPhase.Count; i++)
            {
                idPhase = ListPhase.ElementAt(i).IDPhase;
            }

            Phase.IDPhase = idPhase;
            ListPhase = PhaseQuestionBl.getquestionRunGame(Phase);

            if (ListPhase != null)
            { 
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    listIDQuestion.Add(ListPhase.ElementAt(i).IDQuestion);
                }
            }

            //show question
            int a = 65;
            
            for (int i = 0; i < listIDQuestion.Count; i++)
            {
                if (i == 0)
                {
                    Question.IDQuestion = listIDQuestion.ElementAt(i);
                    Phase.IDQuestion = listIDQuestion.ElementAt(i);
                    Phase.IDPhase = idPhase;
                    ListQuestion = QuestionBL.GetQuestionByID(Question);
                    ListAnswer = QuestionBL.GetAnswerByQuestionID(Question);
                    if (ListQuestion != null)
                    {
                        Rungame.rtxt_QuestionContent.Text = ListQuestion.ElementAt(i).NameQuestion;
                        typequestion = ListQuestion.ElementAt(i).TypeQuestion.ToLower();
                        if (ListQuestion.ElementAt(i).TypeQuestion.ToLower() == "onechoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                ShowAnswer ShowAnswer = new ShowAnswer();
                                ShowAnswer.rdb1.Visible = true;
                                ShowAnswer.rdb1.Text = Convert.ToChar(a + h).ToString();
                                ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                Rungame.flp_AnswerContent.Controls.Add(ShowAnswer);
                            }
                        }
                        else
                        {
                            if (ListQuestion.ElementAt(i).TypeQuestion.ToLower() == "multichoice")
                            {
                                for (int h = 0; h < ListAnswer.Count; h++)
                                {
                                    ShowAnswer ShowAnswer = new ShowAnswer();
                                    ShowAnswer.chk1.Visible = true;
                                    ShowAnswer.chk1.Text = Convert.ToChar(a + h).ToString();
                                    ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                    ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                    Rungame.flp_AnswerContent.Controls.Add(ShowAnswer);
                                }
                            }
                            else
                            {

                            }
                            
                        }
                        PhaseQuestionBl.EditQuestionStatus(Phase);
                        listIDQuestion.RemoveAt(i);
                        step++;
                    }
                }
            }
            //show countdown time
            label1.Text = "90";
            timer1.Interval = 1000;
            timer1.Start();

            Rungame.label1.Text = "90";
            Rungame.timer1.Interval = 1000;
            Rungame.timer1.Start();
        }
        //Show Correct Answer
        public void EnterAnswer()
        {
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text) == team && item.textBox1.Text.Trim()!= "")
                {
                    if (typequestion == "onechoice")
                    {
                        MessageBox.Show("");
                        foreach (ShowAnswer item1 in Rungame.flp_AnswerContent.Controls)
                        {
                            if (item1.rdb1.Text  == item.textBox1.Text.Trim().ToUpper())
                            {
                                MessageBox.Show("");
                                item1.BackColor = Color.Yellow;
                                item1.rdb1.Checked = true;
                            }
                        }
                    }
                    else
                    {
                        if (typequestion == "multichoice")
                        {
                            string[] multianswer;
                            multianswer = item.textBox1.Text.Trim().Split(',');
                            foreach (ShowAnswer item1 in Rungame.flp_AnswerContent.Controls)
                            {
                                for (int i = 0; i < multianswer.Length; i++)
                                {
                                    if (item1.chk1.Text == multianswer[i].ToString())
                                    {
                                        item1.BackColor = Color.Yellow;
                                        item1.chk1.Checked = true;
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
        public void ShowCorrectAnswer()
        {
            int NumCorrectAnswer=0;
            int NumCheck = 0;
            //show correct answer
            foreach (ShowAnswer item in Rungame.flp_AnswerContent.Controls)
            {
                if (item.lbl_Correct.Text.ToLower() == "true")
                {
                    item.BackColor = Color.Green;
                    NumCorrectAnswer++;
                }
                if (item.chk1.Checked == true)
                {
                    if (item.lbl_Correct.Text.ToLower() == "true")
                    {
                        NumCheck++;
                    }
                }
                if (item.rdb1.Checked == true)
                {
                    if (item.lbl_Correct.Text.ToLower() == "true")
                    {
                        NumCheck++;
                    }
                }
            }
            //check answer to calculate point
            if (NumCheck == NumCorrectAnswer)
            {
                int score = 0;
                int idpla = 0;
                int NumTrue;
                foreach (Team item in flp_Team.Controls)
                {
                    if (Convert.ToInt32(item.lbl_Sequence.Text) == team)
                    {
                        score = ScoreofPhase(iDContest, SequencePhase(PlayerPosition(iDContest, Convert.ToInt32(item.lbl_TeamID.Text))));
                        idpla = Convert.ToInt32(item.lbl_TeamID.Text);
                    }
                }
                //update log
                NumTrue = NumT(idpla)-1;

                if (NumTrue == 0)
                {

                }
                else
                {
                    Log.PlayerID = idpla;
                    Log.CurrentNumofTrue = NumTrue;
                    logBL.EditLogbyIDPlayer(Log);
                }
                //update GUI
                foreach (Team item in flp_Team.Controls)
                {
                    if (Convert.ToInt32(item.lbl_Sequence.Text) == team)
                    {
                        item.lbl_TeamScore.Text = (Convert.ToInt32(item.lbl_TeamScore.Text) + score).ToString();
                    }
                }

                foreach (Player_Lane item in Rungame.pnl_GameMap.Controls)
                {
                    if (Convert.ToInt32(item.lbl_SequencePlayer.Text) == team)
                    {
                        item.txt_Point.Text = (Convert.ToInt32(item.txt_Point.Text) + score).ToString();
                    }
                }
            }
            else
            {

            }

            //move to another player
            if (team == AmountPlayer)
            {
                team = 1;
            }
            else
            {
                team++;
                step = 1;
            }
        }

        //Get point for phase
        public int ScoreofPhase(int idCon, int Seq)
        {
            List<Phase> ListPhase;
            Phase.IDContest = idCon;
            Phase.Sequence = Seq;
            ListPhase = PhaseBL.GetPhaseByIDContestSequence(Phase);
            return ListPhase.ElementAt(0).ScorePhase;
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
        //Get player id form sequence
        public int idplayer(int Seq)
        {
            int idPla = 0;
            foreach (Team item in flp_Team.Controls)
            {
                if (Convert.ToInt32(item.lbl_Sequence.Text)==Seq)
                {
                    idPla = Convert.ToInt32(item.lbl_TeamID.Text);
                }
            }
            return idPla;
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
        //Calculate point
        public void CalculatePoint()
        {

        }

        //Get sequence player
        public int SequencePlayer()
        {
            return 0;
        }
        public void StartGame()
        {
            Rungame.IdContest = iDContest;
            if (step ==1)
            {
                loadMap();
            }
            else if (step == 2)
            {
                GoPlayer();
            }
            else if (step ==3)
            {
                ShowQuestion();
            }
            else if (step ==4)
            {
                EnterAnswer();
            }
            else if (step ==5)
            {
                ShowCorrectAnswer();
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) - 1).ToString(); //lowering the value - explained above
            if (int.Parse(label1.Text) == 0)  //if the countdown reaches '0', we stop it
                timer1.Stop();
        }
    }
}

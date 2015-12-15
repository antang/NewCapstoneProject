using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class Open_Game : Form
    {
        public Open_Game()
        {
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

        PlayerBL PlayerBL = new PlayerBL();
        ContestBL ContestBL = new ContestBL();
        PhaseBL PhaseBL = new PhaseBL();
        PhaseQuestionBL PhaseQuestionBl = new PhaseQuestionBL();
        QuestionBL QuestionBL = new QuestionBL();


        List<int> list = new List<int>();
        int AmountPlayer;
        int AutoShowQuestion;
        int AutoShowAnswer;
        int AmountSteptoPass;
        int AmountSteptofail;
        int TimeSupport;
        int Bonus;
        int ChallengeScore;
        int NumofChallenge;
        private void Open_Game_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //flp_Team.Controls.Clear();
            //get contest
            Contest.IDContest = iDContest;
            List<Contest> ListContest;
            ListContest = ContestBL.GetContestByID(Contest);
            if (ListContest != null)
            {
                for (int i = 0; i <ListContest.Count; i++)
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

            //get Player by id contest
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
                            flp_Team.Controls.Add(team);
                    }
                }
            }

            //get phase by contest id
            Phase.IDContest = iDContest;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseByIDContest(Phase);
            if (ListPhase != null)
            {
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    if (ListPhase.ElementAt(i).Sequence==1)
                    {
                        foreach (Team item in flp_Team.Controls)
                        {
                            item.lbl_CurrentPhase.Text = ListPhase.ElementAt(i).NamePhase;
                        }
                    }
                }
            }
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
        int step = 1;
        int team = 1;

        int idPhase;
        Run_Game Rungame = new Run_Game();
        public void StartGame()
        {
            
            Rungame.IdContest = iDContest;
            if (step ==1)
            {
                Rungame.Show();
                foreach (Player_Lane item in Rungame.pnl_GameMap.Controls)
                {   
                        item.BackColor = Color.Tan;

                }
                step++;
            }
            else if (step == 2)
            {
                Rungame.Show();
                foreach (Player_Lane item in Rungame.pnl_GameMap.Controls)
                {
                    if (Convert.ToInt32(item.lbl_IDPlayer.Text) == team)
                    {
                        item.BackColor = Color.Yellow; 
                    }
                }
                if (team == AmountPlayer)
                {
                    team=1;
                }
                Rungame.Show();
                step++;
            }
            else if (step ==3)
            {
                
                Phase.IDContest = iDContest;
                Phase.Sequence = 1;
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
                        list.Add(ListPhase.ElementAt(i).IDQuestion);
                    }
                }
                //show question
                int a = 65;
                for (int i = 0; i < list.Count; i++)
                {
                    MessageBox.Show("" + list.Count);
                    if (i==0)
                    {
                        Question.IDQuestion = list.ElementAt(i);
                        Phase.IDQuestion = list.ElementAt(i);
                        Phase.IDPhase = idPhase;
                        ListQuestion = QuestionBL.GetQuestionByID(Question);
                        ListAnswer = QuestionBL.GetAnswerByQuestionID(Question);
                        if (ListQuestion != null)
                        { 
                            Rungame.rtxt_QuestionContent.Text = ListQuestion.ElementAt(i).NameQuestion;
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                ShowAnswer ShowAnswer = new ShowAnswer();
                                ShowAnswer.lbl_Answer.Text = Convert.ToChar(a + h).ToString() + "/ ";
                                ShowAnswer.rtxt_Answer.Text = ListAnswer.ElementAt(h).ContentAnswer;
                                ShowAnswer.lbl_Correct.Text = ListAnswer.ElementAt(h).IsCorrect.ToString();
                                Rungame.flp_AnswerContent.Controls.Add(ShowAnswer);
                            }
                            PhaseQuestionBl.EditQuestionStatus(Phase);
                            list.RemoveAt(i);
                            step ++;
                        }
                    }
                }
            }
            else if (step ==4)
            {
                foreach (ShowAnswer item in Rungame.flp_AnswerContent.Controls)
                {
                    if (item.lbl_Correct.Text.ToLower()== "true")
                    {
                        item.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            //Run_Game Rungame = new Run_Game();
            //
        }
    }
}

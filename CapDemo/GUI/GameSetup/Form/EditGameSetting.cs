using CapDemo.BL;
using CapDemo.DO;
using CapDemo.GUI.User_Controls;
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
    public partial class EditGameSetting : Form
    {
        private int IdContest;

        public EditGameSetting()
        {
            InitializeComponent();
        }

        public EditGameSetting(int pIdContest)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IdContest = pIdContest;
        }

        private void EditGameSetting_Load(object sender, EventArgs e)
        {
            LoadSetting();
            LoadPhase();
            
        }
        public void LoadSetting()
        {
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();


            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).IDContest == IdContest)
                    {
                        //General Setting
                        txt_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        txt_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        txt_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        txt_TimeQuestion.Text = ListContest.ElementAt(i).TimeShowQuestion.ToString();
                        txt_TimeAnswer.Text = ListContest.ElementAt(i).TimeShowAnswer.ToString();
                        txt_Bonus.Text = ListContest.ElementAt(i).Bonus.ToString();
                        txt_NumStepPass.Text = ListContest.ElementAt(i).TimesTrue.ToString();
                        txt_NumStepFail.Text = ListContest.ElementAt(i).TimesFalse.ToString();
                        //Competition Setting
                        txt_TimeForSupport.Text = ListContest.ElementAt(i).RequestTime.ToString();
                        txt_ChallengeScore.Text = ListContest.ElementAt(i).ChallengceScore.ToString();
                        txt_NumTeam.Text = ListContest.ElementAt(i).NumberChallenge.ToString();
                    }
                }
            }
        }

        public void LoadPhase()
        {
            PhaseBL PhaseBL = new PhaseBL();
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhase();

            if (ListPhase != null)
            {
                int No = 0;
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    if (ListPhase.ElementAt(i).IDContest == IdContest)
                    {
                        No++;
                        Add_Phase AddPhase = new Add_Phase();
                        //AddPhase.cmb_Catalogue.SelectedItem = ListPhase.ElementAt(i).NamePhase;
                        AddPhase.txt_PhaseName.Text = ListPhase.ElementAt(i).NamePhase;
                        AddPhase.txt_Time.Text = ListPhase.ElementAt(i).TimePhase.ToString();
                        AddPhase.txt_Score.Text = ListPhase.ElementAt(i).ScorePhase.ToString();
                        AddPhase.txt_Minus.Text = ListPhase.ElementAt(i).MinusPhase.ToString();
                        AddPhase.txt_Sequence.Text = (No).ToString();
                        AddPhase.btn_Delete.Visible = false;

                        flp_Phase.Controls.Add(AddPhase);
                    }
                }

            }
        }

        //load team
        public void LoadTeam()
        {
            PlayerBL PlayerBL = new PlayerBL();
            List<Player> ListPlayer;
            ListPlayer = PlayerBL.GetPlayer();

            if (ListPlayer != null)
            {
                int No = 0;
                for (int i = 0; i < ListPlayer.Count; i++)
                {
                    if (ListPlayer.ElementAt(i).IDContest == IdContest)
                    {
                        No++;
                        Add_Team AddTeam = new Add_Team();
                        AddTeam.txt_TeamName.Text = ListPlayer.ElementAt(i).PlayerName;
                        AddTeam.txt_TeamScore.Text = ListPlayer.ElementAt(i).PlayerScore.ToString();
                        //AddTeam.txt_Score.Text = ListPlayer.ElementAt(i).ScorePhase.ToString();
                        //AddTeam.txt_Minus.Text = ListPlayer.ElementAt(i).MinusPhase.ToString();
                        //AddTeam.lbl_Number.Text = (No).ToString();
                        //AddTeam.btn_Delete.Visible = false;

                        //flp_Phase.Controls.Add(AddPhase);
                    }
                }

            }
        }
    }
}

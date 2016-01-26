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
using System.Threading;
using System.IO;

namespace CapDemo
{
    public partial class Audience_Screen : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public Audience_Screen()
        {
            
            InitializeComponent();
            
        }
        public void SpashStart()
        {
            Application.Run(new PleaseWaitForm());
        }

        int idContest;

        public int IdContest
        {
            get { return idContest; }
            set { idContest = value; }
        }
        //DO
        Contest contest = new Contest();
        Phase phase = new Phase();
        Player player = new Player();
        //BL
        ContestBL contestBL = new ContestBL();
        PlayerBL playerBL = new PlayerBL();
        PhaseBL phaseBL = new PhaseBL();
        //Contest Info
        int NumStep;
        int NumLife;


        int H_PlayerLane;
        int W_PlayerLane;
        int H_PhaseLane;
        int W_PhaseLane;

        int H_FinishLocation;
        int H_PlayerLocation;
        int H_player;

        private void Audience_Screen_Load(object sender, EventArgs e)
        {

            this.Hide();
            Thread t = new Thread(new ThreadStart(SpashStart));
            t.Start();
            Thread.Sleep(5000);
            this.SuspendLayout();
            //this.Hide();
            this.Dock = DockStyle.Fill;
            
            tbc_ShowGame.Appearance = TabAppearance.FlatButtons;
            tbc_ShowGame.ItemSize = new Size(0, 1);
            tbc_ShowGame.SizeMode = TabSizeMode.Fixed;

            H_PlayerLane = pnl_Lane.Height;
            W_PlayerLane = pnl_Lane.Width;
            H_PhaseLane = pnl_Phase.Height;
            W_PhaseLane = pnl_Phase.Width;


            contest.IDContest = idContest;
            phase.IDContest = idContest;
            player.IDContest = idContest;

            List<Contest> listContest;
            List<Contest> ListContestHaveRound;
            List<Phase> listPhase;
            List<Player> listPlayer;

            listContest = contestBL.GetContestByID(contest);
            listPhase = phaseBL.GetPhaseNormal(phase);
            listPlayer = playerBL.GetPlayerByIDContest(player);
            ListContestHaveRound = contestBL.GetRoundByIDContest(contest);
            lbl_Round.Text = ListContestHaveRound.ElementAt(0).Round.NameRound;
            
            //get element in contest
            if (listContest != null)
            {
                for (int i = 0; i < listContest.Count; i++)
                {
                    NumStep = listContest.ElementAt(i).TimesTrue;
                    NumLife = listContest.ElementAt(i).TimesFalse;
                }
            }
            
            
            if (listPlayer != null)
            {   
                //draw player lane
                for (int i = 0; i < listPlayer.Count; i++)
                {
                    Player_Lane1 PlayerLane = new Player_Lane1();
                    PlayerLane.Size = new System.Drawing.Size(W_PlayerLane / listPlayer.Count, H_PlayerLane);
                    PlayerLane.Location = new Point(PlayerLane.Location.X + (W_PlayerLane / listPlayer.Count *i), PlayerLane.Location.Y + 0);
                    PlayerLane.lbl_SequencePlayer.Text = listPlayer.ElementAt(i).Sequence.ToString();
                    PlayerLane.btn_Team.BackColor = Color.FromArgb(Convert.ToInt32(listPlayer.ElementAt(i).Color));
                    PlayerLane.lbl_IDPlayer.Text = listPlayer.ElementAt(i).IDPlayer.ToString();
                    PlayerLane.lbl_Finish.Size = new System.Drawing.Size(W_PlayerLane / listPlayer.Count, PlayerLane.lbl_Finish.Height);

                    //get boundary to drwaw phase
                    H_FinishLocation = PlayerLane.lbl_Finish.Location.Y + PlayerLane.lbl_Finish.Height;
                    H_PlayerLocation = PlayerLane.btn_Team.Location.Y;
                    H_player = PlayerLane.btn_Team.Height;

                    int H_BoundaryPlayerLane = 0;
                    H_BoundaryPlayerLane = H_PlayerLane - (H_FinishLocation + H_player);
                    for (int j = 0; j < listPhase.Count * NumStep; j++)
                    {
                        Phase_Lane PhaseLane = new Phase_Lane();
                        PhaseLane.Size = new System.Drawing.Size(W_PlayerLane / listPlayer.Count, H_BoundaryPlayerLane / listPhase.Count / NumStep);
                        PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + (H_PlayerLocation - (H_BoundaryPlayerLane / listPhase.Count) * (j + 1) / NumStep));
                        PhaseLane.BorderStyle = BorderStyle.FixedSingle;
                        //PhaseLane.BackgroundImage = Properties.Resources.arrow_up;
                        PhaseLane.BackColor = Color.Transparent;
                        //PhaseLane.BackgroundImageLayout = ImageLayout.Zoom;
                        PhaseLane.lbl_NamePhase.Size = new System.Drawing.Size(W_PlayerLane / listPlayer.Count, H_BoundaryPlayerLane / listPhase.Count / NumStep - 2);
                        PhaseLane.lbl_NamePhase.Text = "";
                        PhaseLane.lbl_NamePhase.BackColor = Color.Transparent;
                        PlayerLane.Controls.Add(PhaseLane);
                    } 
                    pnl_Lane.Controls.Add(PlayerLane);
                }
                //draw pm
                this.btn_PM.Text = "V\nE\nR\nT\nI\nC\nA\nL\n" +"(35)";

                //Draw Phase Lane
                //H_Boundary = H_PlayerLane - (H_FinishLocation) - H_player;
                //Phase.Size = new System.Drawing.Size(W_PhaseLane, H_PhaseLane);

                for (int i = 0; i < listPhase.Count; i++)
                {
                    Phase_Lane PhaseLane = new Phase_Lane();
                    PhaseLane.Size = new System.Drawing.Size(W_PhaseLane, (H_PhaseLane ) / listPhase.Count);
                    PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + pnl_Phase.Height - (H_PhaseLane / listPhase.Count) * (i + 1));
                    PhaseLane.BorderStyle = BorderStyle.FixedSingle;
                    PhaseLane.BackgroundImage = Properties.Resources.Phase;
                    PhaseLane.BackgroundImageLayout = ImageLayout.Stretch;
                    PhaseLane.lbl_NamePhase.Size = new System.Drawing.Size(W_PhaseLane, H_PhaseLane / listPhase.Count);
                    PhaseLane.lbl_NamePhase.Text = listPhase.ElementAt(i).NamePhase;
                    pnl_Phase.Controls.Add(PhaseLane);
                }
                
                //add player information
                for (int i = 0; i < listPlayer.Count; i++)
                {
                    Team_AudienceScreeen team_AudienceScreen = new Team_AudienceScreeen();
                    team_AudienceScreen.pb_TeamShirt.BackColor = Color.FromArgb(Convert.ToInt32(listPlayer.ElementAt(i).Color));
                    team_AudienceScreen.lbl_TeamName.Text = listPlayer.ElementAt(i).PlayerName;
                    team_AudienceScreen.lbl_TeamScore.Text = listPlayer.ElementAt(i).PlayerScore.ToString();
                    team_AudienceScreen.lbl_ID.Text = listPlayer.ElementAt(i).IDPlayer.ToString();
                    if (NumLife == 1)
                    {
                        team_AudienceScreen.pb_Heart1.Show();
                        team_AudienceScreen.pb_Heart2.Hide();
                        team_AudienceScreen.pb_Heart3.Hide();
                    }
                    else
                    {
                        if (NumLife == 2)
                        {
                            team_AudienceScreen.pb_Heart1.Show();
                            team_AudienceScreen.pb_Heart2.Show();
                            team_AudienceScreen.pb_Heart3.Hide();
                        }
                        else
                        {
                            if (NumLife == 3)
                            {
                                team_AudienceScreen.pb_Heart1.Show();
                                team_AudienceScreen.pb_Heart2.Show();
                                team_AudienceScreen.pb_Heart3.Show();
                            }
                            else
                            {
                                team_AudienceScreen.pb_Heart1.Hide();
                                team_AudienceScreen.pb_Heart2.Hide();
                                team_AudienceScreen.pb_Heart3.Hide();
                            }
                        }

                    }
                    flp_Team.Controls.Add(team_AudienceScreen);
                }
            }
            
            t.Abort();
            this.Show();
            this.ResumeLayout();
            
            
        }
        //int timeShowQuestion;
        double count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarControl1.ForeColor = Color.Yellow;
            count += timer1.Interval;
            progressBarControl1.Value -= timer1.Interval;

            if (count % 900 == 0)
            {
                //prgb_Question.Increment(1);
                lbl_TimeShowQuestion.Text = (int.Parse(lbl_TimeShowQuestion.Text) - 1).ToString();
                if (int.Parse(lbl_TimeShowQuestion.Text) <=5)
                {
                    progressBarControl1.ForeColor = Color.Red;
                }
                else
                {
                    progressBarControl1.ForeColor = Color.Yellow;
                }

                if (int.Parse(lbl_TimeShowQuestion.Text) == 0)
                {
                    timer1.Stop();
                    lbl_TimeShowQuestion.Image = null;
                }
            }
            
        }
        //drag form audience
        private void tbc_ShowGame_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void tbc_ShowGame_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void tbc_ShowGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        //text change
        private void lbl_QuestionContent_TextChanged(object sender, EventArgs e)
        {
            
           
        }

       
    }
}

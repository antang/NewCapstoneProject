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
    public partial class Audience_Screen : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public Audience_Screen()
        {
            InitializeComponent();
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

        int H_Boundary;
        int H_FinishLocation;
        int H_PlayerLocation;
        int H_player;

        
        
        private void Audience_Screen_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.Dock = DockStyle.Fill;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            H_PlayerLane = pnl_Lane.Height;
            W_PlayerLane = pnl_Lane.Width;
            H_PhaseLane = pnl_Phase.Height;
            W_PhaseLane = pnl_Phase.Width;


            contest.IDContest = idContest;
            phase.IDContest = idContest;
            player.IDContest = idContest;

            List<Contest> listContest;
            List<Phase> listPhase;
            List<Player> listPlayer;

            listContest = contestBL.GetContestByID(contest);
            listPhase = phaseBL.GetPhaseNormal(phase);
            listPlayer = playerBL.GetPlayerByIDContest(player);
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
                    PlayerLane.pb_Team.BackColor = Color.FromArgb(Convert.ToInt32(listPlayer.ElementAt(i).Color));
                    PlayerLane.lbl_IDPlayer.Text = listPlayer.ElementAt(i).IDPlayer.ToString();
                    PlayerLane.lbl_Finish.Size = new System.Drawing.Size(W_PlayerLane / listPlayer.Count, PlayerLane.lbl_Finish.Height);

                    //get boundary to drwaw phase
                    H_FinishLocation = PlayerLane.lbl_Finish.Location.Y + PlayerLane.lbl_Finish.Height;
                    H_PlayerLocation = PlayerLane.pb_Team.Location.Y;
                    H_player = PlayerLane.pb_Team.Height;

                    int H_BoundaryPlayerLane = 0;
                    H_BoundaryPlayerLane = H_PhaseLane - (H_FinishLocation + H_player);

                    for (int j = 0; j < listPhase.Count * NumStep; j++)
                    {
                        Phase_Lane PhaseLane = new Phase_Lane();
                        PhaseLane.Size = new System.Drawing.Size(W_PlayerLane, H_BoundaryPlayerLane / listPhase.Count / NumStep);
                        PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + (H_PlayerLocation - H_BoundaryPlayerLane / listPhase.Count * (j + 1) / NumStep)-2);
                        PhaseLane.BorderStyle = BorderStyle.FixedSingle;
                        PhaseLane.lbl_NamePhase.Size = new System.Drawing.Size(W_PlayerLane, H_BoundaryPlayerLane / listPhase.Count / NumStep -3 );
                        PhaseLane.lbl_NamePhase.Text = "";
                        PlayerLane.Controls.Add(PhaseLane);
                    } 
                    pnl_Lane.Controls.Add(PlayerLane);
                }


                //Draw Phase Lane
                PhaseLane1 Phase = new PhaseLane1();
                H_Boundary = H_PhaseLane - (H_FinishLocation + H_player);
                Phase.Size = new System.Drawing.Size(W_PhaseLane, H_PhaseLane);

                for (int i = 0; i < listPhase.Count; i++)
                {
                    Phase_Lane PhaseLane = new Phase_Lane();
                    PhaseLane.Size = new System.Drawing.Size(W_PhaseLane, H_Boundary / listPhase.Count);
                    PhaseLane.Location = new Point(PhaseLane.Location.X + 0, PhaseLane.Location.Y + (H_PlayerLocation - H_Boundary / listPhase.Count * (i + 1)));
                    PhaseLane.BorderStyle = BorderStyle.FixedSingle;
                    PhaseLane.lbl_NamePhase.Size = new System.Drawing.Size(W_PhaseLane, H_Boundary / listPhase.Count);
                    PhaseLane.lbl_NamePhase.Text = listPhase.ElementAt(i).NamePhase;
                    Phase.Controls.Add(PhaseLane);
                }
                pnl_Phase.Controls.Add(Phase);



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
                            team_AudienceScreen.pb_Heart1.Show();
                            team_AudienceScreen.pb_Heart2.Show();
                            team_AudienceScreen.pb_Heart3.Show();
                        }

                    }
                    flp_Team.Controls.Add(team_AudienceScreen);
                }
            }
            this.ResumeLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_TimeShowQuestion.Text = (int.Parse(lbl_TimeShowQuestion.Text) - 1).ToString();
            if (int.Parse(lbl_TimeShowQuestion.Text) == 0)
            {
                timer1.Stop();
                lbl_TimeShowQuestion.Image = null;
            }
                
        }

        private void flp_Finish_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void flp_Finish_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void flp_Finish_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove==1)
            {
                this.SetDesktopLocation(MousePosition.X -MValX, MousePosition.Y - MValY);
            }
        }
        bool max = true;
        private void flp_Finish_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (max==true)
            {
                this.WindowState = FormWindowState.Maximized;
                max = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                max = true;
            }
            
        }

    }
}

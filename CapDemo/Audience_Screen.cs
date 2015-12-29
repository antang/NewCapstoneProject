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


        int HeightPanel;
        int WidthPanel;

        
        private void Audience_Screen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            HeightPanel = pnl_Lane.Height;
            WidthPanel = pnl_Lane.Width;

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
            {   //Draw Player Lane
                for (int i = 0; i < listPlayer.Count; i++)
                {
                    Player_Lane1 PlayerLane = new Player_Lane1();
                    PlayerLane.Size = new System.Drawing.Size(WidthPanel / listPlayer.Count -10, HeightPanel);
                    PlayerLane.Location = new Point(PlayerLane.Location.X + (WidthPanel / listPlayer.Count *i)+10, PlayerLane.Location.Y + pnl_Lane.Location.X);
                    PlayerLane.lbl_SequencePlayer.Text = listPlayer.ElementAt(i).Sequence.ToString();
                    PlayerLane.pb_Team.BackColor = Color.FromArgb(Convert.ToInt32(listPlayer.ElementAt(i).Color));
                    PlayerLane.lbl_IDPlayer.Text = listPlayer.ElementAt(i).IDPlayer.ToString();

                    //add phase into player Lane
                    for (int j = 0; j < listPhase.Count; j++)
                    {
                        Phase_Lane PhaseLane = new Phase_Lane();
                        PhaseLane.Size = new System.Drawing.Size(WidthPanel / listPlayer.Count-20, 50 * NumStep);
                        PhaseLane.Location = new Point(PhaseLane.Location.X + 5, PhaseLane.Location.Y + HeightPanel - ((50 * NumStep * j)+PhaseLane.Height+60));
                        PhaseLane.BorderStyle = BorderStyle.FixedSingle;
                        PhaseLane.lbl_NamePhase.Text = listPhase.ElementAt(j).NamePhase;
                        PlayerLane.Controls.Add(PhaseLane);
                    }
                    pnl_Lane.Controls.Add(PlayerLane);
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
                            team_AudienceScreen.pb_Heart1.Show();
                            team_AudienceScreen.pb_Heart2.Show();
                            team_AudienceScreen.pb_Heart3.Show();
                        }

                    }
                    flp_Team.Controls.Add(team_AudienceScreen);
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_TimeShowQuestion.Text = (int.Parse(lbl_TimeShowQuestion.Text) - 1).ToString();
            if (int.Parse(lbl_TimeShowQuestion.Text) == 0)
                timer1.Stop();
        }

    }
}

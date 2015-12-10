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

        PlayerBL PlayerBL = new PlayerBL();
        ContestBL ContestBL = new ContestBL();
        PhaseBL PhaseBL = new PhaseBL();

        List<int> list = new List<int>();
        private void Open_Game_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //flp_Team.Controls.Clear();
            //get Player by id contest
            Player.IDContest = iDContest;
            List<Player> ListPlayer;
            ListPlayer = PlayerBL.GetPlayerByIDContest(Player);
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
                    
                }
            }
        }
    }
}

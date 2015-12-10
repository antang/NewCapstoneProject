using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.DO;
using CapDemo.BL;

namespace CapDemo
{
    public partial class ControlGame : UserControl
    {
        public ControlGame()
        {
            InitializeComponent();
        }

        public ControlGame(int idcontest)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.idcontest = idcontest;
        }
        public event EventHandler onExit;
        private int idcontest;

        public int Idcontest
        {
            get { return idcontest; }
            set { idcontest = value; }
        }
        Contest Contest = new Contest();
        ContestBL ContestBL = new ContestBL();
        List<string> list = new List<string>();
        private void ControlGame_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //flp_Team.Controls.Clear();
            Contest.IDContest = idcontest;
            List<Contest> ListContest;
            ListContest = ContestBL.GetContestByID(Contest);
            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).PlayerList!= null)
                    {
                        for (int j = 0; j <ListContest.ElementAt(i).PlayerList.Count; j++)
                        {
                            Team team = new Team();
                            team.lbl_TeamName.Text = ListContest.ElementAt(i).PlayerList.ElementAt(j).PlayerName;
                            team.lbl_TeamScore.Text = ListContest.ElementAt(i).PlayerList.ElementAt(j).PlayerScore.ToString();
                            team.lbl_Sequence.Text = ListContest.ElementAt(i).PlayerList.ElementAt(j).Sequence.ToString();
                            //team.lbl_TeamID.Text = ListContest.ElementAt(i).PlayerList.ElementAt(j).IDPlayer.ToString();
                            flp_Team.Controls.Add(team);
                        }
                    } 
                }
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (this.onExit != null)
            {
                this.onExit(this,e);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

        }
    }
}

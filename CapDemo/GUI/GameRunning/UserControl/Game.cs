using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.GUI.User_Controls;
using CapDemo.GUI;
using CapDemo.BL;
using CapDemo.DO;

namespace CapDemo
{
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
        }
        //load
        private void Game_Load(object sender, EventArgs e)
        {
            
        }
        //public event EventHandler onRun;
        int iD_Game;
        public int ID_Game
        {
            get { return iD_Game; }
            set { iD_Game = value; }
        }
        public event EventHandler onClick;
        private void Game_DoubleClick(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);

            Open_Game OpenGame = new Open_Game();
            OpenGame.IDContest = Convert.ToInt32(lbl_IDContest.Text);
            DialogResult result = OpenGame.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadContest();
            }
        }
        //Hover
        private void Game_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }
        //Leave
        private void Game_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }
        //Load
        public void LoadContest()
        {
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).IDContest == Convert.ToInt32(lbl_IDContest.Text))
                    {
                        lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        lbl_IDContest.Text = ListContest.ElementAt(i).IDContest.ToString();
                        //lbl_Number.Text = (i + 1).ToString();
                        if (ListContest.ElementAt(i).Status == true)
                        {
                            this.Enabled = false;
                            lbl_Status.Text = "Hoàn tất";
                            lbl_Status.ForeColor = Color.Red;
                        }
                        else
                        {
                            lbl_Status.Text = "Chưa hoàn Tất";
                            lbl_Status.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}

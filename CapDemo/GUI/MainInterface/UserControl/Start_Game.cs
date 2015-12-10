using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.BL;
using CapDemo.DO;

namespace CapDemo.GUI.User_Controls
{
    public partial class Start_Game : UserControl
    {
        public Start_Game()
        {
            InitializeComponent();
        }
        public event EventHandler onExit;
        public event EventHandler onClick;
        public event EventHandler Doubleclick;
        //public event EventHandler Run;
        int idcontest;
        public int Idcontest
        {
            get { return idcontest; }
            set { idcontest = value; }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (this.onExit != null)
                this.onExit(this, e);
        }

        private void Start_Game_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            load();
        }

        //Load Game
        //LOAD
        int TagGame = 0;
        public void load()
        {
            flp_StartGame.Controls.Clear();
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                { 
                    if (ListContest.ElementAt(i).NumberChallenge > 0)
                    {
                        Game game = new Game();
                        TagGame++;
                        game.Tag = TagGame;
                        game.ID_Game = TagGame;
                        //game.onRun += game_onRun;
                        //game.onClick += game_onClick;

                        game.lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        game.lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        game.lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        game.label2.Text = ListContest.ElementAt(i).IDContest.ToString();
                        game.lbl_Number.Text = (i + 1).ToString();
                        flp_StartGame.Controls.Add(game);
                    } 
                }
            }
        }


        //void game_onClick(object sender, EventArgs e)
        //{
        //    if (this.Doubleclick != null)
        //    {
        //        this.Doubleclick(this, e);
        //    }
        //}
        // eventhandler on delete
        //void game_onRun(object sender, EventArgs e)
        //{
        //    int GameID = (e as MyEventArgs).IDGame;
        //    foreach (Game item in flp_StartGame.Controls)
        //    {
        //        if (item.ID_Game == GameID)
        //        {
        //            idcontest = Convert.ToInt32(item.label2.Text);
        //        }

        //    }
        //}
    }
}

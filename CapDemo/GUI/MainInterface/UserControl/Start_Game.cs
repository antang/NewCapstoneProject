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
        public event EventHandler onClick;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void Start_Game_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //MessageBox.Show("");
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
                        game.ID_NewGame = TagGame;
                        game.onDelete += AddTeam_onDelete;

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
        // eventhandler on delete
        void AddTeam_onDelete(object sender, EventArgs e)
        {
            int stt = 1;
            //New_Game Add_Game = new New_Game();
            int GameID = (e as MyEventArgs).IDNewGame;
            foreach (New_Game item in flp_StartGame.Controls)
            {
                if (item.ID_NewGame == GameID)
                {
                    flp_StartGame.Controls.Remove(item);
                }

            }
            foreach (New_Game item in flp_StartGame.Controls)
            {
                item.lbl_Number.Text = (stt++).ToString();
            }
        }
    }
}

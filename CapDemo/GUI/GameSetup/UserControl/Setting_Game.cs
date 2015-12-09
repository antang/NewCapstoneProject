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

namespace CapDemo.GUI.User_Controls
{
    public partial class Setting_Game : UserControl
    {
        public Setting_Game()
        {
            InitializeComponent();
        }

        private void lbl_AddGame_Click(object sender, EventArgs e)
        {
            Add_New_Game ang = new Add_New_Game();
            New_Game game = new New_Game();
            DialogResult result = ang.ShowDialog();
            if (result== DialogResult.OK)
            {
                load();
            }
            else
            {
                load();
            }
        }

        private void Setting_Game_Load(object sender, EventArgs e)
        {
            load();
            //notifyIcon1.Icon = SystemIcons.Information;
            //notifyIcon1.BalloonTipText = "Thiết lập trò chơi thành công";
            //notifyIcon1.ShowBalloonTip(1000);
            this.Dock = DockStyle.Fill;
        }
        //LOAD
        int TagGame = 0;
        public void load()
        {
            flp_Game.Controls.Clear();
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    New_Game game = new New_Game();
                    TagGame++;
                    game.Tag = TagGame;
                    game.ID_NewGame = TagGame;
                    game.onDelete += AddTeam_onDelete;

                    game.lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                    game.lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                    game.lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                    game.label2.Text = ListContest.ElementAt(i).IDContest.ToString();
                    game.lbl_Number.Text = (i+1).ToString();
                    if (ListContest.ElementAt(i).NumberChallenge >0)
                    {
                        game.lbl_Status.Text = "Hoàn tất";
                        game.lbl_Status.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        game.lbl_Status.Text = "Chưa hoàn Tất";
                        game.lbl_Status.ForeColor = Color.Red;
                    }
                    flp_Game.Controls.Add(game);
                }
            }
        }
        // eventhandler on delete
        void AddTeam_onDelete(object sender, EventArgs e)
        {
            int stt = 1;
            //New_Game Add_Game = new New_Game();
            int GameID = (e as MyEventArgs).IDNewGame;
            foreach (New_Game item in flp_Game.Controls)
            {
                if (item.ID_NewGame == GameID)
                {
                    flp_Game.Controls.Remove(item);
                }

            }
            foreach (New_Game item in flp_Game.Controls)
            {
                item.lbl_Number.Text = (stt++).ToString();
            }
        }
    }
}

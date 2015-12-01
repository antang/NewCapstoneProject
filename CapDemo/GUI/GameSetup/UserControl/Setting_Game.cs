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
            DialogResult result = ang.ShowDialog();
            if (result== DialogResult.OK)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thiết lập trò chơi thành công";
                notifyIcon1.ShowBalloonTip(1000);
                load();
            } 
        }

        private void Setting_Game_Load(object sender, EventArgs e)
        {
            load();
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipText = "Thiết lập trò chơi thành công";
            notifyIcon1.ShowBalloonTip(1000);
            this.Dock = DockStyle.Fill;
        }

        public void load()
        {
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    New_Game game = new New_Game();
                    game.lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                    game.lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                    game.lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                    game.label2.Text = ListContest.ElementAt(i).IDContest.ToString();
                    game.lbl_Number.Text = (i+1).ToString();

                    flp_Game.Controls.Add(game);
                }
            }
        }
    }
}

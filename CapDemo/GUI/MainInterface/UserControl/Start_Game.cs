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
using System.Media;
using System.IO;

namespace CapDemo.GUI.User_Controls
{
    public partial class Start_Game : UserControl
    {
        public Start_Game()
        {
            InitializeComponent();
        }
        SoundPlayer sound = new SoundPlayer(Properties.Resources.hover);
        SoundPlayer sound_Click = new SoundPlayer(Properties.Resources.Click);
        public event EventHandler onExit;
        //public event EventHandler onClick;
        //public event EventHandler Doubleclick;
        //public event EventHandler Run;
        int idcontest;
        public int Idcontest
        {
            get { return idcontest; }
            set { idcontest = value; }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
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
                    if (ListContest.ElementAt(i).ChallengceScore > 0)
                    {
                        Game game = new Game();
                        TagGame++;
                        game.Tag = TagGame;
                        game.ID_Game = TagGame;
                        //game.onRun += game_onRun;
                        game.onClick += game_onClick;
                        //game.Enabled = false;

                        game.lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        game.lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        game.lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        game.lbl_IDContest.Text = ListContest.ElementAt(i).IDContest.ToString();
                        if (ListContest.ElementAt(i).Status == true)
                        {
                            game.Enabled = false;
                            game.lbl_Status.Text = "Hoàn Tất";
                            game.lbl_Status.ForeColor = Color.LightGreen;
                        }
                        else
                        {
                            game.lbl_Status.Text = "Chưa Hoàn Tất";
                            game.lbl_Status.ForeColor = Color.Red;
                        }
                        flp_StartGame.Controls.Add(game);
                    } 
                }
            }
        }
        public event EventHandler doubleClick;
        void game_onClick(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.doubleClick != null)
                this.doubleClick(this, e);
        }

        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            sound.PlaySync();
            btn_Exit.BackgroundImage = Properties.Resources.Nut_thoat_horver;
            btn_Exit.ForeColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackgroundImage = Properties.Resources.Nut_thoat_normal;
            btn_Exit.ForeColor = Color.White;
        }

    }
}

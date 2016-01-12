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

            //GameShowControl gsc = new GameShowControl();
            //gsc.Hide();
            //gsc.axWindowsMediaPlayer1.Ctlcontrols.stop();

            if (result == DialogResult.OK)
            {
                //load();
            }
        }

        private void Game_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void Game_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }
    }
}

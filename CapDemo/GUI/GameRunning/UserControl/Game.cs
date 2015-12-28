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
        //public event EventHandler onClick;
        //Double Click to rum game
        private void Game_DoubleClick(object sender, EventArgs e)
        {
            //if (this.onClick != null)
            //{
            //    EventHandler run = onRun;
            //    if (run != null)
            //    {
            //        MyEventArgs args = new MyEventArgs();
            //        args.IDGame = iD_Game;
            //        run(this, args);
            //    }
            //    this.onClick(this, e);
            //}
            Open_Game OpenGame = new Open_Game();
            OpenGame.IDContest = Convert.ToInt32(label2.Text);
            DialogResult result = OpenGame.ShowDialog();


            if (result == DialogResult.OK)
            {
                //load();
            }
        }
    }
}

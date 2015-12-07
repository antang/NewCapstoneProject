using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public event EventHandler onDelete;
        int iD_NewGame;
        public int ID_NewGame
        {
            get { return iD_NewGame; }
            set { iD_NewGame = value; }
        }
    }
}

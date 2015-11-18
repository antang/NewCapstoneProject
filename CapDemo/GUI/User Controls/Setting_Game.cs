using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ang.ShowDialog();
            New_Game game= new New_Game();
            flp_Game.Controls.Add(game);
        }
    }
}

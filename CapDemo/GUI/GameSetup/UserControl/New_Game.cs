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
    public partial class New_Game : UserControl
    {
        public New_Game()
        {
            InitializeComponent();
        }

        private void New_Game_Load(object sender, EventArgs e)
        {
        }

        private void New_Game_DoubleClick(object sender, EventArgs e)
        {
            EditGameSetting EditGameSetting = new EditGameSetting(Convert.ToInt32(label2.Text));
            EditGameSetting.ShowDialog();
        }

        
    }
}

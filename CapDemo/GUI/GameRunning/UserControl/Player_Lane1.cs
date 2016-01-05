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
    public partial class Player_Lane1 : UserControl
    {
        public Player_Lane1()
        {
            InitializeComponent();
        }
        public void HighLight(bool toggle)
        {
            if (toggle)
            {
                timeHightLight.Start();
            }
            else
            {
                this.ForeColor = Color.RoyalBlue;
                timeHightLight.Stop();
            }
        }

        private void timeHightLight_Tick(object sender, EventArgs e)
        {
                //this.ForeColor = Color.LightCoral;
                this.BackColor = Color.LightCoral;
        }
    }
}

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
    public partial class Team_AudienceScreeen : UserControl
    {
        public Team_AudienceScreeen()
        {
            InitializeComponent();
        }
        public void HighLight(bool toggle)
        {
            if (toggle)
            {
                timerHighLight.Start();
            }
            else
            {
                lbl_TeamName.ForeColor = Color.RoyalBlue;
                timerHighLight.Stop();
            }
        }

        private void timerHighLight_Tick(object sender, EventArgs e)
        {
            lbl_TeamName.ForeColor = lbl_TeamName.ForeColor == Color.RoyalBlue ? Color.LawnGreen : Color.RoyalBlue;
        }

    }
}

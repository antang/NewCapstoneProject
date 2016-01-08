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
                timerHighLight.Stop();
            }
        }

        public void HighLightChallenge(bool toggle)
        {
            if (toggle)
            {
                timerChallenge.Start();
            }
            else
            {
                btn_ChallengeChoice.BackColor = Color.SkyBlue;
                timerChallenge.Stop();
            }
        }
        private void timerHighLight_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            btn_SupportChoice.BackColor = Color.LightGreen;
            btn_ChallengeChoice.BackColor = Color.LightGreen;
        }

        
        //timer update score

        private void timerChallenge_Tick(object sender, EventArgs e)
        {
            btn_ChallengeChoice.BackColor = btn_ChallengeChoice.BackColor == Color.Yellow ? Color.Red : Color.Red;
        }

    }
}

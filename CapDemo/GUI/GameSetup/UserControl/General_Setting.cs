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
    public partial class General_Setting : UserControl
    {
        public General_Setting()
        {
            InitializeComponent();
        }

        private void chk_Question_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Question.Checked == true)
            {
                grb_Question.Enabled = true;
            }
            else
            {
                grb_Question.Enabled = false;
            }
        }

        private void chk_Answer_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Answer.Checked == true)
            {
                grb_Answer.Enabled = true;
            }
            else
            {
                grb_Answer.Enabled = false;
            }
        }
    }
}

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
    public partial class Competition_Setting : UserControl
    {
        public Competition_Setting()
        {
            InitializeComponent();
        }

        public Competition_Setting(int p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
        }
        //LOAD USER CONTROL
        private static Competition_Setting _instance;
        public static Competition_Setting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Competition_Setting();
                return _instance;
            }
        }

        //Check form empty
        public bool checkFormEmpty()
        {
            if (txt_TimeForSupport.Text.Trim() == "" || txt_NumTeam.Text.Trim()==""||txt_ChallengeScore.Text.Trim()=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool nonNumberEntered = false;
        private int p;
        //Input time for request support choice
        private void txt_TimeForSupport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_TimeForSupport_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        //Input time for number of team to defy
        private void txt_NumTeam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_NumTeam_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        //Input score for challenge choice
        private void txt_ChallengeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_ChallengeScore_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        //limit input time to support
        private void txt_NumTeam_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumTeam.Text != "")
            {
                if (Convert.ToInt32(txt_NumTeam.Text) == 0 || Convert.ToInt32(txt_NumTeam.Text) > (p-1))
                {
                    MessageBox.Show("Số lượng đội thách đấu tối thiểu là 1 và tối đa là " + (p- 1).ToString() + ".", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_NumTeam.Text = "";
                }
            }
        }

        private void txt_ChallengeScore_TextChanged(object sender, EventArgs e)
        {
            if (txt_ChallengeScore.Text != "")
            {
                if (Convert.ToInt32(txt_ChallengeScore.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng đội  bị thách đấu lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ChallengeScore.Text = "";
                }
            }
        }

        private void txt_TimeForSupport_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimeForSupport.Text != "")
            {
                if (Convert.ToInt32(txt_TimeForSupport.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập thời gian cho quyền trợ giúp lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TimeForSupport.Text = "";
                }
            }
        }

        ////limit input time to support
        //private void txt_TimeForSupport_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_TimeForSupport.Text!="")
        //    {
        //        if (Convert.ToInt32(txt_TimeForSupport.Text)==0)
        //        {
        //            MessageBox.Show("Vui lòng nhập thời gian cho quyền trợ giúp lớn hơn 0","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //            txt_TimeForSupport.Text = "";
        //        }
        //    }
        //}
        ////limit input number of team in challenge
        //private void txt_NumTeam_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_NumTeam.Text != "")
        //    {
        //        if (Convert.ToInt32(txt_NumTeam.Text) == 0)
        //        {
        //            MessageBox.Show("Vui lòng nhập số lượng đội  bị thách đấu lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txt_NumTeam.Text = "";
        //        }
        //    }
        //}
        ////limit input point in challenge
        //private void txt_ChallengeScore_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_ChallengeScore.Text != "")
        //    {
        //        if (Convert.ToInt32(txt_ChallengeScore.Text) == 0)
        //        {
        //            MessageBox.Show("Vui lòng nhập số lượng đội  bị thách đấu lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txt_ChallengeScore.Text = "";
        //        }
        //    }
        //}
    }
}

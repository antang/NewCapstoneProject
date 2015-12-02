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
        //private static General_Setting _instance;
        //public static General_Setting instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new General_Setting();
        //        return _instance;
        //    }
        //}

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
        private bool nonNumberEntered = false;
        //iput time for question
        private void txt_TimeQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_TimeQuestion_KeyDown(object sender, KeyEventArgs e)
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
        //time for answer
        private void txt_TimeAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_TimeAnswer_KeyDown(object sender, KeyEventArgs e)
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
        //imput bonus
        private void txt_Bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_Bonus_KeyDown(object sender, KeyEventArgs e)
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
        //input step to pass
        private void txt_NumStepPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_NumStepPass_KeyDown(object sender, KeyEventArgs e)
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
        //input step to fail
        private void txt_NumStepFail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_NumStepFail_KeyDown(object sender, KeyEventArgs e)
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

        //Check form
        public bool CheckFormEmpty()
        {
            if (txt_CompetitionName.Text.Trim() == "" || txt_RoundName.Text.Trim() == "" || txt_ContestName.Text.Trim() == "" || txt_Bonus.Text.Trim() == "" || txt_NumStepFail.Text.Trim() == "" || txt_NumStepPass.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                if (chk_Answer.Checked != true && chk_Question.Checked != true)
                {
                    return false;
                }
                else
                {
                    if (chk_Answer.Checked == true && chk_Question.Checked == true)
                    {
                        if (txt_TimeAnswer.Text != "" && txt_TimeQuestion.Text != "")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (chk_Answer.Checked == true && chk_Question.Checked != true)
                        {
                            if (txt_TimeAnswer.Text == "")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (txt_TimeQuestion.Text == "")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }   
                    }
                }
            }
        }
        //Limit input more character for competition name
        private void txt_CompetitionName_TextChanged(object sender, EventArgs e)
        {
            if (txt_CompetitionName.Text.Trim().Length < 30)
            {

            }
            else
            {
                txt_CompetitionName.Text = txt_CompetitionName.Text.Trim().Substring(0, txt_CompetitionName.Text.Length - 1);
                MessageBox.Show("Không được phép nhập trên 30 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Limit input more character for round name
        private void txt_RoundName_TextChanged(object sender, EventArgs e)
        {
            if (txt_RoundName.Text.Trim().Length < 30)
            {

            }
            else
            {
                txt_RoundName.Text = txt_RoundName.Text.Trim().Substring(0, txt_RoundName.Text.Length - 1);
                MessageBox.Show("Không được phép nhập trên 30 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Limit input more character for contest name
        private void txt_ContestName_TextChanged(object sender, EventArgs e)
        {
            if (txt_ContestName.Text.Trim().Length < 30)
            {

            }
            else
            {
                txt_ContestName.Text = txt_ContestName.Text.Trim().Substring(0, txt_ContestName.Text.Length - 1);
                MessageBox.Show("Không được phép nhập trên 30 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //limit input time show question
        private void txt_TimeQuestion_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimeQuestion.Text=="")
            {
                //MessageBox.Show("Vui lòng nhập lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(txt_TimeQuestion.Text) == 0 )
                {
                    MessageBox.Show("Vui lòng nhập thời gian hiển thị  câu hỏi lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TimeQuestion.Text = "";
                }
            }
        }
        //limit input bonus
        private void txt_Bonus_TextChanged(object sender, EventArgs e)
        {
            if (txt_Bonus.Text != "")
            {
                if (Convert.ToInt32(txt_Bonus.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập điểm thưởng cho đội về đích đầu tiên lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Bonus.Text = "";
                }
            }
        }
        //limit input number of step pass
        private void txt_NumStepPass_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumStepPass.Text != "")
            {
                if (Convert.ToInt32(txt_NumStepPass.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng câu đúng lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_NumStepPass.Text = "";
                }
            }
        }
        //limit input number of step fail
        private void txt_NumStepFail_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumStepFail.Text != "")
            {
                if (Convert.ToInt32(txt_NumStepFail.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng câu sai lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_NumStepFail.Text = "";
                }
            }
        }

        private void General_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        //public string GetCompetitionName()
        //{
        //    return txt_CompetitionName.Text;
        //}
        //public string GetRoundName()
        //{
        //    return txt_RoundName.Text;
        //}
        //public string GetContestName()
        //{
        //    return txt_ContestName.Text;
        //}
        //Check time show question auto
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

        private void txt_TimeAnswer_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimeAnswer.Text == "")
            {
                //MessageBox.Show("Vui lòng nhập lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(txt_TimeAnswer.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập thời gian hiển thị  câu hỏi lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TimeAnswer.Text = "";
                }
            }
        }
    }
}

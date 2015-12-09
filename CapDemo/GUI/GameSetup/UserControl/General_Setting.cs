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
    public partial class General_Setting : UserControl
    {
        public General_Setting()
        {
            InitializeComponent();
        }
        int idCompetition;
        string nameCompetition;
        int idRound;
        public int IdRound
        {
            get { return idRound; }
            set { idRound = value; }
        }

        public int IdCompetition
        {
            get { return idCompetition; }
            set { idCompetition = value; }
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

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 )
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
            if (txt_ContestName.Text.Trim() == "" || txt_Bonus.Text.Trim() == "" || txt_NumStepFail.Text.Trim() == "" || txt_NumStepPass.Text.Trim() == ""||cmb_Competition.SelectedItem == null || cmb_Round.SelectedItem == null)
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
            if (txt_TimeQuestion.Text!="")
            {
                //MessageBox.Show("Vui lòng nhập lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (Convert.ToInt32(txt_TimeQuestion.Text) == 0 )
                {
                    MessageBox.Show("Vui lòng nhập thời gian hiển thị câu hỏi lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Load Form
        private void General_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cmb_Competition.Items.Clear();
            LoadCompetition();
            cmb_Round.Items.Clear();
            LoadRound();
        }

        //Load Competition
        public void LoadCompetition()
        {
            CompetitionBL CompetitionBL = new CompetitionBL();
            List<Competition> ListCompetition;
            ListCompetition = CompetitionBL.GetCompetition();
            if (ListCompetition != null)
            {
                for (int i = 0; i < ListCompetition.Count; i++)
                {
                    cmb_Competition.Items.Add(ListCompetition.ElementAt(i).NameCompetition);
                }
            }
            if (cmb_Competition.Items.Count > 0)
            {
                cmb_Competition.SelectedIndex = 0;
            }
        }

        //Load round
        public void LoadRound()
        {
            RoundBL RoundBL = new RoundBL();
            Round Round = new Round();
            CompetitionBL CompetitionBL = new CompetitionBL();

            List<Competition> ListCompetition;
            ListCompetition = CompetitionBL.GetCompetition();
            if (ListCompetition != null)
            {
                for (int i = 0; i < ListCompetition.Count; i++)
                {
                    if (cmb_Competition.SelectedItem.ToString() == ListCompetition.ElementAt(i).NameCompetition)
                    {
                        Round.IDCompetition = ListCompetition.ElementAt(i).IDCompetition;
                        idCompetition = ListCompetition.ElementAt(i).IDCompetition;
                        nameCompetition = cmb_Competition.SelectedItem.ToString();
                    }
                }
            }
            //load commobox round
            List<Round> ListRound;
            ListRound = RoundBL.GetRoundByIDCompetition(Round);
            if (ListRound != null)
            {
                for (int i = 0; i < ListRound.Count; i++)
                {
                    cmb_Round.Items.Add(ListRound.ElementAt(i).NameRound);
                }
            }
            if (cmb_Round.Items.Count > 0)
            {
                cmb_Round.SelectedIndex = 0;
            }
        }
        
        //Get Id Round
        public void GetIDround()
        {
            RoundBL RoundBl = new RoundBL();
            List<Round> ListRound;
            ListRound = RoundBl.GetRound();
            if (ListRound != null)
            {
                for (int i = 0; i < ListRound.Count; i++)
                {
                    if (cmb_Round.SelectedItem.ToString() == ListRound.ElementAt(i).NameRound && ListRound.ElementAt(i).IDCompetition == idCompetition)
                    {
                        idRound = ListRound.ElementAt(i).IDRound;
                    }
                }
            }
        }

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
            if (txt_TimeAnswer.Text != "")
            {
                if (Convert.ToInt32(txt_TimeAnswer.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập thời gian hiển thị đáp án lớn hơn 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TimeAnswer.Text = "";
                }
            }
        }
        //Add new Competition
        private void btn_AddCompetition_Click(object sender, EventArgs e)
        {
            Add_Competition AddCompetition = new Add_Competition();
            AddCompetition.ShowDialog();
            cmb_Competition.Items.Clear();
            LoadCompetition();
        }
        //Add new Round
        private void btn_AddRound_Click(object sender, EventArgs e)
        {
            Add_Round AddRound = new Add_Round(idCompetition,nameCompetition);
            AddRound.ShowDialog();
            cmb_Round.Items.Clear();
            LoadRound();
        }
        //Select Competition in commobox to load round list
        private void cmb_Competition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Round.Items.Clear();
            LoadRound();
        }
        //Select Round in commobox
        private void cmb_Round_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIDround();
        }
        
    }
}

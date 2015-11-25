using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.DO;
using CapDemo.BL;

namespace CapDemo.GUI.User_Controls
{
    public partial class Question_MultiSelect : UserControl
    {
        private int IDCat;
        private string NameCat;
        int i = 0;
        int a = 65;

        public Question_MultiSelect()
        {
            InitializeComponent();
        }

        public Question_MultiSelect(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }
        //Load Form
        private void Question_MultiSelect_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            txt_Date.Text = DateTime.Now.ToString("d");
            //AUTO ADD 4 ANSWER
            for (int j = 0; j <4; j++)
            {
                Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
                i++;
                MultiSelectAnswer.Tag = i;
                MultiSelectAnswer.ID_Answer = i;
                MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
                MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a+j).ToString();
                flp_addAnswer.Controls.Add(MultiSelectAnswer);
            }
        }
        //Add Answer
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
            i++;
            MultiSelectAnswer.Tag = i;
            MultiSelectAnswer.ID_Answer = i;
            MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
            MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a).ToString();
            flp_addAnswer.Controls.Add(MultiSelectAnswer);

            for (int j = 0; j < flp_addAnswer.Controls.Count; j++)
            {
                MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
            }
        }
        //Eventhanlder click Del button
        void MultiSelectAnswer_onDelete(object sender, EventArgs e)
        {
            
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_addAnswer.Controls.Remove(item);
                }
            }
            int alp = 0;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                item.chk_Check.Text = Convert.ToChar(a + alp++).ToString();
            }
        }
        //check answer null
        public bool checkAnswerEmpty()
        {
            int i = 0;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.txt_AnswerContent.Text.Trim() == "")
                {
                    i++;
                }
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Check blank correct answer
        public bool checkBlankCorrectAnswer()
        {
            int i = 0;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.chk_Check.Checked == true)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //SAVE QUESTION AND ANSWER
        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();
            int NumAnswer = flp_addAnswer.Controls.Count;

            if (txt_ContentQuestion.Text.Trim() == "" || NumAnswer < 2)
            {
                if (txt_ContentQuestion.Text.Trim() == "")
                {

                    MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập hơn một đáp án!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (checkAnswerEmpty() == true)
                {
                    MessageBox.Show("Không lưu câu hỏi vì tồn tại đáp án rỗng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (checkBlankCorrectAnswer()==true)
                    {
                        MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        question.NameQuestion = txt_ContentQuestion.Text.Trim();
                        question.TypeQuestion = "multiplechoice";
                        question.IDCatalogue = IDCat;
                        question.Date = DateTime.Now;
                        questionBl.AddQuestion(question);

                        foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                        {
                            if (item.txt_AnswerContent.Text.Trim() != "")
                            {
                                answer.ContentAnswer = item.txt_AnswerContent.Text.Trim();
                                answer.IsCorrect = item.chk_Check.Checked;
                                answer.IDQuestion = questionBl.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                questionBl.AddAnswer(answer);
                            }
                        }
                        //Show notify
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công!";
                        notifyIcon1.ShowBalloonTip(1000);
                        //Close form
                        Form FindForm = this.FindForm();
                        FindForm.Close();
                    }  
                }  
            }
        }
        //EXIT FORM
        private void btn_CancelQuestion_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE QUESTION AND ANSWER. CONTINUE INPUT
        private void btn_SaveAndCreateNewQuestion_Click(object sender, EventArgs e)
        {
            QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();
            int NumAnswer = flp_addAnswer.Controls.Count;

            if (txt_ContentQuestion.Text.Trim() == "" || NumAnswer < 2)
            {
                if (txt_ContentQuestion.Text.Trim() == "")
                {

                    MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập hơn một đáp án!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (checkAnswerEmpty() == true)
                {
                    MessageBox.Show("Không lưu câu hỏi vì tồn tại đáp án rỗng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (checkBlankCorrectAnswer()==true)
                    {
                        MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        question.NameQuestion = txt_ContentQuestion.Text.Trim();
                        question.TypeQuestion = "multiplechoice";
                        question.IDCatalogue = IDCat;
                        question.Date = DateTime.Now;
                        questionBl.AddQuestion(question);

                        foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                        {
                            if (item.txt_AnswerContent.Text.Trim() != "")
                            {
                                answer.ContentAnswer = item.txt_AnswerContent.Text.Trim();
                                answer.IsCorrect = item.chk_Check.Checked;
                                answer.IDQuestion = questionBl.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                questionBl.AddAnswer(answer);
                            }
                        }
                        //Show notify
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công!";
                        notifyIcon1.ShowBalloonTip(1000);
                        //Refesh form
                        this.txt_ContentQuestion.Text = "";
                        flp_addAnswer.Controls.Clear();
                        //AUTO ADD 4 ANSWER
                        for (int j = 0; j < 4; j++)
                        {
                            Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
                            i++;
                            MultiSelectAnswer.Tag = i;
                            MultiSelectAnswer.ID_Answer = i;
                            MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
                            MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
                            flp_addAnswer.Controls.Add(MultiSelectAnswer);
                        }
                    } 
                }
            }
        }
    }
}

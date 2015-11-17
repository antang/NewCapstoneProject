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
    public partial class Question_OnlyOneSelect : UserControl
    {
        private int IDCat;
        private string NameCat;

        public Question_OnlyOneSelect()
        {
            InitializeComponent();
        }

        public Question_OnlyOneSelect(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }
        //LOAD FORM
        private void Question_OnlyOneSelect_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            txt_Date.Text = DateTime.Now.ToString("d");
        }

        int i = 0;
        int a = 65;
        //ADD ANSWER
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
            i++;
            OneChoiceAnswer.Tag = i;
            OneChoiceAnswer.ID_Answer = i;
            OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
            OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
            OneChoiceAnswer.rad_check.Text = Convert.ToChar(a).ToString();
            flp_addAnswer.Controls.Add(OneChoiceAnswer);
            a++;
        }
        //Eventhanlder check radio button
        void OneChoiceAnswer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer != answerID)
                {
                    item.rad_check.Checked = false;   
                }

            }
        }
        //Eventhanlder click Del button
        void OneChoiceAnswer_onDelete(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_addAnswer.Controls.Remove(item);
                }

            }
        }
        //SAVE QUESTION AND ANSWER
        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();
            if (txt_ContentQuestion.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                question.NameQuestion = txt_ContentQuestion.Text;
                question.TypeQuestion = "One Select";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;
                questionBl.AddQuestion(question);

                foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
                {
                    if (item.txt_Answercontent.Text != "")
                    {
                        answer.ContentAnswer = item.txt_Answercontent.Text;
                        answer.IsCorrect = item.rad_check.Checked;
                        answer.IDQuestion = questionBl.MaxIDQuestion();
                        answer.IDCatalogue = IDCat;
                        questionBl.AddAnswer(answer);
                    }
                }
                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(1000);
                //Close form
                Form FindForm = this.FindForm();
                FindForm.Close();
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
            if (txt_ContentQuestion.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                question.NameQuestion = txt_ContentQuestion.Text;
                question.TypeQuestion = "One Select";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;
                questionBl.AddQuestion(question);

                foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
                {
                    if (item.txt_Answercontent.Text != "")
                    {
                        answer.ContentAnswer = item.txt_Answercontent.Text;
                        answer.IsCorrect = item.rad_check.Checked;
                        answer.IDQuestion = questionBl.MaxIDQuestion();
                        answer.IDCatalogue = IDCat;
                        questionBl.AddAnswer(answer);
                    }
                }
                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(1000);
                //Refesh form
                this.txt_ContentQuestion.Text = "";
                flp_addAnswer.Controls.Clear();
                a = 65;
            }
        }

    }
}

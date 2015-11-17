using CapDemo.BL;
using CapDemo.DO;
using CapDemo.GUI.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI
{
    public partial class EditQuestion_MultiSelect : Form
    {
        private int IDQuestion;
        private int IDCatalogue;

        public EditQuestion_MultiSelect()
        {
            InitializeComponent();
        }

        public EditQuestion_MultiSelect(int pIDQuestion,int pIDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = pIDQuestion;
            this.IDCatalogue = pIDCatalogue;
        }
        //LOAD FORM
        private void EditQuestion_MultiSelect_Load(object sender, EventArgs e)
        {
            //GET QUESTION BY ID Question
            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            Question question = new Question();
            QuestionList = QuestionBL.GetQuestion();
            if (QuestionList != null)
            {
                for (int i = 0; i < QuestionList.Count; i++)
                {
                    if (QuestionList.ElementAt(i).IDQuestion == IDQuestion)
                    {
                        txt_ContentQuestion.Text = QuestionList.ElementAt(i).NameQuestion;
                        txt_Date.Text = QuestionList.ElementAt(i).Date.ToString("d");
                    }

                }
                //GET ANSWER BY ID QUESTION
                List<DO.Answer> AnswerList;
                Answer answer = new Answer();
                question.IDQuestion = IDQuestion;
                AnswerList = QuestionBL.GetAnswerByQuestionID(question);
                if (AnswerList != null)
                {
                    for (int j = 0; j < AnswerList.Count; j++)
                    {
                        Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
                        i++;
                        MultiSelectAnswer.Tag = i;
                        MultiSelectAnswer.ID_Answer = i;
                        MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
                        MultiSelectAnswer.onCheck += MultiSelectAnswer_onCheck;
                        MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
                        flp_addAnswer.Controls.Add(MultiSelectAnswer);

                        MultiSelectAnswer.txt_AnswerContent.Text = AnswerList.ElementAt(j).ContentAnswer;
                        MultiSelectAnswer.chk_Check.Checked = AnswerList.ElementAt(j).IsCorrect;
                        flp_addAnswer.Controls.Add(MultiSelectAnswer);
                    }
                }
            }
        }
        //EXIT FORM
        private void btn_CancelEditQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //SAVE QUESTION
        private void btn_SaveEditQuestion_Click(object sender, EventArgs e)
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
                //Update question
                question.NameQuestion = txt_ContentQuestion.Text;
                question.IDQuestion = IDQuestion;
                questionBl.EditQuestionbyID(question);

                //DELETE Answer
                question.IDQuestion = IDQuestion;
                questionBl.DeleteAnswerByIDQuestion(question);

                foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                {
                    if (item.txt_AnswerContent.Text != "")
                    {
                        answer.ContentAnswer = item.txt_AnswerContent.Text;
                        answer.IsCorrect = item.chk_Check.Checked;
                        answer.IDQuestion = IDQuestion;
                        answer.IDCatalogue = IDCatalogue;
                        questionBl.AddAnswer(answer);
                    }
                }
                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(2000);
                //Close form
                Form FindForm = this.FindForm();
                FindForm.Close();
            }
        }
        //Add Answer
        int i = 0;
        int a = 65;
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
            i++;
            MultiSelectAnswer.Tag = i;
            MultiSelectAnswer.ID_Answer = i;
            MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
            MultiSelectAnswer.onCheck += MultiSelectAnswer_onCheck;
            MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a).ToString();
            flp_addAnswer.Controls.Add(MultiSelectAnswer);
            for (int j = 0; j < flp_addAnswer.Controls.Count; j++)
            {
                MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
            }
        }
        //Eventhanlder check radio button
        void MultiSelectAnswer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer != answerID)
                {
                    item.chk_Check.Checked = false;
                }

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
        }
    }
}

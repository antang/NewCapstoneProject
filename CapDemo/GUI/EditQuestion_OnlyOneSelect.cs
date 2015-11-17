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
    public partial class EditQuestion_OnlyOneSelect : Form
    {
        public EditQuestion_OnlyOneSelect()
        {
            InitializeComponent();
        }

        public EditQuestion_OnlyOneSelect(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
        //LOAD FORM
        private void EditQuestion_OnlyOneSelect_Load(object sender, EventArgs e)
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
                        Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
                        i++;
                        OneChoiceAnswer.Tag = i;
                        OneChoiceAnswer.ID_Answer = i;
                        OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
                        OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
                        OneChoiceAnswer.rad_check.Text = Convert.ToChar(a).ToString();

                        OneChoiceAnswer.txt_Answercontent.Text = AnswerList.ElementAt(j).ContentAnswer;
                        OneChoiceAnswer.rad_check.Checked = AnswerList.ElementAt(j).IsCorrect;
                        flp_addAnswer.Controls.Add(OneChoiceAnswer);
                        a++;
                    }
                }
            }
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
                //ADD QUESTION AND ANSWER
                question.NameQuestion = txt_ContentQuestion.Text;
                question.TypeQuestion = "One Select";
                question.IDCatalogue = IDCatalogue;
                question.Date = DateTime.Now;
                questionBl.AddQuestion(question);

                foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
                {
                    if (item.txt_Answercontent.Text != "")
                    {
                        answer.ContentAnswer = item.txt_Answercontent.Text;
                        answer.IsCorrect = item.rad_check.Checked;
                        answer.IDQuestion = questionBl.MaxIDQuestion();
                        answer.IDCatalogue = IDCatalogue;
                        questionBl.AddAnswer(answer);
                    }
                }
                //DELETE QUESTION AND ANSWER
                question.IDQuestion = IDQuestion;
                questionBl.DeleteAnswerByIDQuestion(question);
                questionBl.DeleteQuestionByID(question);
                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = " Chỉnh sửa câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(1000);
                //Close form
                this.Close();
            }
        }

        int i = 0;
        int a = 65;
        private int IDQuestion;
        private int IDCatalogue;
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
        //EXIT FORM
        private void btn_CancelEditQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

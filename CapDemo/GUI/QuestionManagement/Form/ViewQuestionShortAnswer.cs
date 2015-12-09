using CapDemo.BL;
using CapDemo.DO;
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
    public partial class ViewQuestionShortAnswer : Form
    {
        private int IDQuestion;
        private int IDCatalogue;

        public ViewQuestionShortAnswer()
        {
            InitializeComponent();
        }

        public ViewQuestionShortAnswer(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
        //Load Form
        private void ViewQuestionShortAnswer_Load(object sender, EventArgs e)
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
                        txt_Catalogue.Text = QuestionList.ElementAt(i).NameCatalogue;
                        txt_ContentQuestion.Text = QuestionList.ElementAt(i).NameQuestion;
                        txt_QuestionType.Text = QuestionList.ElementAt(i).TypeQuestion;
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
                        txt_ContentAnswer.Text = AnswerList.ElementAt(j).ContentAnswer;
                    }
                }
            }
        }
        //EDIT QUESTION
        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            btn_EditQuestion.Visible = false;
            btn_Save.Visible = true;
            txt_ContentQuestion.ReadOnly = false;
            txt_ContentAnswer.ReadOnly = false;
        }
        //SAVE QUESTION
        private void btn_Save_Click(object sender, EventArgs e)
        {
           QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();
            if (txt_ContentQuestion.Text.Trim() == "" || txt_ContentAnswer.Text.Trim() == "")
            {
                if (txt_ContentQuestion.Text.Trim() == "")
                {
                    MessageBox.Show("Câu hỏi không được rỗng. Vui lòng nhập thông tin câu hỏi trước khi lưu.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Đáp án không được rỗng. Vui lòng nhập thông tin đáp án trước khi lưu.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
            else
            {
                //Update question
                question.NameQuestion = txt_ContentQuestion.Text.Trim();
                question.IDQuestion = IDQuestion;
                questionBl.EditQuestionbyID(question);
                //Update  answer
                answer.IDQuestion = IDQuestion;
                answer.ContentAnswer = txt_ContentAnswer.Text.Trim();
                //answer.IsCorrect = true;
                answer.Check = 1;
                questionBl.EditAnswerbyID(answer);

                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Chỉnh sửa câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(2000);
                //Close form
                Form FindForm = this.FindForm();
                FindForm.Close();
            }
        }
        //EXIT FORM
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Question_ShortAnswer : UserControl
    {
        private int IDCat;
        private string NameCat;

        public Question_ShortAnswer()
        {
            InitializeComponent();
        }

        public Question_ShortAnswer(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }

        private void Question_ShortAnswer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            txt_Date.Text = DateTime.Now.ToString("d");
        }
        //SAVE QUESTION AND CLOSE FORM
        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();
            if (txt_ContentQuestion.Text == "" || txt_AnswerContent.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                question.NameQuestion = txt_ContentQuestion.Text;
                question.TypeQuestion = "shortanswer";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;
                questionBl.AddQuestion(question);

                if (txt_AnswerContent.Text != "")
	            {
		            answer.ContentAnswer = txt_AnswerContent.Text;
                    answer.IsCorrect = true;
                    answer.IDQuestion = questionBl.MaxIDQuestion();
                    answer.IDCatalogue = IDCat;
                    questionBl.AddAnswer(answer);
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
        //EXIT FORM
        private void btn_CancelQuestion_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE AND CONTINUE TO ADD QUESTION
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
                question.TypeQuestion = "shortanswer";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;
                questionBl.AddQuestion(question);

                if (txt_AnswerContent.Text != "")
                {
                    answer.ContentAnswer = txt_AnswerContent.Text;
                    answer.IsCorrect = true;
                    answer.IDQuestion = questionBl.MaxIDQuestion();
                    answer.IDCatalogue = IDCat;
                    questionBl.AddAnswer(answer);
                }
                //Show notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công.";
                notifyIcon1.ShowBalloonTip(2000);
                //Refesh form
                txt_ContentQuestion.Text = "";
                txt_AnswerContent.Text = "";
            }
        }
    }
}

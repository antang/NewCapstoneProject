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
    public partial class ViewQuestion : Form
    {
        private int IDQuestion;
        private int IDCatalogue;
        int i = 0;
        int a = 65;

        public ViewQuestion()
        {
            InitializeComponent();
        }

        public ViewQuestion(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
        //LOAD FORM
        private void ViewQuestion_Load(object sender, EventArgs e)
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
                        Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
                        i++;
                        OneChoiceAnswer.Tag = i;
                        OneChoiceAnswer.ID_Answer = i;
                        OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
                        OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
                        OneChoiceAnswer.rad_check.Text = Convert.ToChar(a+j).ToString();

                        OneChoiceAnswer.txt_Answercontent.Text = AnswerList.ElementAt(j).ContentAnswer;
                        OneChoiceAnswer.rad_check.Checked = AnswerList.ElementAt(j).IsCorrect;

                        OneChoiceAnswer.txt_Answercontent.ReadOnly = true;
                        OneChoiceAnswer.rad_check.Enabled = false;
                        OneChoiceAnswer.btn_Delete.Visible = false;
                        flp_Answer.Controls.Add(OneChoiceAnswer);
                    }
                }
            }
        }
        //Add Answer
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
            i++;
            OneChoiceAnswer.Tag = i;
            OneChoiceAnswer.ID_Answer = i;
            OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
            OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
            OneChoiceAnswer.rad_check.Text = Convert.ToChar(a).ToString();
            flp_Answer.Controls.Add(OneChoiceAnswer);
            for (int j = 0; j < flp_Answer.Controls.Count; j++)
            {
                OneChoiceAnswer.rad_check.Text = Convert.ToChar(a + j).ToString();
            }
        }
        //Eventhanlder check radio button
        void OneChoiceAnswer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
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
            foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_Answer.Controls.Remove(item);
                }
            }
            int alp = 0;
            foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
            {
                item.rad_check.Text = Convert.ToChar(a + alp++).ToString();
            }
        }
        //check answer null
        public bool checkAnswerEmpty()
        {
            int i = 0;
            foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
            {
                if (item.txt_Answercontent.Text.Trim() == "")
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
            foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
            {
                if (item.rad_check.Checked == true)
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
        //Save Question
        private void btn_Save_Click(object sender, EventArgs e)
        {
             int NumAnswer = flp_Answer.Controls.Count;

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
                     if (checkBlankCorrectAnswer() == true)
                     {
                         MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     else
                     {
                         QuestionBL questionBl = new QuestionBL();
                         Question question = new Question();
                         Answer answer = new Answer();
                         //Update question
                         question.NameQuestion = txt_ContentQuestion.Text.Trim();
                         question.IDQuestion = IDQuestion;
                         questionBl.EditQuestionbyID(question);

                         //DELETE ANSWER
                         question.IDQuestion = IDQuestion;
                         questionBl.DeleteAnswerByIDQuestion(question);

                         foreach (Answer_OnlyOneSelect item in flp_Answer.Controls)
                         {
                             if (item.txt_Answercontent.Text.Trim() != "")
                             {
                                 answer.ContentAnswer = item.txt_Answercontent.Text.Trim();
                                 if (item.rad_check.Checked ==true)
                                 {
                                     answer.Check = 1;
                                 }
                                 else
                                 {
                                     answer.Check = 0;
                                 }
                                 answer.IDQuestion = IDQuestion;
                                 answer.IDCatalogue = IDCatalogue;
                                 questionBl.AddAnswer(answer);
                             }
                         }
                         //Show notify
                         notifyIcon1.Icon = SystemIcons.Information;
                         notifyIcon1.BalloonTipText = " Chỉnh sửa câu hỏi thành công";
                         notifyIcon1.ShowBalloonTip(2000);
                         //Close form
                         this.Close();
                     }
                 }
             }
        }
        //EDIT QUESTION
        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            btn_EditQuestion.Visible = false;
            btn_Save.Visible = true;
            btn_addAnswer.Visible = true;
            flp_Answer.Controls.Clear();
            txt_ContentQuestion.ReadOnly = false;

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
                        Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
                        i++;
                        OneChoiceAnswer.Tag = i;
                        OneChoiceAnswer.ID_Answer = i;
                        OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
                        OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
                        OneChoiceAnswer.rad_check.Text = Convert.ToChar(a+j).ToString();

                        OneChoiceAnswer.txt_Answercontent.Text = AnswerList.ElementAt(j).ContentAnswer;
                        OneChoiceAnswer.rad_check.Checked = AnswerList.ElementAt(j).IsCorrect;

                        flp_Answer.Controls.Add(OneChoiceAnswer);
                    }
                }
            }
        }
        //Exit Form
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PreviewQuestion_Click(object sender, EventArgs e)
        {
            PreviewQuestion Preview = new PreviewQuestion();
            Preview.QuestionPreview = txt_ContentQuestion.Text;
            foreach (Answer_OnlyOneSelect onechoice in flp_Answer.Controls)
	        {
                Preview.AnswerPreview.Add(onechoice.txt_Answercontent.Text);
	        }
            Preview.ShowDialog();
        }
    }
}
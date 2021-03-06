﻿using CapDemo.BL;
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
        int i = 0;
        int a = 65;

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
                        MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
                        //flp_addAnswer.Controls.Add(MultiSelectAnswer);

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
        //SAVE QUESTION
        private void btn_SaveEditQuestion_Click(object sender, EventArgs e)
        {
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
                        QuestionBL questionBl = new QuestionBL();
                        Question question = new Question();
                        Answer answer = new Answer();
                        //Update question
                        question.NameQuestion = txt_ContentQuestion.Text.Trim();
                        question.IDQuestion = IDQuestion;
                        questionBl.EditQuestionbyID(question);

                        //DELETE Answer
                        question.IDQuestion = IDQuestion;
                        questionBl.DeleteAnswerByIDQuestion(question);

                        foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                        {
                            if (item.txt_AnswerContent.Text.Trim() != "")
                            {
                                answer.ContentAnswer = item.txt_AnswerContent.Text.Trim();
                                if (item.chk_Check.Checked == true )
                                {
                                    answer.Check = 1;
                                }
                                else
                                {
                                    answer.Check = 0;
                                }
                                //answer.IsCorrect = item.chk_Check.Checked;
                                answer.IDQuestion = IDQuestion;
                                answer.IDCatalogue = IDCatalogue;
                                questionBl.AddAnswer(answer);
                            }
                        }
                        //Show notify
                        //notifyIcon1.Icon = SystemIcons.Information;
                        //notifyIcon1.BalloonTipText = "Chỉnh sửa câu hỏi thành công";
                        //notifyIcon1.ShowBalloonTip(2000);
                        //Close form
                        Form FindForm = this.FindForm();
                        FindForm.Close();
                    } 
                }
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
        //preview question
        private void btn_PreviewQuestion_Click(object sender, EventArgs e)
        {
            PreviewQuestion Preview = new PreviewQuestion();
            Preview.QuestionPreview = txt_ContentQuestion.Text;
            foreach (Answer_MultiSelect multichoice in flp_addAnswer.Controls)
            {
                Preview.AnswerPreview.Add(multichoice.txt_AnswerContent.Text);
            }
            Preview.ShowDialog();
        }
    }
}

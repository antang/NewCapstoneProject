﻿using System;
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
            if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "" || txt_AnswerContent.Text.Trim() == "")
            {
                if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "")
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
                question.QuestionTitle = txt_NameQuestion.Text.Trim();
                question.NameQuestion = txt_ContentQuestion.Text.Trim();
                question.TypeQuestion = "shortanswer";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;
               if (questionBl.AddQuestion(question))
                {
                    answer.ContentAnswer = txt_AnswerContent.Text.Trim();
                    answer.Check = 1;
                    answer.IDQuestion = questionBl.MaxIDQuestion();
                    answer.IDCatalogue = IDCat;
                    questionBl.AddAnswer(answer);

                    //Show notify
                    //notifyIcon1.Icon = SystemIcons.Information;
                    //notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                    //notifyIcon1.ShowBalloonTip(2000);
                    MessageBox.Show("Thêm câu hỏi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Close form
                    Form FindForm = this.FindForm();
                    FindForm.Close();
                }
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
            if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "" || txt_AnswerContent.Text.Trim() == "")
            {
                if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "")
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
                question.QuestionTitle = txt_NameQuestion.Text.Trim();
                question.NameQuestion = txt_ContentQuestion.Text.Trim();
                question.TypeQuestion = "shortanswer";
                question.IDCatalogue = IDCat;
                question.Date = DateTime.Now;

                if (questionBl.AddQuestion(question))
                {
                    answer.ContentAnswer = txt_AnswerContent.Text.Trim();
                    answer.Check = 1;
                    answer.IDQuestion = questionBl.MaxIDQuestion();
                    answer.IDCatalogue = IDCat;
                    questionBl.AddAnswer(answer);

                    //Show notify
                    //notifyIcon1.Icon = SystemIcons.Information;
                    //notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công.";
                    //notifyIcon1.ShowBalloonTip(2000);
                    MessageBox.Show("Thêm câu hỏi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Refesh form
                    txt_ContentQuestion.Text = "";
                    txt_AnswerContent.Text = "";
                }
                
            }
        }
    }
}

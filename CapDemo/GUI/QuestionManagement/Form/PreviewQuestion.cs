using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class PreviewQuestion : Form
    {
        public PreviewQuestion()
        {
            InitializeComponent();
        }

        string questionPreview;

        public string QuestionPreview
        {
            get { return questionPreview; }
            set { questionPreview = value; }
        }
        List<string> answerPreview = new List<string>();
        public List<string> AnswerPreview
        {
            get { return answerPreview; }
            set { answerPreview = value; }
        }
        private void PreviewQuestion_Load(object sender, EventArgs e)
        {
            lbl_QuestionContent.Text = questionPreview;
            if (answerPreview.Count == 2)
            {
                for (int i = 0; i < answerPreview.Count; i++)
                {
                    ShowAnswer showanswer = new ShowAnswer();
                    showanswer.rtxt_Answer.Text = answerPreview.ElementAt(i).ToString();
                    showanswer.Size = new System.Drawing.Size(flp_AnswerQuiz.Width / 2 - 10, flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)answerPreview.Count)) - 10);
                    showanswer.lbl_labelAnswer.Text = Convert.ToChar(65 + i).ToString() + ".";
                    flp_AnswerQuiz.Controls.Add(showanswer);
                }
            }
            else
            {
                for (int i = 0; i < answerPreview.Count; i++)
                {
                    ShowAnswer showanswer = new ShowAnswer();
                    showanswer.rtxt_Answer.Text = answerPreview.ElementAt(i).ToString();
                    showanswer.Size = new System.Drawing.Size(flp_AnswerQuiz.Width / 2 - 10, flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)answerPreview.Count / 2)) - 10);
                    showanswer.lbl_labelAnswer.Text = Convert.ToChar(65 + i).ToString() + ".";
                    flp_AnswerQuiz.Controls.Add(showanswer);
                }
            }
            

            PlayerAnswer PlayerAnswer = new PlayerAnswer();
            PlayerAnswer.lbl_TeamName.Text = "GSC Team";
            PlayerAnswer.lbl_TeamAnswer.Text = "A";
            PlayerAnswer.lbl_Score.Text = "+20";
            PlayerAnswer.lbl_Score.Visible = true;
            PlayerAnswer.Location = new Point(PlayerAnswer.Location.X + flp_PlayerAnswers.Width/2 - PlayerAnswer.Width/2,PlayerAnswer.Location.Y+0);
            flp_PlayerAnswers.Controls.Add(PlayerAnswer);

            FixSizeText();
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FixSizeText()
        {
            //question
            string[] NewLine = lbl_QuestionContent.Text.Split('\n');

            if (lbl_QuestionContent.Text.Count() > 585 || NewLine.Length >= 9)
            {
                if (NewLine.Length > 13)
                {
                    lbl_QuestionContent.Font = new Font(lbl_QuestionContent.Font.FontFamily, 8.0f, lbl_QuestionContent.Font.Style);
                }
                else
                {
                    lbl_QuestionContent.Font = new Font(lbl_QuestionContent.Font.FontFamily, 12.0f, lbl_QuestionContent.Font.Style);
                }
                
            }
            else
            {
                if (lbl_QuestionContent.Text.Count() > 280 || NewLine.Length >= 7)
                {
                    lbl_QuestionContent.Font = new Font(lbl_QuestionContent.Font.FontFamily, 15.0f, lbl_QuestionContent.Font.Style);
                }
                else
                {
                    lbl_QuestionContent.Font = new Font(lbl_QuestionContent.Font.FontFamily, 20.0f, lbl_QuestionContent.Font.Style);
                }
            }

            //answer
            int row = 0;
            int temp = 0;
            foreach (ShowAnswer ShowAnswer in flp_AnswerQuiz.Controls)
            {
                string[] Newline1 = ShowAnswer.rtxt_Answer.Text.Split('\n');
                temp = Newline1.Length;
                if (temp >= row)
                {
                    row = temp;
                }

            }

            if (row <= 3)
            {
                foreach (ShowAnswer ShowAnswer in flp_AnswerQuiz.Controls)
                {
                    ShowAnswer.rtxt_Answer.Font = new Font(ShowAnswer.rtxt_Answer.Font.FontFamily, 14.0f, ShowAnswer.rtxt_Answer.Font.Style);
                }
            }
            else
            {
                if (row == 4)
                {
                    foreach (ShowAnswer ShowAnswer in flp_AnswerQuiz.Controls)
                    {
                        ShowAnswer.rtxt_Answer.Font = new Font(ShowAnswer.rtxt_Answer.Font.FontFamily, 12.0f, ShowAnswer.rtxt_Answer.Font.Style);
                    }
                }
                else
                {
                    if (row == 5)
                    {
                        foreach (ShowAnswer ShowAnswer in flp_AnswerQuiz.Controls)
                        {
                            ShowAnswer.rtxt_Answer.Font = new Font(ShowAnswer.rtxt_Answer.Font.FontFamily, 10.0f, ShowAnswer.rtxt_Answer.Font.Style);
                        }
                    }
                    else
                    {
                        foreach (ShowAnswer ShowAnswer in flp_AnswerQuiz.Controls)
                        {
                            ShowAnswer.rtxt_Answer.Font = new Font(ShowAnswer.rtxt_Answer.Font.FontFamily, 8.0f, ShowAnswer.rtxt_Answer.Font.Style);
                        }
                    }
                }
            }
        }
    }
}

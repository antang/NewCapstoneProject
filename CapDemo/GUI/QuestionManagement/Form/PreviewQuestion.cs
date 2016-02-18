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

            for (int i = 0; i < answerPreview.Count; i++)
            {
                ShowAnswer showanswer = new ShowAnswer();
                showanswer.rtxt_Answer.Text = answerPreview.ElementAt(i).ToString();
                showanswer.Size = new System.Drawing.Size(flp_AnswerQuiz.Width / 2 - 10, flp_AnswerQuiz.Height / (int)(Math.Ceiling((double)answerPreview.Count / 2)) - 10);
                showanswer.lbl_labelAnswer.Text = Convert.ToChar(65 + i).ToString() + ".";
                flp_AnswerQuiz.Controls.Add(showanswer);
            }
        }
    }
}

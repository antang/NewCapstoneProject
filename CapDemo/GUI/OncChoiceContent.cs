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

namespace CapDemo.GUI
{
    public partial class OncChoiceContent : UserControl
    {
        public OncChoiceContent()
        {
            InitializeComponent();
        }
        public OncChoiceContent(string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
        }

        int i = 0;
        private void btn_AddAnswer_Click(object sender, EventArgs e)
        { 
            OneChoiceAnswer one_choice_answer = new OneChoiceAnswer();
            i++;
            one_choice_answer.Tag = i;
            one_choice_answer.ID_Answer = i;
            one_choice_answer.onDelete += one_choice_answer_onDelete;
            one_choice_answer.onCheck += one_choice_answer_onCheck;
            flp_Answer.Controls.Add(one_choice_answer);
            
        }

        void one_choice_answer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (OneChoiceAnswer item in flp_Answer.Controls)
            {
                if (item.ID_Answer != answerID)
                {
                    item.rad_1.Checked = false;
                }

            }
        }

        void one_choice_answer_onDelete(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (OneChoiceAnswer item in flp_Answer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_Answer.Controls.Remove(item); 
                }
               
            }
        }
        QuestionBL questionBl = new QuestionBL();
        Question question = new Question();
        private string p;

        private void btn_save_Click(object sender, EventArgs e)
        {
            QuestionBL questionBl = new QuestionBL();
            Question question = new Question();
            Answer answer = new Answer();

            question.NameQuestion = txt_QuestionName.Text;
            question.TypeQuestion = p;
            question.IDCatalogue =Convert.ToInt32(comboBox1.SelectedItem);
            questionBl.AddQuestion(question);

            foreach (OneChoiceAnswer item in flp_Answer.Controls)
            {
                answer.ContentAnswer = item.textBox1.Text;
                answer.IsCorrect = item.rad_1.Checked;
                answer.IDQuestion = questionBl.MaxIDQuestion();
                questionBl.AddAnswer(answer);
            }
        }

        private void OncChoiceContent_Load(object sender, EventArgs e)
        {
            //CatalogueBL CatBL = new CatalogueBL();
            //List<DO.Catalogue> CatList;
            //CatList = CatBL.GetCatalogue();
            //if (CatList != null)
            //    for (int i = 0; i < CatList.Count; i++)
            //    {
            //        comboBox1.Items.Add(CatList.ElementAt(i).IDCatalogue);
            //    }

            QuestionBL questionBL = new QuestionBL();
            List<DO.Question> CatList;
            CatList = questionBL.GetQuestion();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    comboBox1.Items.Add(CatList.ElementAt(i).IDQuestion);
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            Question question = new Question();
            QuestionList = QuestionBL.GetQuestion();
            if (QuestionList != null)
            {
                for (int i = 0; i < QuestionList.Count; i++)
                {
                    if (QuestionList.ElementAt(i).IDQuestion == Convert.ToInt32(comboBox1.SelectedItem))
                    {
                        txt_QuestionName.Text = QuestionList.ElementAt(i).NameQuestion;
                    }
                    
                }

                List<DO.Answer> AnswerList;
                Answer answer = new Answer();
                question.IDQuestion = Convert.ToInt32(comboBox1.SelectedItem);
                AnswerList = QuestionBL.GetAnswerByQuestionID(question);
                if (AnswerList != null)
                {
                    for (int j = 0; j < AnswerList.Count; j++)
                    {
                        OneChoiceAnswer one = new OneChoiceAnswer();
                        one.textBox1.Text = AnswerList.ElementAt(j).ContentAnswer;
                        one.rad_1.Checked = AnswerList.ElementAt(j).IsCorrect;
                        flp_Answer.Controls.Add(one);
                    }
                }
            }

            

        }


    }
}

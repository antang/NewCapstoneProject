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
    public partial class CopyQuestion : Form
    {
        public CopyQuestion()
        {
            InitializeComponent();
        }

        public CopyQuestion(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
        //LOAD FORM
        private void CopyQuestion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    if (CatList.ElementAt(i).IDCatalogue != IDCatalogue)
                    {
                        this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                    }
                }
        }
        int IDCatSelected;
        private int IDQuestion;
        private int IDCatalogue;
        //SAVE QUESTION
        private void btn_SaveCopy_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                //GET ID CATALOGUE AFTER SELECT COMMOBOX
                CatalogueBL CatBL = new CatalogueBL();
                List<DO.Catalogue> CatList;
                CatList = CatBL.GetCatalogue();
                if (CatList != null)
                    for (int i = 0; i < CatList.Count; i++)
                    {
                        if (CatList.ElementAt(i).NameCatalogue == cmb_Catalogue.SelectedItem.ToString())
                        {
                            IDCatSelected = Convert.ToInt32(CatList.ElementAt(i).IDCatalogue);
                        }
                    }
                //SAVE QUESTION
                QuestionBL QuestionBL = new QuestionBL();
                List<DO.Question> QuestionList;
                QuestionList = QuestionBL.GetQuestion();
                if (QuestionList != null)
                    for (int i = 0; i < QuestionList.Count; i++)
                    {
                        if (QuestionList.ElementAt(i).IDQuestion == IDQuestion)
                        {
                            Question question = new Question();
                            question.NameQuestion = QuestionList.ElementAt(i).NameQuestion;
                            question.TypeQuestion = QuestionList.ElementAt(i).TypeQuestion;
                            question.IDCatalogue = IDCatSelected;
                            question.Date = DateTime.Now;
                            QuestionBL.AddQuestion(question);
                        }
                    }

                Question Question = new Question();
                Question.IDQuestion = IDQuestion;
                List<DO.Answer> AnswerList;
                AnswerList = QuestionBL.GetAnswerByQuestionID(Question);
                if (AnswerList != null)
                    for (int i = 0; i < AnswerList.Count; i++)
                    {
                        if (AnswerList.ElementAt(i).IDQuestion == IDQuestion)
                        {
                            Answer answer = new Answer();
                            answer.ContentAnswer = AnswerList.ElementAt(i).ContentAnswer;
                            answer.IsCorrect = (bool)AnswerList.ElementAt(i).IsCorrect;
                            answer.IDQuestion = QuestionBL.MaxIDQuestion();
                            answer.IDCatalogue = IDCatSelected;
                            QuestionBL.AddAnswer(answer);

                        }
                    }
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //EXIT FORM
        private void btn_CancelCopy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

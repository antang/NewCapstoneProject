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

namespace CapDemo.GUI.User_Controls
{
    public partial class MoveQuestion : Form
    {
        private int IDQuestion;
        private int IDCatalogue;

        public MoveQuestion()
        {
            InitializeComponent();
        }

        public MoveQuestion(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
        //LOAD CATALOGUE TO COMMOBOX
        private void MoveQuestion_Load(object sender, EventArgs e)
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
        //SAVE QUESTION
        private void btn_SaveMove_Click(object sender, EventArgs e)
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
                //ADD QUESTION
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
                //ADD ANSWER
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
                //DELETE QUESTION
                QuestionBL.DeleteAnswerByIDQuestion(Question);
                QuestionBL.DeleteQuestionByID(Question);

                //Notify
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Chuyển câu hỏi sang chủ đề \"" + cmb_Catalogue.SelectedItem.ToString()+"\" thành công";
                notifyIcon1.ShowBalloonTip(2000);
                this.Close();
	        }else
	        {
                MessageBox.Show("Vui lòng chọn chủ đề!","Cảnh Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
	        }
        }
        //EXIT FORM
        private void btn_CancelMove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

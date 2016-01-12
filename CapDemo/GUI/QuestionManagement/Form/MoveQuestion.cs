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

        public MoveQuestion()
        {
            InitializeComponent();
        }

        public MoveQuestion(string IDCatIDQuestion)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCatIDQuestion = IDCatIDQuestion;
        }

        //LOAD CATALOGUE TO COMMOBOX
        string[] IdQ;
        private void MoveQuestion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();

            string[] BothID = IDCatIDQuestion.Trim().Split(' ');
            string[] IdC = new string[BothID.Length];
            IdQ = new string[BothID.Length];
            for (int i = 0; i < BothID.Length; i++)
            {
                string[] ID = BothID[i].Trim().Split('+');
                IdC[i] = ID[0].ToString();
                IdQ[i] = ID[1].ToString();
            }
            
            if (CatList != null)
                for (int j = 0; j < CatList.Count; j++)
                {
                    int count = 0;
                    for (int i = 0; i < IdC.Length; i++)
                    {
                        if (CatList.ElementAt(j).IDCatalogue != Convert.ToInt32(IdC[i].ToString()))
                        {
                            count++;
                        }
                    }
                    if (count == IdC.Length)
                    {
                        cmb_Catalogue.Items.Add(CatList.ElementAt(j).NameCatalogue);
                    }
                }   
        }

        int IDCatSelected;
        private string IDCatIDQuestion;
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
                {
                    for (int i = 0; i < QuestionList.Count; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < IdQ.Length; j++)
                        {
                            if (QuestionList.ElementAt(i).IDQuestion == Convert.ToInt32(IdQ[j]))
                            {
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            //QuestionBL questionbl = new QuestionBL();
                            Question question = new Question();
                            question.IDQuestion = QuestionList.ElementAt(i).IDQuestion;
                            question.IDCatalogue = IDCatSelected;
                            QuestionBL.EditIDCatalogueAnswerByIDQuestion(question);
                            QuestionBL.EditIDCatalogueQuestionByIDQuestion(question);
                            //question.QuestionTitle = QuestionList.ElementAt(i).QuestionTitle;
                            //question.NameQuestion = QuestionList.ElementAt(i).NameQuestion;
                            //question.TypeQuestion = QuestionList.ElementAt(i).TypeQuestion;
                            //question.IDCatalogue = IDCatSelected;
                            //IDQuestion = QuestionList.ElementAt(i).IDQuestion;
                            //question.Date = DateTime.Now;
                            //if (QuestionBL.AddQuestion(question)==true)
                            //{
                            //    //ADD ANSWER
                            //    Question Question = new Question();
                            //    Question.IDQuestion = IDQuestion;
                            //    List<DO.Answer> AnswerList;
                            //    AnswerList = QuestionBL.GetAnswerByQuestionID(Question);
                            //    if (AnswerList != null)
                            //        for (int ii = 0; ii < AnswerList.Count; ii++)
                            //        {
                            //            if (AnswerList.ElementAt(ii).IDQuestion == IDQuestion)
                            //            {
                            //                Answer answer = new Answer();
                            //                answer.ContentAnswer = AnswerList.ElementAt(ii).ContentAnswer;
                            //                if (AnswerList.ElementAt(ii).IsCorrect == true)
                            //                {
                            //                    answer.Check = 1;
                            //                }
                            //                else
                            //                {
                            //                    answer.Check = 0;
                            //                }
                            //                answer.IDQuestion = QuestionBL.MaxIDQuestion();
                            //                answer.IDCatalogue = IDCatSelected;
                            //                QuestionBL.AddAnswer(answer);
                            //            }
                            //        }
                            //    //DELETE QUESTION
                            //    QuestionBL.DeleteAnswerByIDQuestion(Question);
                            //    QuestionBL.DeleteQuestionByID(Question);  
                            //}
                        }
                    }
                    //Notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Chuyển câu hỏi sang chủ đề \"" + cmb_Catalogue.SelectedItem.ToString() + "\" thành công.";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
	        }else
	        {
                MessageBox.Show("Vui lòng chọn chủ đề!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }
        //EXIT FORM
        private void btn_CancelMove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

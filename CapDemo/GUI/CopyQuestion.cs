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
        int IDCatSelected;
        private int IDQuestion;
        private string IDCatIDQuestion;
        public CopyQuestion()
        {
            InitializeComponent();
        }

        public CopyQuestion(string IDCatIDQuestion)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCatIDQuestion = IDCatIDQuestion;
        }
        //LOAD FORM
        string[] IdQ;
        private void CopyQuestion_Load(object sender, EventArgs e)
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
                            Question question = new Question();
                            question.NameQuestion = QuestionList.ElementAt(i).NameQuestion;
                            question.TypeQuestion = QuestionList.ElementAt(i).TypeQuestion;
                            question.IDCatalogue = IDCatSelected;
                            IDQuestion = QuestionList.ElementAt(i).IDQuestion;
                            question.Date = DateTime.Now;
                            QuestionBL.AddQuestion(question);

                            //ADD ANSWER
                            Question Question = new Question();
                            Question.IDQuestion = IDQuestion;
                            List<DO.Answer> AnswerList;
                            AnswerList = QuestionBL.GetAnswerByQuestionID(Question);
                            if (AnswerList != null)
                                for (int ii = 0; ii < AnswerList.Count; ii++)
                                {
                                    if (AnswerList.ElementAt(ii).IDQuestion == IDQuestion)
                                    {
                                        Answer answer = new Answer();
                                        answer.ContentAnswer = AnswerList.ElementAt(ii).ContentAnswer;
                                        answer.IsCorrect = (bool)AnswerList.ElementAt(ii).IsCorrect;
                                        answer.IDQuestion = QuestionBL.MaxIDQuestion();
                                        answer.IDCatalogue = IDCatSelected;
                                        QuestionBL.AddAnswer(answer);
                                    }
                                }
                        }
                    }
                    //Notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Sao Chép câu hỏi sang chủ đề \"" + cmb_Catalogue.SelectedItem.ToString() + "\" thành công.";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
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

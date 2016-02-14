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

namespace CapDemo
{
    public partial class Question_Screen : Form
    {
        public Question_Screen()
        {
            InitializeComponent();
        }

        private void Question_Screen_Load(object sender, EventArgs e)
        {

        }
        //Player Player = new Player();
        Contest Contest = new Contest();
        Phase Phase = new Phase();
        Question Question = new Question();

        //Log Log = new Log();
        //LogBL logBL = new LogBL();

        PlayerBL PlayerBL = new PlayerBL();
        ContestBL ContestBL = new ContestBL();
        PhaseBL PhaseBL = new PhaseBL();
        PhaseQuestionBL PhaseQuestionBl = new PhaseQuestionBL();
        QuestionBL QuestionBL = new QuestionBL();
        RecordBL RecordBL = new RecordBL();
        public bool ShowQuestionSub(int id)
        {
            //declare
            List<CapDemo.DO.Phase> ListPhase;
            List<CapDemo.DO.Question> ListQuestion;
            List<CapDemo.DO.Answer> ListAnswer;
            int idquestion = 0;
            int a = 65;
            Phase.IDQuestion = id;

            ListPhase = PhaseQuestionBl.getquestionByIDQuestion(Phase);
            //if (ListPhase != null)
            //{
            try
            {
                idquestion = ListPhase.ElementAt(0).IDQuestion;

                //show question in phase
                Question.IDQuestion = idquestion;
                ListQuestion = QuestionBL.GetQuestionByID(Question);
                ListAnswer = QuestionBL.GetAnswerByQuestionID(Question);
                //////show question on audience screen
                if (ListQuestion != null)
                {
                    /////display question on audience screen
                    lbl_Content.Text = ListQuestion.ElementAt(0).NameQuestion + "\n";
                    /////question is onechoice type
                    if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "onechoice")
                    {
                        for (int h = 0; h < ListAnswer.Count; h++)
                        {
                            lbl_Content.Text +="\n"+ Convert.ToChar(a + h).ToString() + ". " + ListAnswer.ElementAt(h).ContentAnswer;
                        }
                    }
                    else
                    {   //question is multichoice type
                        if (ListQuestion.ElementAt(0).TypeQuestion.ToLower() == "multichoice")
                        {
                            for (int h = 0; h < ListAnswer.Count; h++)
                            {
                                lbl_Content.Text += "\n" + Convert.ToChar(a + h).ToString() + ". " + ListAnswer.ElementAt(h).ContentAnswer;
                            }
                        }
                        else
                        {
                            //question is short answer type
                            lbl_Content.Text = ListAnswer.ElementAt(0).ContentAnswer;
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //} 
        }
    }
}

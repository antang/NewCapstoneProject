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

namespace CapDemo.GUI.User_Controls
{
    public partial class Question_ShortAnswer_1 : UserControl
    {
        public Question_ShortAnswer_1()
        {
            InitializeComponent();
        }
        private static Question_ShortAnswer_1 _instance;
        public static Question_ShortAnswer_1 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Question_ShortAnswer_1();
                return _instance;
            }
        }

        private void Question_ShortAnswer_1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                }
            txt_Date.Text = DateTime.Now.ToString("d");
        }
        int IDCat;
        //SAVE QUESTION
        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                //GET CATALOGUE ID
                this.Dock = DockStyle.Fill;
                CatalogueBL CatBL = new CatalogueBL();
                List<DO.Catalogue> CatList;
                CatList = CatBL.GetCatalogue();
                if (CatList != null)
                    for (int i = 0; i < CatList.Count; i++)
                    {
                        if (CatList.ElementAt(i).NameCatalogue == cmb_Catalogue.SelectedItem.ToString())
                        {
                            IDCat = Convert.ToInt32(CatList.ElementAt(i).IDCatalogue);
                        }
                    }
                //SAVE QUESTION
                QuestionBL questionBl = new QuestionBL();
                Question question = new Question();
                Answer answer = new Answer();
                if (txt_ContentQuestion.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    question.NameQuestion = txt_ContentQuestion.Text;
                    question.TypeQuestion = "shortanswer";
                    question.IDCatalogue = IDCat;
                    questionBl.AddQuestion(question);

                    if (txt_AnswerContent.Text != "")
                    {
                        answer.ContentAnswer = txt_AnswerContent.Text;
                        answer.IsCorrect = true;
                        answer.IDQuestion = questionBl.MaxIDQuestion();
                        answer.IDCatalogue = IDCat;
                        questionBl.AddAnswer(answer);
                    }
                    //Show notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    //Close form
                    Form FindForm = this.FindForm();
                    FindForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //EXIT FORM
        private void btn_CancelQuestion_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE QUESTION AND CONTINUE ADD QUESTION
        private void btn_SaveAndCreateNewQuestion_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                //GET CATALOGUE ID
                this.Dock = DockStyle.Fill;
                CatalogueBL CatBL = new CatalogueBL();
                List<DO.Catalogue> CatList;
                CatList = CatBL.GetCatalogue();
                if (CatList != null)
                    for (int i = 0; i < CatList.Count; i++)
                    {
                        if (CatList.ElementAt(i).NameCatalogue == cmb_Catalogue.SelectedItem.ToString())
                        {
                            IDCat = Convert.ToInt32(CatList.ElementAt(i).IDCatalogue);
                        }
                    }
                //SAVE QUESTION
                QuestionBL questionBl = new QuestionBL();
                Question question = new Question();
                Answer answer = new Answer();
                if (txt_ContentQuestion.Text == "" || txt_AnswerContent.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    question.NameQuestion = txt_ContentQuestion.Text;
                    question.TypeQuestion = "shortanswer";
                    question.IDCatalogue = IDCat;
                    questionBl.AddQuestion(question);

                    if (txt_AnswerContent.Text != "")
                    {
                        answer.ContentAnswer = txt_AnswerContent.Text;
                        answer.IsCorrect = true;
                        answer.IDQuestion = questionBl.MaxIDQuestion();
                        answer.IDCatalogue = IDCat;
                        questionBl.AddAnswer(answer);
                    }
                    //Show notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công.";
                    notifyIcon1.ShowBalloonTip(2000);
                    //Refesh form
                    txt_ContentQuestion.Text = "";
                    txt_AnswerContent.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

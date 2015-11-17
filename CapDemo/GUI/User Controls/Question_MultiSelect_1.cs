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
    public partial class Question_MultiSelect_1 : UserControl
    {
        public Question_MultiSelect_1()
        {
            InitializeComponent();
        }
        //LOAD USER CONTROL
        private static Question_MultiSelect_1 _instance;
        public static Question_MultiSelect_1 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Question_MultiSelect_1();
                return _instance;
            }
        }
        //LOAD CATALOGUE INTO COMMOBOX
        private void Question_MultiSelect_1_Load(object sender, EventArgs e)
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
            //AUTO ADD 4 ANSWER
            for (int j = 0; j < 4; j++)
            {
                Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
                i++;
                MultiSelectAnswer.Tag = i;
                MultiSelectAnswer.ID_Answer = i;
                MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
                MultiSelectAnswer.onCheck += MultiSelectAnswer_onCheck;
                MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
                flp_addAnswer.Controls.Add(MultiSelectAnswer);
            }
        }

        int i = 0;
        int a = 65;
        //ADD ANSWER
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_MultiSelect MultiSelectAnswer = new Answer_MultiSelect();
            i++;
            MultiSelectAnswer.Tag = i;
            MultiSelectAnswer.ID_Answer = i;
            MultiSelectAnswer.onDelete += MultiSelectAnswer_onDelete;
            MultiSelectAnswer.onCheck += MultiSelectAnswer_onCheck;
            MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a).ToString();
            flp_addAnswer.Controls.Add(MultiSelectAnswer);
            for (int j = 0; j < flp_addAnswer.Controls.Count; j++)
            {
                MultiSelectAnswer.chk_Check.Text = Convert.ToChar(a + j).ToString();
            }
        }
        //Eventhanlder check radio button
        void MultiSelectAnswer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer != answerID)
                {
                    item.chk_Check.Checked = false;
                }
            }
        }
        //Eventhanlder click Del button
        void MultiSelectAnswer_onDelete(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_addAnswer.Controls.Remove(item);
                }
            }
        }
        int IDCat;
        //SAVE QUESTION
        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                //GET CATALOGUE ID
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
                    question.TypeQuestion = "multiplechoice";
                    question.IDCatalogue = IDCat;
                    questionBl.AddQuestion(question);

                    foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                    {
                        if (item.txt_AnswerContent.Text != "")
                        {
                            answer.ContentAnswer = item.txt_AnswerContent.Text;
                            answer.IsCorrect = item.chk_Check.Checked;
                            answer.IDQuestion = questionBl.MaxIDQuestion();
                            answer.IDCatalogue = IDCat;
                            questionBl.AddAnswer(answer);
                        }
                    }
                    //Show notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    //Close Form
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
                if (txt_ContentQuestion.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    question.NameQuestion = txt_ContentQuestion.Text;
                    question.TypeQuestion = "multiplechoice";
                    question.IDCatalogue = IDCat;
                    questionBl.AddQuestion(question);

                    foreach (Answer_MultiSelect item in flp_addAnswer.Controls)
                    {
                        if (item.txt_AnswerContent.Text != "")
                        {
                            answer.ContentAnswer = item.txt_AnswerContent.Text;
                            answer.IsCorrect = item.chk_Check.Checked;
                            answer.IDQuestion = questionBl.MaxIDQuestion();
                            answer.IDCatalogue = IDCat;
                            questionBl.AddAnswer(answer);
                        }
                    }
                    //Show notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    //Refesh form
                    this.txt_ContentQuestion.Text = "";
                    flp_addAnswer.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

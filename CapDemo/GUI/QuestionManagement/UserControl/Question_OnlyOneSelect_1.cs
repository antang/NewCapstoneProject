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
    public partial class Question_OnlyOneSelect_1 : UserControl
    {
        public Question_OnlyOneSelect_1()
        {
            InitializeComponent();
        }
        //LOAD THIS USER CONTROL
        private static Question_OnlyOneSelect_1 _instance;
        public static Question_OnlyOneSelect_1 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Question_OnlyOneSelect_1();
                return _instance;
            }
        }
        //LOAD CATALOGUE TO COMMOBOX
        private void Question_OnlyOneSelect_1_Load(object sender, EventArgs e)
        {
            txt_ContentQuestion.Text = "";
            flp_addAnswer.Controls.Clear();
            cmb_Catalogue.Items.Clear();
            cmb_Catalogue.Text = "";
            this.Dock = DockStyle.Fill;
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                }
            if (cmb_Catalogue.Items.Count >0 )
            {
                cmb_Catalogue.SelectedIndex = 0;
            }
            
            txt_Date.Text = DateTime.Now.ToString("d");
            //AUTO ADD 4 ANSWER
            for (int j = 0; j < 4; j++)
            {
                Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
                i++;
                OneChoiceAnswer.Tag = i;
                OneChoiceAnswer.ID_Answer = i;
                OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
                OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
                OneChoiceAnswer.rad_check.Text = Convert.ToChar(a + j).ToString();
                flp_addAnswer.Controls.Add(OneChoiceAnswer);
            }
        }
        //EXIT FORM
        private void btn_CancelQuestion_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //check answer null
        public bool checkAnswerEmpty()
        {
            int i = 0;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.txt_Answercontent.Text.Trim() == "")
                {
                    i++;
                }
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Check blank correct answer
        public bool checkBlankCorrectAnswer()
        {
            int i = 0;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.rad_check.Checked == true)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
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
                int NumAnswer = flp_addAnswer.Controls.Count;
                if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "" || NumAnswer < 2)
                {
                    if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "")
                    {

                        MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập hơn một đáp án!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (checkAnswerEmpty() == true)
                    {
                        MessageBox.Show("Không lưu câu hỏi vì tồn tại đáp án rỗng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (checkBlankCorrectAnswer()==true)
                        {
                            MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            QuestionBL questionBl = new QuestionBL();
                            Question question = new Question();
                            Answer answer = new Answer();

                            question.QuestionTitle = txt_NameQuestion.Text.Trim();
                            question.NameQuestion = txt_ContentQuestion.Text.Trim();
                            question.TypeQuestion = "onechoice";
                            question.IDCatalogue = IDCat;
                            question.Date = DateTime.Now;
                            if (questionBl.AddQuestion(question))
                            {
                                foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
                                {
                                    if (item.txt_Answercontent.Text.Trim() != "")
                                    {
                                        answer.ContentAnswer = item.txt_Answercontent.Text.Trim();
                                        if (item.rad_check.Checked == true)
                                        {
                                            answer.Check = 1;
                                        }
                                        else
                                        {
                                            answer.Check = 0;
                                        }
                                        answer.IDQuestion = questionBl.MaxIDQuestion();
                                        answer.IDCatalogue = IDCat;
                                        questionBl.AddAnswer(answer);
                                    }
                                }
                                //notifyIcon1.Icon = SystemIcons.Information;
                                //notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công.";
                                //notifyIcon1.ShowBalloonTip(2000);
                                MessageBox.Show("Thêm câu hỏi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form FindForm = this.FindForm();
                                FindForm.Close();
                            }
                        }   
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int i = 0;
        int a = 65;
        //ADD ANSWER
        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
            i++;
            OneChoiceAnswer.Tag = i;
            OneChoiceAnswer.ID_Answer = i;
            OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
            OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
            OneChoiceAnswer.rad_check.Text = Convert.ToChar(a).ToString();
            flp_addAnswer.Controls.Add(OneChoiceAnswer);
            for (int j = 0; j < flp_addAnswer.Controls.Count; j++)
            {
                OneChoiceAnswer.rad_check.Text = Convert.ToChar(a + j).ToString();
            }
        }
        //Eventhanlder check radio button
        void OneChoiceAnswer_onCheck(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer != answerID)
                {
                    item.rad_check.Checked = false;
                }
            }
        }
        //Eventhanlder click Del button
        void OneChoiceAnswer_onDelete(object sender, EventArgs e)
        {
            int answerID = (e as MyEventArgs).IDAnswer;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                if (item.ID_Answer == answerID)
                {
                    flp_addAnswer.Controls.Remove(item);
                }
            }
            int alp = 0;
            foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
            {
                item.rad_check.Text = Convert.ToChar(a + alp++).ToString();
            }
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

                int NumAnswer = flp_addAnswer.Controls.Count;
                if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim()=="" || NumAnswer < 2)
                {
                    if (txt_ContentQuestion.Text.Trim() == "" || txt_NameQuestion.Text.Trim() == "")
                    {

                        MessageBox.Show("Vui lòng nhập thông tin câu hỏi trước khi lưu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập hơn một đáp án!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (checkAnswerEmpty() == true)
                    {
                        MessageBox.Show("Không lưu câu hỏi vì tồn tại đáp án rỗng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (checkBlankCorrectAnswer()==true)
                        {
                            MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //SAVE QUESTION
                            QuestionBL questionBl = new QuestionBL();
                            Question question = new Question();
                            Answer answer = new Answer();

                            question.QuestionTitle = txt_NameQuestion.Text.Trim();
                            question.NameQuestion = txt_ContentQuestion.Text.Trim();
                            question.TypeQuestion = "onechoice";
                            question.IDCatalogue = IDCat;
                            question.Date = DateTime.Now;
                            if (questionBl.AddQuestion(question))
                            {
                                foreach (Answer_OnlyOneSelect item in flp_addAnswer.Controls)
                                {
                                    if (item.txt_Answercontent.Text.Trim() != "")
                                    {
                                        answer.ContentAnswer = item.txt_Answercontent.Text.Trim();
                                        if (item.rad_check.Checked == true)
                                        {
                                            answer.Check = 1;
                                        }
                                        else
                                        {
                                            answer.Check = 0;
                                        }
                                        answer.IDQuestion = questionBl.MaxIDQuestion();
                                        answer.IDCatalogue = IDCat;
                                        questionBl.AddAnswer(answer);
                                    }
                                }
                                //Show notify
                                //notifyIcon1.Icon = SystemIcons.Information;
                                //notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công.";
                                //notifyIcon1.ShowBalloonTip(2000);
                                MessageBox.Show("Thêm câu hỏi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Refesh form
                                this.txt_ContentQuestion.Text = "";
                                flp_addAnswer.Controls.Clear();

                                //AUTO ADD 4 ANSWER
                                for (int j = 0; j < 4; j++)
                                {
                                    Answer_OnlyOneSelect OneChoiceAnswer = new Answer_OnlyOneSelect();
                                    i++;
                                    OneChoiceAnswer.Tag = i;
                                    OneChoiceAnswer.ID_Answer = i;
                                    OneChoiceAnswer.onDelete += OneChoiceAnswer_onDelete;
                                    OneChoiceAnswer.onCheck += OneChoiceAnswer_onCheck;
                                    OneChoiceAnswer.rad_check.Text = Convert.ToChar(a + j).ToString();
                                    flp_addAnswer.Controls.Add(OneChoiceAnswer);
                                }
                            }
                        }  
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề cho câu hỏi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //New Catalogue
        private void lbl_NewCatalogue_Click(object sender, EventArgs e)
        {
            CreateCatalogueNew NewCatalogue = new CreateCatalogueNew();
            NewCatalogue.ShowDialog();
            cmb_Catalogue.Items.Clear();
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                }
            if (cmb_Catalogue.Items.Count > 0)
            {
                cmb_Catalogue.SelectedIndex = cmb_Catalogue.Items.Count - 1;
            }
        }
    }
}

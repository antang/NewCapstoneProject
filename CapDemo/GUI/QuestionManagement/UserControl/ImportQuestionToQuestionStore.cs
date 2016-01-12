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
    public partial class ImportQuestionToQuestionStore : UserControl
    {
        private int IDCat;
        private string NameCat;

        public ImportQuestionToQuestionStore()
        {
            InitializeComponent();
        }

        public ImportQuestionToQuestionStore(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }

        //LOAD CATALOGUE TO COMMOBOX AND LOAD USER CONTROL
        private void ImportQuestionToQuestionStore_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    if (CatList.ElementAt(i).NameCatalogue != NameCat)
                    {
                        this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                    }
                }
        }
        //Copy Question
        public void CopyQuestion()
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    question.QuestionTitle = row.Cells["QuestionTitle"].Value.ToString();
                    question.NameQuestion = row.Cells["QuestionName"].Value.ToString();
                    question.TypeQuestion = row.Cells["QuestionType"].Value.ToString();
                    question.IDCatalogue = IDCat;
                    question.Date = DateTime.Now;

                    if (questionBL.AddQuestion(question))
                    {
                        question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                        List<DO.Answer> AnswerList;
                        AnswerList = questionBL.GetAnswerByQuestionID(question);
                        if (AnswerList != null)
                        {
                            for (int i = 0; i < AnswerList.Count; i++)
                            {
                                answer.ContentAnswer = AnswerList.ElementAt(i).ContentAnswer;
                                if (AnswerList.ElementAt(i).IsCorrect == true)
                                {
                                    answer.Check = 1;
                                }
                                else
                                {
                                    answer.Check = 0;
                                }
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                questionBL.AddAnswer(answer);
                            }
                        }
                    }
                    
                }
            }
        }
        //MOVE Question
        public int countcheck()
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    count++;
                }
            }
            return count;
        }
        public void MoveQuestion()
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    question.IDCatalogue = IDCat;
                    question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                    questionBL.EditIDCatalogueAnswerByIDQuestion(question);
                    questionBL.EditIDCatalogueQuestionByIDQuestion(question);
                    ////add question
                    //question.QuestionTitle = row.Cells["QuestionTitle"].Value.ToString();
                    //question.NameQuestion = row.Cells["QuestionName"].Value.ToString();
                    //question.TypeQuestion = row.Cells["QuestionType"].Value.ToString();
                    //question.IDCatalogue = IDCat;
                    //question.Date = DateTime.Now;
                    //if (questionBL.AddQuestion(question))
                    //{
                    //    //add answer
                    //    question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                    //    List<DO.Answer> AnswerList;
                    //    AnswerList = questionBL.GetAnswerByQuestionID(question);
                    //    if (AnswerList != null)
                    //    {
                    //        for (int i = 0; i < AnswerList.Count; i++)
                    //        {
                    //            answer.ContentAnswer = AnswerList.ElementAt(i).ContentAnswer;
                    //            if (AnswerList.ElementAt(i).IsCorrect == true)
                    //            {
                    //                answer.Check = 1;
                    //            }
                    //            else
                    //            {
                    //                answer.Check = 0;
                    //            }
                    //            answer.IDQuestion = questionBL.MaxIDQuestion();
                    //            answer.IDCatalogue = IDCat;
                    //            questionBL.AddAnswer(answer);
                    //        }
                    //    }
                    //    //Delete answer and question
                    //    questionBL.DeleteAnswerByIDQuestion(question);
                    //    questionBL.DeleteQuestionByID(question);
                    //}
                }
            }
        }

        //EXIT
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }

        //SAVE QUESTION
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                if (rad_Copy.Checked == true)
                {
                    if (countcheck() > 0)
                    {
                        CopyQuestion();
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Sao chép câu hỏi từ chủ đề " + cmb_Catalogue.SelectedItem.ToString() + "thành công.";
                        notifyIcon1.ShowBalloonTip(2000);
                        Form FindForm = this.FindForm();
                        FindForm.Close();
                    }
                    else
                    {
                        //notifyIcon1.Icon = SystemIcons.Warning;
                        //notifyIcon1.BalloonTipText = "Không có câu hỏi nào được chọn để sao chép đến chủ đề.";
                        //notifyIcon1.ShowBalloonTip(2000);
                        MessageBox.Show("Vui lòng chọn câu hỏi trước khi lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rad_Move.Checked == true)
                {
                    if (countcheck() > 0)
                    {
                        MoveQuestion();
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Di chuyển câu hỏi từ chủ đề " + cmb_Catalogue.SelectedItem.ToString() + "thành công.";
                        notifyIcon1.ShowBalloonTip(2000);
                        Form FindForm = this.FindForm();
                        FindForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn câu hỏi trước khi lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề trước khi lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //SELECT ITEM IN COMMOBOX
        private void cmb_Catalogue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgv_Question.Columns.Clear();
            Catalogue catalogue = new Catalogue();
            CatalogueBL CatBL = new CatalogueBL();

            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    if (cmb_Catalogue.SelectedItem.ToString() == CatList.ElementAt(i).NameCatalogue)
                    {
                        catalogue.IDCatalogue = CatList.ElementAt(i).IDCatalogue;
                    }
                }

            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestionByCatalogue(catalogue);
            if (QuestionList != null)
            {
                dgv_Question.DataSource = QuestionList;
                dgv_Question.Columns["IDCatalogue"].Visible = false;
                dgv_Question.Columns["IDQuestion"].Visible = false;
                dgv_Question.Columns["AnswerContent"].Visible = false;
                dgv_Question.Columns["Catalogue"].Visible = false;
                dgv_Question.Columns["NameCatalogue"].Visible = false;
                dgv_Question.Columns["Date"].Visible = false;
            }

            chk_CheckAll.Checked = false;
        }
        //Select all item
        private void chk_CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CheckAll.Checked == true)
            {
                foreach (DataGridViewRow row in dgv_Question.Rows)
                {
                    row.Cells["Check"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv_Question.Rows)
                {
                    row.Cells["Check"].Value = null;
                }
            }
        }
    }
}

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
    public partial class ImportQuestion : Form
    {
        public ImportQuestion()
        {
            InitializeComponent();
        }
        //LOAD FORM
        private void ImportQuestion_Load(object sender, EventArgs e)
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
        }
        //LOAD FILE QUESTION
        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            QuestionBL questionBL = new QuestionBL();
            OpenFileDialog OpenFile = new OpenFileDialog();
            DialogResult Result = OpenFile.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    dgv_Question.Columns.Clear();
                    QuestionBL QuestionBL = new QuestionBL();

                    List<DO.Question> QuestionList;
                    QuestionList = QuestionBL.GetFileXML(OpenFile.FileName);
                    txt_FilePath.Text = OpenFile.FileName;
                    if (QuestionList != null)
                        dgv_Question.DataSource = QuestionList;

                    dgv_Question.Columns["IDCatalogue"].Visible = false;
                    dgv_Question.Columns["IDQuestion"].Visible = false;
                    dgv_Question.Columns["NameCatalogue"].Visible = false;
                    dgv_Question.Columns["AnswerContent"].Visible = false;
                    dgv_Question.Columns["Date"].Visible = false;

                    dgv_Question.Columns["Sequence"].HeaderText = "STT";
                    dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
                    dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";

                    dgv_Question.Columns["Sequence"].ReadOnly = true;
                    dgv_Question.Columns["NameQuestion"].ReadOnly = true;
                    dgv_Question.Columns["TypeQuestion"].ReadOnly = true;

                    dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
                    CheckColumn.Name = "Check";
                    dgv_Question.Columns.Add(CheckColumn);
                    dgv_Question.Columns["Check"].HeaderText = "Chọn";
                    dgv_Question.Columns["Check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception)
                {
                    txt_FilePath.Text = "";
                    MessageBox.Show("Tải file không thành công. Bạn phải chọn File .XML", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }   
            }
        }
        //SAVE QUESTION
        int IDCat;
        private void btn_SaveImport_Click(object sender, EventArgs e)
        {
            if (cmb_Catalogue.SelectedItem != null)
            {
                if (txt_FilePath.Text == "")
                {
                    notifyIcon1.Icon = SystemIcons.Warning;
                    notifyIcon1.BalloonTipText = "Vui lòng chọn đường dẫn đến tập tin.";
                    notifyIcon1.ShowBalloonTip(2000);
                }
                else
                {
                    int CheckQuestion = 0;
                    Question question = new Question();
                    Answer answer = new Answer();
                    QuestionBL questionBL = new QuestionBL();

                    foreach (DataGridViewRow row in dgv_Question.Rows)
                    {
                        if (row.Cells["Check"].Value != null)
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
                            if (row.Cells["NameQuestion"].Value.ToString().Trim() != "" && row.Cells["AnswerContent"].Value.ToString().Trim() != "")
                            {
                                if (row.Cells["TypeQuestion"].Value.ToString().Trim() == "shortanswer")
                                {
                                    string[] AnswerContent = row.Cells["AnswerContent"].Value.ToString().Trim().Split(new string[] { "</answer>" }, StringSplitOptions.None);
                                    int NumAnswer = AnswerContent.Length - 1;
                                    if (NumAnswer == 1)
                                    {
                                        string[] AnswerItem = AnswerContent[0].Split(new string[] { "---" }, StringSplitOptions.None);

                                        if (AnswerItem[1].ToString().Trim() != "")
                                        {
                                            question.NameQuestion = row.Cells["NameQuestion"].Value.ToString().Trim();
                                            question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString().Trim();
                                            question.IDCatalogue = IDCat;
                                            question.Date = DateTime.Now;
                                            questionBL.AddQuestion(question);

                                            answer.IsCorrect = true;
                                            answer.ContentAnswer = AnswerItem[1].ToString().Trim();
                                            answer.IDQuestion = questionBL.MaxIDQuestion();
                                            answer.IDCatalogue = IDCat;
                                            questionBL.AddAnswer(answer);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì đáp án là rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì dạng câu hỏi trả lời ngắn chỉ cho phép 1 đáp án!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    string[] AnswerContent = row.Cells["AnswerContent"].Value.ToString().Trim().Split(new string[] { "</answer>" }, StringSplitOptions.None);
                                    int Numanswer = AnswerContent.Length - 1;
                                    if (Numanswer < 2)
                                    {
                                        MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Câu trắc nghiệm phải có 2 đáp án trở lên.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        int empty = 0;
                                        for (int i = 0; i < AnswerContent.Length - 1; i++)
                                        {
                                            string[] AnswerItem = AnswerContent[i].Split(new string[] { "---" }, StringSplitOptions.None);
                                            if (AnswerItem[1].ToString().Trim() == "")
                                            {
                                                empty++;
                                            }
                                        }

                                        if (empty > 0)
                                        {
                                            MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì đáp án là rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            //ADD QUESTION MULTIPLE CHOICE
                                            question.NameQuestion = row.Cells["NameQuestion"].Value.ToString().Trim();
                                            question.TypeQuestion = "";
                                            question.IDCatalogue = IDCat;
                                            question.Date = DateTime.Now;
                                            questionBL.AddQuestion(question);

                                            int countMultipleChoice = 0;

                                            for (int i = 0; i < AnswerContent.Length - 1; i++)
                                            {
                                                string[] AnswerItem = AnswerContent[i].Split(new string[] { "---" }, StringSplitOptions.None);

                                                if (Convert.ToInt32(AnswerItem[0].ToString().Trim()) > 0)
                                                {
                                                    answer.IsCorrect = true;
                                                    answer.ContentAnswer = AnswerItem[1].ToString().Trim();
                                                    answer.IDQuestion = questionBL.MaxIDQuestion();
                                                    answer.IDCatalogue = IDCat;
                                                    questionBL.AddAnswer(answer);
                                                    countMultipleChoice++;
                                                }
                                                else
                                                {
                                                    answer.IsCorrect = false;
                                                    answer.ContentAnswer = AnswerItem[1].ToString().Trim();
                                                    answer.IDQuestion = questionBL.MaxIDQuestion();
                                                    answer.IDCatalogue = IDCat;
                                                    questionBL.AddAnswer(answer);
                                                }//end if
                                            }//end for
                                            //UPDATE QUESTION TYPE
                                            if (countMultipleChoice == 1)
                                            {
                                                question.TypeQuestion = "onechoice";
                                                question.IDQuestion = questionBL.MaxIDQuestion();
                                                questionBL.EditQuestionTypebyID(question);
                                            }
                                            else
                                            {
                                                question.TypeQuestion = "multiplechoice";
                                                question.IDQuestion = questionBL.MaxIDQuestion();
                                                questionBL.EditQuestionTypebyID(question);
                                            }
                                        }
                                    }
                                }//end else  
                                CheckQuestion++;
                            }
                            else
                            {
                                MessageBox.Show("Hệ thống không lưu câu hỏi rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }//end foreach

                    //CLOSE FORM
                    if (CheckQuestion > 0)
                    {
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Nhập câu hỏi từ file thành công.";
                        notifyIcon1.ShowBalloonTip(2000);
                        CheckQuestion = 0;
                    }
                    Form FindForm = this.FindForm();
                    FindForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chủ đề!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //EXIT FORM
        private void btn_ExitImport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

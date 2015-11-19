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
    public partial class ImportQuestions : UserControl
    {
        private int IDCat;
        private string NameCat;

        public ImportQuestions()
        {
            InitializeComponent();
        }

        public ImportQuestions(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }

        private void ImportQuestions_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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
                    dataGridView1.Columns.Clear();
                    QuestionBL QuestionBL = new QuestionBL();

                    List<DO.Question> QuestionList;
                    QuestionList = QuestionBL.GetFileXML(OpenFile.FileName);
                    txt_FilePath.Text = OpenFile.FileName;
                    if (QuestionList != null)
                        dataGridView1.DataSource = QuestionList;

                    dataGridView1.Columns["IDCatalogue"].Visible = false;
                    dataGridView1.Columns["IDQuestion"].Visible = false;
                    dataGridView1.Columns["NameCatalogue"].Visible = false;
                    dataGridView1.Columns["AnswerContent"].Visible = false;
                    dataGridView1.Columns["TypeQuestion"].Visible = false;
                    dataGridView1.Columns["Date"].Visible = false;

                    dataGridView1.Columns["Sequence"].HeaderText = "STT";
                    dataGridView1.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
                    dataGridView1.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";

                    dataGridView1.Columns["Sequence"].ReadOnly = true;
                    dataGridView1.Columns["NameQuestion"].ReadOnly = true;
                    dataGridView1.Columns["TypeQuestion"].ReadOnly = true;

                    dataGridView1.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
                    CheckColumn.Name = "Check";
                    dataGridView1.Columns.Add(CheckColumn);
                    dataGridView1.Columns["Check"].HeaderText = "Chọn";
                    dataGridView1.Columns["Check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception)
                {
                    txt_FilePath.Text = "";
                    MessageBox.Show("Tải file không thành công. Bạn phải chọn File .XML", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }
        //EXIT FORM
        private void btn_ExitImport_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE QUESTION
        
        private void btn_SaveImport_Click(object sender, EventArgs e)
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

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Check"].Value != null)
                    {
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
    }
}

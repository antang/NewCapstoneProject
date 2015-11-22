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
using System.IO;
using System.Diagnostics;

namespace CapDemo.GUI.User_Controls
{
    public partial class ImportQuestions : UserControl
    {
        private int IDCat;
        private string NameCat;
        FileAccess Fa;

        public ImportQuestions()
        {
            InitializeComponent();
            Fa = new FileAccess();
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
                    if (Path.GetExtension(OpenFile.FileName) == ".txt" || Path.GetExtension(OpenFile.FileName) == ".xml")
                    {
                        if (Path.GetExtension(OpenFile.FileName) == ".txt")
                        {
                            dataGridView1.Columns.Clear();
                            QuestionBL QuestionBL = new QuestionBL();

                            List<DO.Question> QuestionList;
                            QuestionList = QuestionBL.GetFileTXT(OpenFile.FileName);
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
                        else
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
                    }
                    else
                    {
                        txt_FilePath.Text = "";
                        MessageBox.Show("Tải file không thành công. Bạn phải chọn File .XML hoặc .TXT.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    txt_FilePath.Text = "";
                    MessageBox.Show("Tải file không thành công. Bạn định dạng file không hợp lý.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                chk_CheckAll.Checked = false;
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
            try
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
                            if (row.Cells["NameQuestion"].Value.ToString().Trim() != "" && row.Cells["AnswerContent"].Value.ToString().Trim() != "" && row.Cells["TypeQuestion"].Value.ToString().Trim() != "")
                            {
                                if (row.Cells["TypeQuestion"].Value.ToString().Trim() == "shortanswer" || row.Cells["TypeQuestion"].Value.ToString().Trim() == "multichoice")
                                {
                                    if (row.Cells["TypeQuestion"].Value.ToString().Trim() == "shortanswer")
                                    {
                                        string[] AnswerContent = row.Cells["AnswerContent"].Value.ToString().Trim().Split(new string[] { "</answer>" }, StringSplitOptions.None);
                                        int NumAnswer = AnswerContent.Length - 1;
                                        if (NumAnswer == 1)
                                        {
                                            string[] AnswerItem = AnswerContent[0].Split(new string[] { "---" }, StringSplitOptions.None);

                                            if (AnswerItem[1].ToString().Trim() != "" && AnswerItem[0].ToString().Trim() != "")
                                            {
                                                int PointAnswer;
                                                bool isNum = int.TryParse(AnswerItem[0].ToString().Trim(), out PointAnswer);
                                                if (isNum = true && Convert.ToInt32(AnswerItem[0].ToString().Trim()) > 0)
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
                                                    MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì đáp án không hợp lệ.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }

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
                                                int PointAnswer;
                                                bool isNum = int.TryParse(AnswerItem[0].ToString().Trim(), out PointAnswer);
                                                if (AnswerItem[1].ToString().Trim() == "" || AnswerItem[0].ToString().Trim() == "" || isNum == false)
                                                {
                                                    empty++;
                                                }
                                            }

                                            if (empty > 0)
                                            {
                                                MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì đáp án là không hợp lệ.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                                    question.TypeQuestion = "multichoice";
                                                    question.IDQuestion = questionBL.MaxIDQuestion();
                                                    questionBL.EditQuestionTypebyID(question);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hệ thống không lưu câu hỏi \"" + row.Cells["NameQuestion"].Value.ToString() + "\". Vì chủ đề không tồn tại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch (Exception)
            {
                MessageBox.Show("Hệ thống lưu không thành công vì do định dạng file không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void btn_DownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Template.txt";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    string text = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Template.txt";

                    foreach (var line in File.ReadAllLines(text))
                    {
                        writer.WriteLine(line);
                    }
                    writer.Dispose();
                    writer.Close();
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Tải tập tin mẫu thành công: " + save.FileName + "";
                    notifyIcon1.ShowBalloonTip(2000);
                }
            }
            catch (Exception)
            {
            }    
        }
        //Check all row
        private void chk_CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CheckAll.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Check"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Check"].Value = null;
                }
            }
        }
    }
}

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
                dataGridView1.Columns.Clear();
                QuestionBL QuestionBL = new QuestionBL();

                List<DO.Question> QuestionList;
                QuestionList = QuestionBL.GetFile(OpenFile.FileName);
                txt_FilePath.Text = OpenFile.FileName;
                if (QuestionList != null)
                    dataGridView1.DataSource = QuestionList;


                dataGridView1.Columns["IDCatalogue"].Visible = false;
                dataGridView1.Columns["IDQuestion"].Visible = false;
                dataGridView1.Columns["NameCatalogue"].Visible = false;
                dataGridView1.Columns["AnswerContent"].Visible = false;
                dataGridView1.Columns["Date"].Visible = false;

                dataGridView1.Columns["Sequence"].HeaderText = "STT";
                dataGridView1.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
                dataGridView1.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";

                dataGridView1.Columns["Sequence"].ReadOnly=true;
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
        //EXIT FORM
        private void btn_ExitImport_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE QUESTION
        private void btn_SaveImport_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NameQuestion"].Value != null && row.Cells["Check"].Value != null)
                {
                    question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                    question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                    question.IDCatalogue = IDCat;
                    question.Date = DateTime.Now;
                    questionBL.AddQuestion(question);

                    string[] AnswerItem = row.Cells["AnswerContent"].Value.ToString().Trim().Split('\t');
                    for (int i = 0; i < AnswerItem.Length; i++)
                    {
                        if (AnswerItem[i].Contains("[T]") == true)
                        {
                            answer.IsCorrect = true;
                            answer.ContentAnswer = AnswerItem[i].Replace("[T]", "").ToString();
                            answer.IDQuestion = questionBL.MaxIDQuestion();
                            answer.IDCatalogue = IDCat;
                            questionBL.AddAnswer(answer);
                        }
                        else
                        {
                            answer.IsCorrect = false;
                            answer.ContentAnswer = AnswerItem[i].Replace("[F]", "").ToString();
                            answer.IDQuestion = questionBL.MaxIDQuestion();
                            answer.IDCatalogue = IDCat;
                            questionBL.AddAnswer(answer);
                        }//end if
                    }//end for
                }//end if
            }//end foreach
            //CLOSE FORM
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
    }
}

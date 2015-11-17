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
                //dgv_Question.Columns.Clear();
                //QuestionBL QuestionBL = new QuestionBL();

                //List<DO.Question> QuestionList;
                ////QuestionList = QuestionBL.GetFile(OpenFile.FileName);
                //txt_FilePath.Text = OpenFile.FileName;
                //if (QuestionList != null)
                //    dgv_Question.DataSource = QuestionList;


                //dgv_Question.Columns["IDCatalogue"].Visible = false;
                //dgv_Question.Columns["IDQuestion"].Visible = false;
                //dgv_Question.Columns["NameCatalogue"].Visible = false;
                //dgv_Question.Columns["AnswerContent"].Visible = false;
                //dgv_Question.Columns["Date"].Visible = false;

                //dgv_Question.Columns["Sequence"].HeaderText = "STT";
                //dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
                //dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";

                //dgv_Question.Columns["Sequence"].ReadOnly = true;
                //dgv_Question.Columns["NameQuestion"].ReadOnly = true;
                //dgv_Question.Columns["TypeQuestion"].ReadOnly = true;

                //dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
                //CheckColumn.Name = "Check";
                //dgv_Question.Columns.Add(CheckColumn);
                //dgv_Question.Columns["Check"].HeaderText = "Chọn";
                //dgv_Question.Columns["Check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        //SAVE QUESTION
        int IDCatSelected;
        private void btn_SaveImport_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();

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
                //SAVE EACH QUESTION AFTER CHECKED
                foreach (DataGridViewRow row in dgv_Question.Rows)
                {
                    //SAVE QUESTION
                    if (row.Cells["NameQuestion"].Value != null && row.Cells["Check"].Value != null)
                    {
                        question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                        question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                        question.IDCatalogue = IDCatSelected;
                        question.Date = DateTime.Now;
                        questionBL.AddQuestion(question);
                        //SAVE ANSWER
                        string[] AnswerItem = row.Cells["AnswerContent"].Value.ToString().Trim().Split('\t');
                        for (int i = 0; i < AnswerItem.Length; i++)
                        {
                            if (AnswerItem[i].Contains("[T]") == true)
                            {
                                answer.IsCorrect = true;
                                answer.ContentAnswer = AnswerItem[i].Replace("[T]", "").ToString();
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCatSelected;
                                questionBL.AddAnswer(answer);
                            }
                            else
                            {
                                answer.IsCorrect = false;
                                answer.ContentAnswer = AnswerItem[i].Replace("[F]", "").ToString();
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCatSelected;
                                questionBL.AddAnswer(answer);
                            }//end if
                        }//end for
                    }//end if
                }//end foreach
                //CLOSE FORM
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "Thêm câu hỏi thành công";
                notifyIcon1.ShowBalloonTip(2000);
                Form FindForm = this.FindForm();
                FindForm.Close();
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

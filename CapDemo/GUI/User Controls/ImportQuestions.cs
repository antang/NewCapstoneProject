﻿using System;
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
using System.Xml;

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
                //string test= QuestionBL.GetFile(OpenFile.FileName);
                txt_FilePath.Text = OpenFile.FileName;
                if (QuestionList != null)
                //textBox1.Text = test;

                    dataGridView1.DataSource = QuestionList;


                dataGridView1.Columns["IDCatalogue"].Visible = false;
                dataGridView1.Columns["IDQuestion"].Visible = false;
                dataGridView1.Columns["NameCatalogue"].Visible = false;
                dataGridView1.Columns["AnswerContent"].Visible = false;
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
        //EXIT FORM
        private void btn_ExitImport_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
        //SAVE QUESTION
        int countShortAnswer = 0;
        int countMultipleChoice= 0;
        private void btn_SaveImport_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NameQuestion"].Value != null && row.Cells["Check"].Value != null)
                {
                    if (row.Cells["TypeQuestion"].Value.ToString() == "shortanswer")
                    {
                        question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                        question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                        question.IDCatalogue = IDCat;
                        question.Date = DateTime.Now;
                        questionBL.AddQuestion(question);

                        string[] AnswerContent = row.Cells["AnswerContent"].Value.ToString().Trim().Split(new string[] { "</answer>" }, StringSplitOptions.None);
                        for (int i = 0; i < AnswerContent.Length - 1; i++)
                        {
                            string[] AnswerItem = AnswerContent[i].Split(new string[] { "---" }, StringSplitOptions.None);

                            if (Convert.ToInt32(AnswerItem[0].ToString()) > 0)
                            {
                                answer.IsCorrect = true;
                                answer.ContentAnswer = AnswerItem[1].ToString();
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                countShortAnswer++;
                                if (countShortAnswer <= 1)
                                {
                                    questionBL.AddAnswer(answer);
                                }
                                else
                                {
                                    MessageBox.Show("Không lưu đáp án ("+AnswerItem[1].ToString()+"). Vì Câu hỏi dạng trả lời ngắn không được hơn 1 đáp án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }//end for
                        countShortAnswer = 0;
                    }
                    else
                    {
                        //ADD QUESTION MULTIPLE CHOICE
                        question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                        question.TypeQuestion = "";
                        question.IDCatalogue = IDCat;
                        question.Date = DateTime.Now;
                        questionBL.AddQuestion(question);

                        string[] AnswerContent = row.Cells["AnswerContent"].Value.ToString().Trim().Split(new string[] { "</answer>" }, StringSplitOptions.None);
                        for (int i = 0; i < AnswerContent.Length - 1; i++)
                        {
                            string[] AnswerItem = AnswerContent[i].Split(new string[] { "---" }, StringSplitOptions.None);

                            if (Convert.ToInt32(AnswerItem[0].ToString()) > 0)
                            {
                                answer.IsCorrect = true;
                                answer.ContentAnswer = AnswerItem[1].ToString();
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                questionBL.AddAnswer(answer);
                                countMultipleChoice++;
                            }
                            else
                            {
                                answer.IsCorrect = false;
                                answer.ContentAnswer = AnswerItem[1].ToString();
                                answer.IDQuestion = questionBL.MaxIDQuestion();
                                answer.IDCatalogue = IDCat;
                                questionBL.AddAnswer(answer);
                            }//end if
                        }//end for
                        //UPDATE QUESTION TYPE
                        if (countMultipleChoice==1)
                        {
                            question.TypeQuestion = "OneChoice";
                            question.IDQuestion = questionBL.MaxIDQuestion();
                            questionBL.EditQuestionTypebyID(question);
                        }
                        else
                        {
                            question.TypeQuestion = "MultipleChoice";
                            question.IDQuestion = questionBL.MaxIDQuestion();
                            questionBL.EditQuestionTypebyID(question);
                        }
                        countMultipleChoice = 0;
                    }//end else   
                }//end if
            }//end foreach

            //CLOSE FORM
            Form FindForm = this.FindForm();
            FindForm.Close();
        }
    }
}

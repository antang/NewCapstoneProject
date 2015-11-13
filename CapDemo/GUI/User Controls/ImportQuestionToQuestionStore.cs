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

        public void CopyQuestion()
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["check"].Value != null)
                {

                    question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                    question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                    question.IDCatalogue = IDCat;
                    questionBL.AddQuestion(question);

                    question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                    List<DO.Answer> AnswerList;
                    AnswerList = questionBL.GetAnswerByQuestionID(question);
                    if (AnswerList != null)
                    {
                        for (int i = 0; i < AnswerList.Count; i++)
                        {
                            answer.ContentAnswer = AnswerList.ElementAt(i).ContentAnswer;
                            answer.IsCorrect = AnswerList.ElementAt(i).IsCorrect;
                            answer.IDQuestion = questionBL.MaxIDQuestion();
                            questionBL.AddAnswer(answer);
                        }
                    }
                }
            }
        }

        //EXIT
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form FindForm = this.FindForm();
            FindForm.Close();
            //ImportFileForm.Dispose();
        }

        //SAVE QUESTION
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rad_Copy.Checked ==true)
            {
                CopyQuestion();
            }
        }
        //SELECT ITEM IN COMMOBOX
        private void cmb_Catalogue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Question.Columns.Clear();
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
            }

            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["IDQuestion"].Visible = false;
            dgv_Question.Columns["AnswerContent"].Visible = false;

            dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            

            dgv_Question.Columns["Sequence"].HeaderText = "STT";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";

            DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
            CheckColumn.Name = "Check";       
            dgv_Question.Columns.Add(CheckColumn);
            dgv_Question.Columns["Check"].HeaderText = "Chọn";
            dgv_Question.Columns["Check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}

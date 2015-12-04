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

namespace CapDemo
{
    public partial class GetQuestion : Form
    {
        private int idPhase;
        private int idContest;

        public GetQuestion()
        {
            InitializeComponent();
        }

        public GetQuestion(int idPhase, int idContest)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.idPhase = idPhase;
            this.idContest = idContest;
        }

        private void GetQuestion_Load(object sender, EventArgs e)
        {
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                        this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
                }
        }
        //Select question follow catalogue
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
            dgv_Question.Columns["Date"].Visible = false;
            dgv_Question.Columns["NameCatalogue"].Visible = false;

            dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgv_Question.Columns["Sequence"].HeaderText = "STT";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";

            dgv_Question.Columns["Sequence"].ReadOnly = true;
            dgv_Question.Columns["TypeQuestion"].ReadOnly = true;
            dgv_Question.Columns["NameQuestion"].ReadOnly = true;
            dgv_Question.Columns["NameCatalogue"].ReadOnly = true;

            DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
            CheckColumn.Name = "Check";
            dgv_Question.Columns.Add(CheckColumn);
            dgv_Question.Columns["Check"].HeaderText = "Chọn";
            dgv_Question.Columns["Check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            chk_CheckAll.Checked = false;
        }
        //check all question
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
        //Copy Question
        public void CopyQuestion()
        {
            Phase Phase = new Phase();
            PhaseQuestionBL PhaseQuestionBL = new PhaseQuestionBL();
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    Phase.IDPhase = idPhase;
                    //Phase.Question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                    Phase.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                    PhaseQuestionBL.AddPhaseQuestion(Phase);
                }
            }
        }
        //check duplicate question
        public bool checkDuplicate()
        {
            Phase phase = new Phase();
            phase.IDContest = idContest;
            PhaseQuestionBL PhaseQuestionBL = new PhaseQuestionBL();
            List<Phase> ListPhase;
            ListPhase = PhaseQuestionBL.getquestionByIDContest(phase);

            int count = 0;
            foreach (DataGridViewRow row in dgv_Question.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    
                    if (ListPhase != null)
                    {
                        for (int i = 0; i < ListPhase.Count; i++)
                        {
                            if (ListPhase.ElementAt(i).IDQuestion == Convert.ToInt32(row.Cells["IDQuestion"].Value))
                            {
                                row.DefaultCellStyle.BackColor = Color.LightCoral;
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //save question
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == false)
            {
                CopyQuestion();
                this.Close();
            }
            else
            {
                MessageBox.Show("Các câu hỏi được đánh dấu đã tồn tại trong phần thi.","Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

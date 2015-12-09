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
    public partial class ViewQuestionInCatalogue : Form
    {
        private int iDCat;
        private string NameCat;
        public int IDCat
        {
            get { return iDCat; }
            set { iDCat = value; }
        }
        

        public ViewQuestionInCatalogue()
        {
            InitializeComponent();
        }

        public ViewQuestionInCatalogue(int pIDCat, string pNameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.iDCat = pIDCat;
            this.NameCat = pNameCat;
        }
        //LOAD FORM
        private void ViewQuestionInCatalogue_Load(object sender, EventArgs e)
        {
            this.txt_NameCatalogue.Text = NameCat;
            LoadQuestion();
        }
        //LOAD QUESTION
        public void LoadQuestion()
        {
            QuestionBL QuestionBL = new QuestionBL();
            Catalogue Cat = new Catalogue();
            Cat.IDCatalogue = IDCat;
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestionByCatalogue(Cat);
            if (QuestionList != null)
                dgv_Question1.DataSource = QuestionList;

            dgv_Question1.Columns["IDCatalogue"].Visible = false;
            dgv_Question1.Columns["IDQuestion"].Visible = false;
            dgv_Question1.Columns["AnswerContent"].Visible = false;
            dgv_Question1.Columns["Catalogue"].Visible = false;
            dgv_Question1.Columns["Date"].Visible = false;

            dgv_Question1.Columns["Sequence"].HeaderText = "STT";
            dgv_Question1.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question1.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";
            dgv_Question1.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";

            dgv_Question1.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question1.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question1.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //EXIT FORM
        private void btn_CancelViewQuestione_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //DOUBLE CLICK CELL TO OPEN DETAIL QUESTION
        private void dgv_Question_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IDQuestion = Convert.ToInt32(dgv_Question1.CurrentRow.Cells["IDQuestion"].Value);
                //int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
                string TypeQuestion = dgv_Question1.CurrentRow.Cells["TypeQuestion"].Value.ToString();
                string OneSelect = "onechoice";
                string MultiSelect = "multichoice";
                string ShortAnswer = "shortanswer";
                if (TypeQuestion.ToLower() == OneSelect)
                {
                    ViewQuestion eqms = new ViewQuestion(IDQuestion, iDCat);
                    eqms.ShowDialog();
                    LoadQuestion();
                }
                if (TypeQuestion.ToLower() == MultiSelect)
                {
                    ViewQuestionMultiple eqms = new ViewQuestionMultiple(IDQuestion, iDCat);
                    eqms.ShowDialog();
                    LoadQuestion();
                }
                if (TypeQuestion.ToLower() == ShortAnswer)
                {
                    ViewQuestionShortAnswer eqms = new ViewQuestionShortAnswer(IDQuestion, iDCat);
                    eqms.ShowDialog();
                    LoadQuestion();
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void txt_SearchCatalogue_TextChanged(object sender, EventArgs e)
        {
            //QuestionBL questionBL = new QuestionBL();
            //List<DO.Question> ListQuestion = questionBL.GetQuestion();

            QuestionBL QuestionBL = new QuestionBL();
            Catalogue Cat = new Catalogue();
            Cat.IDCatalogue = IDCat;
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestionByCatalogue(Cat);
            //if (QuestionList != null)
                //dgv_Question1.DataSource = QuestionList;
            //loadQuestion();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(QuestionList);

            dgv_Question1.DataSource = dt;
            dt.DefaultView.RowFilter = string.Format("NameQuestion LIKE '%{0}%' or TypeQuestion LIKE '%{0}%' or NameCatalogue LIKE '%{0}%' or Sequence LIKE '%{0}%'", txt_SearchCatalogue.Text);

            dgv_Question1.Columns["IDCatalogue"].Visible = false;
            dgv_Question1.Columns["IDQuestion"].Visible = false;
            dgv_Question1.Columns["IDCatalogue"].Visible = false;
            dgv_Question1.Columns["AnswerContent"].Visible = false;
            dgv_Question1.Columns["AnswerList"].Visible = false;
            dgv_Question1.Columns["Date"].Visible = false;

            dgv_Question1.Columns["Sequence"].HeaderText = "STT";
            dgv_Question1.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question1.Columns["NameCatalogue"].HeaderText = "Tên chủ Đề";
            dgv_Question1.Columns["TypeQuestion"].HeaderText = "Loại Câu hỏi";

            dgv_Question1.Columns["Sequence"].ReadOnly = true;
            dgv_Question1.Columns["NameQuestion"].ReadOnly = false;
            dgv_Question1.Columns["NameCatalogue"].ReadOnly = true;
            dgv_Question1.Columns["TypeQuestion"].ReadOnly = true;

            dgv_Question1.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question1.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question1.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}

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
    public partial class DataManagement : UserControl
    {
        public DataManagement()
        {
            InitializeComponent();
        }
        //ADD Catalogue
        private void lbl_CreateCatalogue_Click(object sender, EventArgs e)
        {
            CreateCatalogueNew CreateCat = new CreateCatalogueNew();
            CreateCat.ShowDialog();
            LoadCat();
        }

        //LOAD Form
        private void DataManagement_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadCat();
            loadQuestion();
        }
        //LOAD Catalogue table from database
        public void LoadCat()
        {
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                dgv_Catalogue.DataSource = CatList;

            dgv_Catalogue.Columns["IDCatalogue"].Visible = false;
            dgv_Catalogue.Columns["Sequence"].HeaderText = "STT";
            dgv_Catalogue.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";
            dgv_Catalogue.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //LOAD QUESTION TABLE FROM DATABASE
        public void loadQuestion()
        {
            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestion();
            if (QuestionList != null)
                dgv_Question.DataSource = QuestionList;

            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["IDQuestion"].Visible = false;
            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["AnswerContent"].Visible = false;
            dgv_Question.Columns["Date"].Visible = false;

            dgv_Question.Columns["Sequence"].HeaderText= "STT";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên chủ Đề";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu hỏi";

            dgv_Question.Columns["Sequence"].ReadOnly = true;
            dgv_Question.Columns["NameQuestion"].ReadOnly = true;
            dgv_Question.Columns["NameCatalogue"].ReadOnly = true;
            dgv_Question.Columns["TypeQuestion"].ReadOnly = true;

            dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //ADD NEW QUESTION
        private void lbl_CreateQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestionNew CreateNewQuestion = new CreateQuestionNew();
            CreateNewQuestion.ShowDialog();
            loadQuestion();
        }

        private void lbl_ImportQuestion_Click(object sender, EventArgs e)
        {
            ImportQuestion iq = new ImportQuestion();
            iq.ShowDialog();
        }

        private void btn_CopyQuestion_Click(object sender, EventArgs e)
        {
            int IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
            int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
            CopyQuestion cq = new CopyQuestion(IDQuestion,IDCatalogue);
            cq.ShowDialog();
            loadQuestion();
        }
        //MOVE QUESTION
        private void btn_MoveQuestion_Click(object sender, EventArgs e)
        {
            int IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
            int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
            MoveQuestion mq = new MoveQuestion(IDQuestion, IDCatalogue);
            mq.ShowDialog();
            loadQuestion();
        }
        //EDIT QUESTION INFORMATION
        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            int IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
            int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
            string TypeQuestion = dgv_Question.CurrentRow.Cells["TypeQuestion"].Value.ToString();
            string OneSelect = "onechoice";
            string MultiSelect = "multiplechoice";
            string ShortAnswer = "shortanswer";
            if (TypeQuestion.ToLower()==OneSelect)
            {
                EditQuestion_OnlyOneSelect eqms = new EditQuestion_OnlyOneSelect(IDQuestion, IDCatalogue);
                eqms.ShowDialog();
            }
            if (TypeQuestion.ToLower()==MultiSelect)
            {
                    EditQuestion_MultiSelect eqms = new EditQuestion_MultiSelect(IDQuestion, IDCatalogue);
                    eqms.ShowDialog();
            }
            if (TypeQuestion.ToLower() == ShortAnswer)
            {
                EditQuestion_ShortAnswer eqms = new EditQuestion_ShortAnswer(IDQuestion, IDCatalogue);
                eqms.ShowDialog();
            }
            loadQuestion();
        }

        private void btn_ImportQuestion_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            ImportQuestionForCatalogue iqc = new ImportQuestionForCatalogue(IDCat, NameCat);
            iqc.ShowDialog();
            loadQuestion();
        }

        //VIEW Question
        private void btn_ViewQuestion_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            ViewQuestionInCatalogue ViewQuestion = new ViewQuestionInCatalogue(IDCat,NameCat);
            ViewQuestion.ShowDialog();
        }
        //EDIT Catalogue
        private void btn_EditCatalogue_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            if (NameCat.ToLower() == "unknow")
            {
                MessageBox.Show("Không được chỉnh sửa chủ đề "+"\"" + NameCat+"\"", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EditCatalogue EditCat = new EditCatalogue(IDCat, NameCat);
                EditCat.ShowDialog();
                LoadCat();
                loadQuestion();
            }        
        }
        //DELETE Catalogue
        private void btn_DeleteCatalogue_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            
            if (NameCat.ToLower() == "unknow")
            {
                MessageBox.Show("Không được xóa chủ đề " + "\"" + NameCat + "\"", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DeleteCatalogue DelCat = new DeleteCatalogue(IDCat, NameCat);
                DelCat.ShowDialog();
                LoadCat();
                loadQuestion();
            }
        }
        //CLICK CELL IN DATAGRIDVIEW TO SHOW GROUP CATALOGUE FUNCTION
        private void dgv_Catalogue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_CatalogueFunction.Visible = true;
        }
        //CLICK FORM TO HIDE GROUP CATALOGUE FUNCTION
        private void tbp_CatalogueManagement_MouseClick(object sender, MouseEventArgs e)
        {
            gb_CatalogueFunction.Visible = false;
        }
        //CLICK CELL IN DATAGRIDVIEW TO SHOW GROUP QUESTION FUNCTION
        private void dgv_Question_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_QuestionFunction.Visible = true;
        }
        //CLICK FORM TO HIDE GROUP QUESTION FUNCTION
        private void tbp_QuestionManagement_MouseClick(object sender, MouseEventArgs e)
        {
            gb_QuestionFunction.Visible = false;
        }
        //DELETE Question
        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            Question Question = new Question();
            QuestionBL QuestionBL = new QuestionBL();
            Question.IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
            QuestionBL.DeleteAnswerByIDQuestion(Question);
            QuestionBL.DeleteQuestionByID(Question);
            //Show notify
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipText = "Xóa Câu Hỏi Thành Công";
            notifyIcon1.ShowBalloonTip(2000);
            //Load question table
            loadQuestion();
        }
        //SWITCH TAB TO HIDE GROUP FUNCTION
        private void tbc_DataManagement_Click(object sender, EventArgs e)
        {
            gb_QuestionFunction.Visible = false;
            gb_CatalogueFunction.Visible = false;
        }
        //DOUBLE CLICK IN CATALOGUE DATAGRIDVIEW TO VIEW QUESTION
        private void dgv_Catalogue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            ViewQuestionInCatalogue ViewQuestion = new ViewQuestionInCatalogue(IDCat, NameCat);
            ViewQuestion.ShowDialog();
        }

    }
}

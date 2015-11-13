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
        
        private void lbl_CreateQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestionNew cqn = new CreateQuestionNew();
            cqn.ShowDialog();
        }

        private void lbl_ImportQuestion_Click(object sender, EventArgs e)
        {
            ImportQuestion iq = new ImportQuestion();
            iq.ShowDialog();
        }

        private void btn_CopyQuestion_Click(object sender, EventArgs e)
        {
            CopyQuestion cq = new CopyQuestion();
            cq.ShowDialog();
        }

        private void btn_MoveQuestion_Click(object sender, EventArgs e)
        {
            MoveQuestion mq = new MoveQuestion();
            mq.ShowDialog();
        }

        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            EditQuestion_MultiSelect eqms = new EditQuestion_MultiSelect();
            eqms.ShowDialog();
        }

        private void btn_ImportQuestion_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            ImportQuestionForCatalogue iqc = new ImportQuestionForCatalogue(IDCat, NameCat);
            iqc.ShowDialog();
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
            EditCatalogue EditCat = new EditCatalogue(IDCat,NameCat);
            EditCat.ShowDialog();
            LoadCat();
        }
        //DELETE Catalogue
        private void btn_DeleteCatalogue_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
            string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
            DeleteCatalogue DelCat = new DeleteCatalogue(IDCat, NameCat);
            DelCat.ShowDialog();
            LoadCat();
        }
    }
}

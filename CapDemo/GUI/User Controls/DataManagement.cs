using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI.User_Controls
{
    public partial class DataManagement : UserControl
    {
        public DataManagement()
        {
            InitializeComponent();
        }

        private void lbl_CreateCatalogue_Click(object sender, EventArgs e)
        {
            CreateCatalogueNew ccl = new CreateCatalogueNew();
            ccl.ShowDialog();
        }

        private void DataManagement_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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
            ImportQuestionForCatalogue iqc = new ImportQuestionForCatalogue();
            iqc.ShowDialog();
        }

        private void btn_ViewQuestion_Click(object sender, EventArgs e)
        {
            ViewQuestionInCatalogue vqic = new ViewQuestionInCatalogue();
            vqic.ShowDialog();
        }

        private void btn_EditCatalogue_Click(object sender, EventArgs e)
        {
            EditCatalogue ec = new EditCatalogue();
            ec.ShowDialog();
        }

        private void btn_DeleteCatalogue_Click(object sender, EventArgs e)
        {
            DeleteCatalogue dc = new DeleteCatalogue();
            dc.ShowDialog();
        }
    }
}

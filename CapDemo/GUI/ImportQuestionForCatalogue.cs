using CapDemo.BL;
using CapDemo.GUI.User_Controls;
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
    public partial class ImportQuestionForCatalogue : Form
    {
        private int iDCat;
        private string nameCat;
        public int IDCat
        {
            get { return iDCat; }
            set { iDCat = value; }
        }
        
        public string NameCat
        {
            get { return nameCat; }
            set { nameCat = value; }
        }
        public ImportQuestionForCatalogue()
        {
            InitializeComponent();
        }

        public ImportQuestionForCatalogue(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.iDCat = IDCat;
            this.nameCat = NameCat;
        }

        private void rdb_ImportToCatalogue_CheckedChanged(object sender, EventArgs e)
        {
            ImportQuestionToQuestionStore iqqs = new ImportQuestionToQuestionStore(IDCat,NameCat);
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(iqqs);
        }

        private void rdb_ImportToFile_CheckedChanged(object sender, EventArgs e)
        {
            ImportQuestions iq = new ImportQuestions(IDCat, NameCat);
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(iq);
        }

        private void rdb_ImportCreateNew_CheckedChanged(object sender, EventArgs e)
        {
            CreateQuestion cq = new CreateQuestion(IDCat, NameCat);
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(cq);
        }

        private void ImportQuestionForCatalogue_Load(object sender, EventArgs e)
        {
            txt_Catalogue.Text = NameCat;
            ImportQuestionToQuestionStore iqqs = new ImportQuestionToQuestionStore(IDCat, NameCat);
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(iqqs);
        }

    }
}

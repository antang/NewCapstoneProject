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
        ImportQuestionToQuestionStore iqqs = new ImportQuestionToQuestionStore();
        ImportQuestions iq = new ImportQuestions();
        CreateQuestion cq = new CreateQuestion();
        public ImportQuestionForCatalogue()
        {
            InitializeComponent();
        }

        private void rdb_ImportToCatalogue_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(iqqs);
        }

        private void rdb_ImportToFile_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(iq);
        }

        private void rdb_ImportCreateNew_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ImportQuestion.Controls.Clear();
            pnl_ImportQuestion.Controls.Add(cq);
        }

        private void ImportQuestionForCatalogue_Load(object sender, EventArgs e)
        {
            
        }

    }
}

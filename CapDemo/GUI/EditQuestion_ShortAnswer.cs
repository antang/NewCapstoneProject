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
    public partial class EditQuestion_ShortAnswer : Form
    {
        private int IDQuestion;
        private int IDCatalogue;

        public EditQuestion_ShortAnswer()
        {
            InitializeComponent();
        }

        public EditQuestion_ShortAnswer(int IDQuestion, int IDCatalogue)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDQuestion = IDQuestion;
            this.IDCatalogue = IDCatalogue;
        }
    }
}

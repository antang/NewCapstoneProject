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
    public partial class CreateQuestionNew : Form
    {
        public CreateQuestionNew()
        {
            InitializeComponent();
        }

        private void CreateQuestionNew_Load(object sender, EventArgs e)
        {
            CreateQuestion cq = new CreateQuestion();
            pnl_ImportQuestion.Controls.Add(cq);
        }
    }
}

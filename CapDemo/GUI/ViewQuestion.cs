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
    public partial class ViewQuestion : Form
    {
        public ViewQuestion()
        {
            InitializeComponent();
        }

        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

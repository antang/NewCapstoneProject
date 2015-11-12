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
    public partial class Question_MultiSelect : UserControl
    {
        public Question_MultiSelect()
        {
            InitializeComponent();
        }

        private void Question_MultiSelect_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_MultiSelect ams = new Answer_MultiSelect();
            flp_addAnswer.Controls.Add(ams);
        }
    }
}

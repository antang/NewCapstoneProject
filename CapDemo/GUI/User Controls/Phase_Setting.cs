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
    public partial class Phase_Setting : UserControl
    {
        public Phase_Setting()
        {
            InitializeComponent();
        }

        private void btn_AddPhase_Click(object sender, EventArgs e)
        {
            Phase p = new Phase();
            flp_Phase.Controls.Add(p);
        }

        private void Phase_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

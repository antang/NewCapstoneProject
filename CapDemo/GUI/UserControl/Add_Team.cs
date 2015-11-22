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
    public partial class Add_Team : UserControl
    {
        public Add_Team()
        {
            InitializeComponent();
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btn_Paint.BackColor = colorDialog1.Color;
                pnl_ColorCoat.BackColor = colorDialog1.Color;
                //this.BackColor = colorDialog1.Color;
            }
        }
    }
}

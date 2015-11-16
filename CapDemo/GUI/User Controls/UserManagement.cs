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
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        private void lbl_Create_Click(object sender, EventArgs e)
        {
            Create_AccountManagement cam = new Create_AccountManagement();
            cam.ShowDialog();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

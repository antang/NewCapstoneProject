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
        public event EventHandler onDelete;
        int iD_Team;
        public int ID_Team
        {
            get { return iD_Team; }
            set { iD_Team = value; }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EventHandler delete = onDelete;

            if (delete != null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDTeam = iD_Team;
                delete(this, args);
            }
        }
        //Input point of team
        private bool nonNumberEntered = false;
        private void txt_TeamScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_TeamScore_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        //limit number of tesxt
        private void txt_TeamName_TextChanged(object sender, EventArgs e)
        {
            if (txt_TeamName.Text.Trim().Length < 20)
            {

            }
            else
            {
                txt_TeamName.Text = txt_TeamName.Text.Trim().Substring(0,txt_TeamName.Text.Length-1);
                MessageBox.Show("Không được phép nhập tên đội thi đấu trên 20 ký tự.","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            EventHandler delete = onDelete;

            if (delete != null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDTeam = iD_Team;
                delete(this, args);
            }
        }

    }
}

using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class Add_Competition : Form
    {
        public Add_Competition()
        {
            InitializeComponent();
        }

        private void btn_SaveCompetition_Click(object sender, EventArgs e)
        {
            saveCompetition();
        }
        //close form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save competition
        public void saveCompetition()
        {
            if (txt_NameCompetition.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên cuộc thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CompetitionBL CompetitionBL = new CompetitionBL();
                Competition Competition = new Competition();
                Competition.NameCompetition = txt_NameCompetition.Text.Trim();
                if (CompetitionBL.AddCompetition(Competition) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cuộc thi này đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //enter to save
        private void txt_NameCompetition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveCompetition();
            }
        }
    }
}

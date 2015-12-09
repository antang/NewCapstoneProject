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
    public partial class Add_Round : Form
    {
        private int idCompetition;
        private string nameCompetition;

        public Add_Round()
        {
            InitializeComponent();
        }

        public Add_Round(int idCompetition, string nameCompetition)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.idCompetition = idCompetition;
            this.nameCompetition = nameCompetition;
        }
        //click to save
        private void btn_SaveRound_Click(object sender, EventArgs e)
        {
            saveRound();
        }
        //click to exit form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save competition
        public void saveRound()
        {
            if (txt_NameRound.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên vòng thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RoundBL RoundBL = new RoundBL();
                Round Round = new Round();
                Round.NameRound = txt_NameRound.Text.Trim();
                Round.IDCompetition = idCompetition;
                if (RoundBL.AddRound(Round) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vòng thi này đã tồn tại trong cuộc thi "+ nameCompetition +".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Press enter key
        private void txt_NameRound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveRound();
            }
        }
    }
}

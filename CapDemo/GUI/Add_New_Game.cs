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
    public partial class Add_New_Game : Form
    {
        public Add_New_Game()
        {
            InitializeComponent();
        }
        General_Setting gs = new General_Setting();
        Phase_Setting ps = new Phase_Setting();
        Team_Setting ts = new Team_Setting();
        Competition_Setting cs = new Competition_Setting();
        private void Add_New_Game_Load(object sender, EventArgs e)
        {
            pnl_Create.Controls.Add(gs);
            btn_Back.Visible = false;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            nutTiep();
        }
        int i = 0;
        public void nutTiep()
        {
            i = i + 1;
            if (i == 1)
            {
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(ps);
                btn_Back.Visible = true;
            }
            else if (i == 2)
            {
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(ts);
            }
            else if (i == 3)
            {
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(cs);
                btn_Next.Visible = false;
                btn_Save.Visible = true;
            }
            else
            {

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            nutLui();
        }
        public void nutLui()
        {
            i = i - 1;
            if (i == 2)
            {
                btn_Next.Visible = true;
                btn_Save.Visible = false;
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(ts);

            }
            else if (i == 1)
            {
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(ps);
            }
            else if (i == 0)
            {
                pnl_Create.Controls.Clear();
                pnl_Create.Controls.Add(gs);
                btn_Back.Visible = false;
            }
            else
            {

            }
        }

    }
}

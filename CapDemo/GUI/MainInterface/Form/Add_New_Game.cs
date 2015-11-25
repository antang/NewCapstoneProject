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
        //General_Setting gs = new General_Setting();
        //Phase_Setting ps = new Phase_Setting();
        //Team_Setting ts = new Team_Setting();
        //Competition_Setting cs = new Competition_Setting();
        private void Add_New_Game_Load(object sender, EventArgs e)
        {
            //pnl_CreateSetup.Controls.Add(gs);
            if (!pnl_CreateSetup.Controls.Contains(General_Setting.instance))
            {
                pnl_CreateSetup.Controls.Add(General_Setting.instance);
                General_Setting.instance.Dock = DockStyle.Fill;
                General_Setting.instance.BringToFront();
            }
            else
                General_Setting.instance.BringToFront();

            btn_Back.Visible = false;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Next();
        }
        int i = 0;
        public void Next()
        {
            i = i + 1;
            if (i == 1)
            {
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(ps);
                if (!pnl_CreateSetup.Controls.Contains(Phase_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(Phase_Setting.instance);
                    Phase_Setting.instance.Dock = DockStyle.Fill;
                    Phase_Setting.instance.BringToFront();
                }
                else
                    Phase_Setting.instance.BringToFront();
                btn_Back.Visible = true;
            }
            else if (i == 2)
            {
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(ts);
                if (!pnl_CreateSetup.Controls.Contains(Team_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(Team_Setting.instance);
                    Team_Setting.instance.Dock = DockStyle.Fill;
                    Team_Setting.instance.BringToFront();
                }
                else
                    Team_Setting.instance.BringToFront();
            }
            else if (i == 3)
            {
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(cs);
                if (!pnl_CreateSetup.Controls.Contains(Competition_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(Competition_Setting.instance);
                    Competition_Setting.instance.Dock = DockStyle.Fill;
                    Competition_Setting.instance.BringToFront();
                }
                else
                    Competition_Setting.instance.BringToFront();
                btn_Next.Visible = false;
                btn_Save.Visible = true;
            }
        }
        //Click Back
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Back();
        }
        //Method Back
        public void Back()
        {
            i = i - 1;
            if (i == 2)
            {
                btn_Next.Visible = true;
                btn_Save.Visible = false;
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(ts);
                if (!pnl_CreateSetup.Controls.Contains(Team_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(Team_Setting.instance);
                    Team_Setting.instance.Dock = DockStyle.Fill;
                    Team_Setting.instance.BringToFront();
                }
                else
                    Team_Setting.instance.BringToFront();

            }
            else if (i == 1)
            {
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(ps);
                if (!pnl_CreateSetup.Controls.Contains(Phase_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(Phase_Setting.instance);
                    Phase_Setting.instance.Dock = DockStyle.Fill;
                    Phase_Setting.instance.BringToFront();
                }
                else
                    Phase_Setting.instance.BringToFront();
            }
            else if (i == 0)
            {
                //pnl_CreateSetup.Controls.Clear();
                //pnl_CreateSetup.Controls.Add(gs);
                btn_Back.Visible = false;
                if (!pnl_CreateSetup.Controls.Contains(General_Setting.instance))
                {
                    pnl_CreateSetup.Controls.Add(General_Setting.instance);
                    General_Setting.instance.Dock = DockStyle.Fill;
                    General_Setting.instance.BringToFront();
                }
                else
                    General_Setting.instance.BringToFront();
            }
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

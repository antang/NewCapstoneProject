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
    public partial class Team_Setting : UserControl
    {
        public Team_Setting()
        {
            InitializeComponent();
        }
        //LOAD USER CONTROL
        private static Team_Setting _instance;
        public static Team_Setting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Team_Setting();
                return _instance;
            }
        }
        int i = 0;
        //Add Team
        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Add_Team item in flp_Team.Controls)
            {
                count++;
            }
            if (count < 4)
            {
                Add_Team AddPhase = new Add_Team();
                i++;
                AddPhase.Tag = i;
                AddPhase.ID_Team = i;
                AddPhase.onDelete += AddTeam_onDelete;
                //AddPhase.lbl_Number.Text = i.ToString();
                flp_Team.Controls.Add(AddPhase);

                for (int j = 0; j < flp_Team.Controls.Count; j++)
                {
                    AddPhase.txt_Sequence.Text = (j + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Hệ thống cho phép nhập tối đa là 4 đội.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        
        //Eventhanlder click Del button
        void AddTeam_onDelete(object sender, EventArgs e)
        {
            int i = 1;
            Add_Team AddPhase = new Add_Team();
            int teamID = (e as MyEventArgs).IDTeam;
            foreach (Add_Team item in flp_Team.Controls)
            {
                if (item.ID_Team == teamID)
                {
                    flp_Team.Controls.Remove(item);
                }

            }
            foreach (Add_Team item in flp_Team.Controls)
            {
                item.txt_Sequence.Text = (i++).ToString();
            }
        }
        //Load
        private void Team_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            flp_Team.Controls.Clear();
        }
        //Check Number of team
        public bool MoreOneTeam()
        {
            int j = 0;
            foreach (Add_Team item in flp_Team.Controls)
            {
                j++;
            }
            if (j < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //check item in team is empty
        public bool checkTeamEmpty()
        {
            int j = 0;
            foreach (Add_Team item in flp_Team.Controls)
            {
                if (item.txt_TeamName.Text.Trim() == "" || item.txt_TeamScore.Text.Trim() == "" || item.btn_Paint.BackColor.Name == "" || item.txt_Sequence.Text.Trim() == "")
                {
                    j++;
                }
            }
            if (j > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check duplicate color
        public bool checkDuplicateColor()
        {
            int j = 0;
            int a = flp_Team.Controls.Count;
            foreach (Add_Team item in flp_Team.Controls)
            {
                foreach (Add_Team item1 in flp_Team.Controls)
                {
                    if (item.btn_Paint.BackColor.Name == item1.btn_Paint.BackColor.Name || item.txt_TeamName.Text.Trim() == item1.txt_TeamName.Text.Trim()||item.txt_Sequence.Text.Trim() == item1.txt_Sequence.Text.Trim())
                    {
                        j++;
                    }
                }
                
            }
            if (j > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check Number of team
        public int CountTeam()
        {
            int j = 0;
            foreach (Add_Team item in flp_Team.Controls)
            {
                j++;
            }
            return j;
        }
    }
}

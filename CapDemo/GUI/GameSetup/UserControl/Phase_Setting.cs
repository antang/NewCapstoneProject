﻿using System;
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
        private static Phase_Setting _instance;
        public static Phase_Setting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Phase_Setting();
                return _instance;
            }
        }
        int i = 0;
        //add phase
        private void btn_AddPhase_Click(object sender, EventArgs e)
        {
            int count=0;
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                count++;
            }
            if (count < 5)
            {
                Add_Phase AddPhase = new Add_Phase();
                i++;
                AddPhase.Tag = i;
                AddPhase.ID_Phase = i;
                AddPhase.onDelete += AddPhase_onDelete;
                //AddPhase.lbl_Number.Text = i.ToString();
                flp_Phase.Controls.Add(AddPhase);

                for (int j = 0; j < flp_Phase.Controls.Count; j++)
                {
                    AddPhase.txt_Sequence.Text = (j + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Hệ thống cho phép nhập tối đa là 5 giai đoạn.","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        //Eventhanlder click Del button
        void AddPhase_onDelete(object sender, EventArgs e)
        {
            int i = 1;
            Add_Phase AddPhase = new Add_Phase();
            int phaseID = (e as MyEventArgs).IDPhase;
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                if (item.ID_Phase == phaseID)
                {
                    flp_Phase.Controls.Remove(item);
                }

            }
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                item.txt_Sequence.Text = (i++).ToString();
            }
        }
        private void Phase_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            flp_Phase.Controls.Clear();
        }

        //Check Number of phase
        public bool MoreOnePhase()
        {
            int j = 0;
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                    j++;
            }
            if (j == 0)
            {
                return false;
            }
            else
            {
                return true ;
            }
        }
        //check item in phase is empty
        public bool checkPhaseEmpty()
        {
            int j = 0;
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                if (item.txt_Time.Text.Trim() == ""||item.txt_Score.Text.Trim() == ""||item.txt_Minus.Text.Trim()==""||item.txt_PhaseName.Text.Trim()=="")
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
        //Get all phase
        public string getPhase()
        {
            string Phase = "";
            foreach (Add_Phase item in flp_Phase.Controls)
            {
                Phase += item.txt_PhaseName.Text.Trim()
                    + "</ItemPhase>" + item.txt_Score.Text 
                    + "</ItemPhase>" + item.txt_Minus.Text
                    + "</ItemPhase>" + item.txt_Time.Text + "</Phase!@>";
            }
            return Phase;
        }
    }
}

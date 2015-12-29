using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.GUI.User_Controls;

namespace CapDemo
{
    public partial class Team : UserControl
    {
        public Team()
        {
            InitializeComponent();
        }
        int idPlayerUC;
        public int IdPlayerUC
        {
            get { return idPlayerUC; }
            set { idPlayerUC = value; }
        }
        public event EventHandler checkSupport;
        public event EventHandler checkQuestionPM;
        public event EventHandler checkChallenge;
        private void lbl_ShowMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }
        //check to get support form audience
        private void chk_Support_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Support.Checked ==true)
            {
                EventHandler checksupport = checkSupport;
                if (checksupport != null)
                {
                    MyEventArgs args = new MyEventArgs();
                    args.IDPlayerUC = idPlayerUC;
                    checksupport(this, args);
                }
            }  
        }
        //check to show question PM
        private void chk_QuestionPM_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_QuestionPM.Checked == true)
            {
                EventHandler checkquestionPM = checkQuestionPM;
                if (checkquestionPM != null)
                {
                    MyEventArgs args = new MyEventArgs();
                    args.IDPlayerUC = idPlayerUC;
                    checkquestionPM(this, args);
                }
            }  
        }
        //check to get challengce choice
        private void chk_defy_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_defy.Checked == true)
            {
                EventHandler checkdefy = checkChallenge;
                if (checkdefy != null)
                {
                    MyEventArgs args = new MyEventArgs();
                    args.IDPlayerUC = idPlayerUC;
                    checkdefy(this,args);
                }
            }
        }
        //check when player is challenged
        private void chk_Challenged_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}

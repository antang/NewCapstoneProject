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
    public partial class Answer_OnlyOneSelect : UserControl
    {
        //Declare Eventhandler
        public event EventHandler onDelete;
        public event EventHandler onCheck;
        public Answer_OnlyOneSelect()
        {
            InitializeComponent();
        }
        //Declare parameter
        int iD_Answer;
        public int ID_Answer
        {
            get { return iD_Answer; }
            set { iD_Answer = value; }
        }
        //CHECK ANSWER 
        private void rad_check_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler check = onCheck;
            if (check != null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDAnswer = iD_Answer;
                check(this, args);
            }
        }
        //DELETE ANSWER
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EventHandler delete = onDelete;

            if (delete != null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDAnswer = iD_Answer;
                delete(this, args);
            }
        }


    }
}

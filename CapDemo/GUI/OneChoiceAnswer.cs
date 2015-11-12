using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI
{
    public partial class OneChoiceAnswer : UserControl
    {
        public event EventHandler onDelete;
        public event EventHandler onCheck;
        public OneChoiceAnswer()
        {
            InitializeComponent();
        }

        public string AnswerContent()
        {
            return textBox1.Text;
        }

        int iD_Answer;
        public int ID_Answer
        {
            get { return iD_Answer; }
            set { iD_Answer = value; }
        }
        //Delete answer
        private void button1_Click(object sender, EventArgs e)
        {
            EventHandler delete = onDelete;

            if (delete!=null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDAnswer = iD_Answer;
                delete(this, args);
            }
        }
        //check answer
        private void rad_1_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler check = onCheck;
            if (check!= null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDAnswer = iD_Answer;
                check(this, args);
            }
        }

        
    }
}

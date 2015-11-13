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
    public partial class CreateQuestion : UserControl
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }
        //Declare parameter
        private int iDCat;
        private string nameCat;
        //GET SET ID CAT
        public int IDCat
        {
            get { return iDCat; }
            set { iDCat = value; }
        }
        //GET SET NAME CAT
        public string NameCat
        {
            get { return nameCat; }
            set { nameCat = value; }
        }
        //Constructor
        public CreateQuestion(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }
        Question_MultiSelect qms = new Question_MultiSelect();
        Question_ShortAnswer qsa = new Question_ShortAnswer();
       
        private void rdo_OnlyOneAnswer_CheckedChanged(object sender, EventArgs e)
        {
            Question_OnlyOneSelect qoos = new Question_OnlyOneSelect(IDCat,NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qoos);
        }

        private void rdo_MultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qms);
        }

        private void rdo_ShortAnswer_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qsa);
        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Question_OnlyOneSelect qoos = new Question_OnlyOneSelect(IDCat, NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qoos);
        }
    }
}

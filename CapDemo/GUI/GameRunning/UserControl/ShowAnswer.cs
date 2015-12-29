using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class ShowAnswer : UserControl
    {
        public ShowAnswer()
        {
            InitializeComponent();
        }

        private void ShowAnswer_Load(object sender, EventArgs e)
        {
            chk1.Location = new Point(chk1.Location.X + 3, chk1.Location.Y + (this.Height/2) - chk1.Height/2);
            rdb1.Location = new Point(rdb1.Location.X + 3, rdb1.Location.Y + (this.Height / 2) - rdb1.Height);
            chk1.Font = new Font(chk1.Font,FontStyle.Bold);
            rdb1.Font = new Font(rdb1.Font, FontStyle.Bold);
        }
    }
}

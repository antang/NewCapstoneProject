using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class PleaseWaitForm : Form
    {
        public PleaseWaitForm()
        {
            InitializeComponent();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }

        private void PleaseWaitForm_Load(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(Properties.Resources.modau);
            s.Play();
            this.SuspendLayout();
            //this.Dock = DockStyle.Fill;
            this.ResumeLayout();
        }
    }
}

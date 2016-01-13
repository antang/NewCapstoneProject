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
            SoundPlayer sound = new SoundPlayer(Properties.Resources.welcome_game);
            sound.Play();

            this.SuspendLayout();
            Screen[] screens = Screen.AllScreens;
            if (screens.Count() > 1)
            {
                Rectangle bounds = screens[1].Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
            //this.Show();
            //this.Dock = DockStyle.Fill;
            this.ResumeLayout();


        }
    }
}

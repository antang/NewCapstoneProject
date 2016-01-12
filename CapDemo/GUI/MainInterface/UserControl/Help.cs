using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CapDemo
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }
        private void Help_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        public event EventHandler onExit;
        SoundPlayer sound = new SoundPlayer(Properties.Resources.hover);
        SoundPlayer sound_Click = new SoundPlayer(Properties.Resources.Click);
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.onExit != null)
                this.onExit(this, e);
        }

        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            sound.PlaySync();
            btn_Exit.BackgroundImage = Properties.Resources.Nut_thoat_horver;
            btn_Exit.ForeColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackgroundImage = Properties.Resources.Nut_thoat_normal;
            btn_Exit.ForeColor = Color.White;
        }
    }
}

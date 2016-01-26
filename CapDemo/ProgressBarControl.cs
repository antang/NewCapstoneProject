﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CapDemo
{
    public partial class ProgressBarControl : UserControl
    {
        public ProgressBarControl()
        {
            InitializeComponent();
        }
        protected float percent = 0.0f;
        int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }
        public float Value
        {
            set
            {
                if (value < 0) value = 0;
                else if (value > max) value = max;

                percent = value;
                //dòng này nếu muốn có số chạy giữa thanh progressBar
                //label1.Text = value.ToString() + "%";

                this.Invalidate();
            }
            get
            {
                return percent;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //dòng này nếu muốn có số chạy giữa thanh progressBar
            //label1.Location = new Point((this.Width / 2) - (label1.Width / 2), (this.Height / 2) - (label1.Height / 2));

            LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.White, this.ForeColor, LinearGradientMode.ForwardDiagonal);

            int Width = (int)((percent / max) * this.Width);

            e.Graphics.FillRectangle(lgb, 0, 0, Width, this.Height);

            lgb.Dispose();
        }
    }
}

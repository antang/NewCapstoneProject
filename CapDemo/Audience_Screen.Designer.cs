namespace CapDemo
{
    partial class Audience_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audience_Screen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Map = new System.Windows.Forms.TabPage();
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Finish = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Lane = new System.Windows.Forms.Panel();
            this.tab_ShowQuestion = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TimeShowQuestion = new System.Windows.Forms.Label();
            this.flp_AnswerQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_FinishLane = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tab_Map.SuspendLayout();
            this.tab_ShowQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_Map);
            this.tabControl1.Controls.Add(this.tab_ShowQuestion);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 771);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Map
            // 
            this.tab_Map.BackColor = System.Drawing.Color.White;
            this.tab_Map.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.tab_Map.Controls.Add(this.pnl_FinishLane);
            this.tab_Map.Controls.Add(this.flp_Team);
            this.tab_Map.Controls.Add(this.flp_Finish);
            this.tab_Map.Controls.Add(this.pnl_Lane);
            this.tab_Map.Location = new System.Drawing.Point(4, 22);
            this.tab_Map.Name = "tab_Map";
            this.tab_Map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Map.Size = new System.Drawing.Size(1018, 745);
            this.tab_Map.TabIndex = 0;
            this.tab_Map.Text = "tabPage1";
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.Location = new System.Drawing.Point(642, 3);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(375, 735);
            this.flp_Team.TabIndex = 3;
            // 
            // flp_Finish
            // 
            this.flp_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Finish.BackColor = System.Drawing.Color.Transparent;
            this.flp_Finish.BackgroundImage = global::CapDemo.Properties.Resources.chiec_cup;
            this.flp_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flp_Finish.Location = new System.Drawing.Point(4, 2);
            this.flp_Finish.Name = "flp_Finish";
            this.flp_Finish.Size = new System.Drawing.Size(631, 81);
            this.flp_Finish.TabIndex = 0;
            // 
            // pnl_Lane
            // 
            this.pnl_Lane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Lane.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Lane.Location = new System.Drawing.Point(4, 147);
            this.pnl_Lane.Name = "pnl_Lane";
            this.pnl_Lane.Size = new System.Drawing.Size(631, 591);
            this.pnl_Lane.TabIndex = 1;
            // 
            // tab_ShowQuestion
            // 
            this.tab_ShowQuestion.BackColor = System.Drawing.Color.SkyBlue;
            this.tab_ShowQuestion.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.tab_ShowQuestion.Controls.Add(this.panel3);
            this.tab_ShowQuestion.Controls.Add(this.panel1);
            this.tab_ShowQuestion.Controls.Add(this.flp_AnswerQuiz);
            this.tab_ShowQuestion.Controls.Add(this.richTextBox1);
            this.tab_ShowQuestion.Location = new System.Drawing.Point(4, 22);
            this.tab_ShowQuestion.Name = "tab_ShowQuestion";
            this.tab_ShowQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShowQuestion.Size = new System.Drawing.Size(1018, 745);
            this.tab_ShowQuestion.TabIndex = 1;
            this.tab_ShowQuestion.Text = "tabPage2";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 110);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_TimeShowQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 90);
            this.panel1.TabIndex = 3;
            // 
            // lbl_TimeShowQuestion
            // 
            this.lbl_TimeShowQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TimeShowQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimeShowQuestion.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeShowQuestion.Image = global::CapDemo.Properties.Resources.vong_tron_gio;
            this.lbl_TimeShowQuestion.Location = new System.Drawing.Point(464, 0);
            this.lbl_TimeShowQuestion.Name = "lbl_TimeShowQuestion";
            this.lbl_TimeShowQuestion.Size = new System.Drawing.Size(90, 90);
            this.lbl_TimeShowQuestion.TabIndex = 2;
            this.lbl_TimeShowQuestion.Text = "0";
            this.lbl_TimeShowQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_AnswerQuiz
            // 
            this.flp_AnswerQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AnswerQuiz.AutoScroll = true;
            this.flp_AnswerQuiz.BackColor = System.Drawing.Color.SkyBlue;
            this.flp_AnswerQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_AnswerQuiz.Location = new System.Drawing.Point(0, 313);
            this.flp_AnswerQuiz.Name = "flp_AnswerQuiz";
            this.flp_AnswerQuiz.Size = new System.Drawing.Size(1018, 323);
            this.flp_AnswerQuiz.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1018, 216);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ao-lon.png");
            this.imageList1.Images.SetKeyName(1, "ao-nho.png");
            this.imageList1.Images.SetKeyName(2, "chiec-cup.png");
            this.imageList1.Images.SetKeyName(3, "het-thach-dau.png");
            this.imageList1.Images.SetKeyName(4, "het-y-kien.png");
            this.imageList1.Images.SetKeyName(5, "hinh-tron-dung.png");
            this.imageList1.Images.SetKeyName(6, "hinh-tron-sai.png");
            this.imageList1.Images.SetKeyName(7, "hit-your-goal.png");
            this.imageList1.Images.SetKeyName(8, "khung-doi-thi.png");
            this.imageList1.Images.SetKeyName(9, "khung-vong-thi.png");
            this.imageList1.Images.SetKeyName(10, "nen-doi-thi.png");
            this.imageList1.Images.SetKeyName(11, "nen-vong-thi.png");
            this.imageList1.Images.SetKeyName(12, "thach-dau.png");
            this.imageList1.Images.SetKeyName(13, "trai-tim-dung.png");
            this.imageList1.Images.SetKeyName(14, "trai-tim-sai.png");
            this.imageList1.Images.SetKeyName(15, "y-kien.png");
            // 
            // pnl_FinishLane
            // 
            this.pnl_FinishLane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_FinishLane.BackColor = System.Drawing.Color.Gold;
            this.pnl_FinishLane.Location = new System.Drawing.Point(4, 89);
            this.pnl_FinishLane.Name = "pnl_FinishLane";
            this.pnl_FinishLane.Size = new System.Drawing.Size(631, 52);
            this.pnl_FinishLane.TabIndex = 4;
            // 
            // Audience_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Audience_Screen";
            this.Text = "Audience_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Audience_Screen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Map.ResumeLayout(false);
            this.tab_ShowQuestion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tab_Map;
        public System.Windows.Forms.TabPage tab_ShowQuestion;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerQuiz;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel pnl_Lane;
        public System.Windows.Forms.Label lbl_TimeShowQuestion;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flp_Finish;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flp_Team;
        public System.Windows.Forms.Panel pnl_FinishLane;
    }
}
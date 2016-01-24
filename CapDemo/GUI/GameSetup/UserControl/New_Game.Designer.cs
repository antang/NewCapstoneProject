namespace CapDemo.GUI.User_Controls
{
    partial class New_Game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_RoundName = new System.Windows.Forms.Label();
            this.lbl_ContestName = new System.Windows.Forms.Label();
            this.lbl_IDContest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_CompetitionName = new System.Windows.Forms.Label();
            this.deleteSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(9, 102);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(73, 16);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Vòng thi:";
            this.lbl_Name.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phần Thi:";
            this.label3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_RoundName
            // 
            this.lbl_RoundName.AutoSize = true;
            this.lbl_RoundName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoundName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoundName.ForeColor = System.Drawing.Color.White;
            this.lbl_RoundName.Location = new System.Drawing.Point(88, 102);
            this.lbl_RoundName.Name = "lbl_RoundName";
            this.lbl_RoundName.Size = new System.Drawing.Size(95, 16);
            this.lbl_RoundName.TabIndex = 6;
            this.lbl_RoundName.Text = "tên vòng thi";
            this.lbl_RoundName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_ContestName
            // 
            this.lbl_ContestName.AutoSize = true;
            this.lbl_ContestName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ContestName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContestName.ForeColor = System.Drawing.Color.White;
            this.lbl_ContestName.Location = new System.Drawing.Point(88, 129);
            this.lbl_ContestName.Name = "lbl_ContestName";
            this.lbl_ContestName.Size = new System.Drawing.Size(95, 16);
            this.lbl_ContestName.TabIndex = 7;
            this.lbl_ContestName.Text = "tên phần thi";
            this.lbl_ContestName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_IDContest
            // 
            this.lbl_IDContest.AutoSize = true;
            this.lbl_IDContest.Location = new System.Drawing.Point(4, 16);
            this.lbl_IDContest.Name = "lbl_IDContest";
            this.lbl_IDContest.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDContest.TabIndex = 8;
            this.lbl_IDContest.Visible = false;
            this.lbl_IDContest.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái Thiết Đặt:";
            this.label4.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(160, 76);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(54, 16);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "status";
            this.lbl_Status.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // lbl_CompetitionName
            // 
            this.lbl_CompetitionName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CompetitionName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompetitionName.ForeColor = System.Drawing.Color.White;
            this.lbl_CompetitionName.Location = new System.Drawing.Point(192, 41);
            this.lbl_CompetitionName.Name = "lbl_CompetitionName";
            this.lbl_CompetitionName.Size = new System.Drawing.Size(99, 33);
            this.lbl_CompetitionName.TabIndex = 5;
            this.lbl_CompetitionName.Text = "tên";
            this.lbl_CompetitionName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // deleteSetupToolStripMenuItem
            // 
            this.deleteSetupToolStripMenuItem.Image = global::CapDemo.Properties.Resources.Cancel;
            this.deleteSetupToolStripMenuItem.Name = "deleteSetupToolStripMenuItem";
            this.deleteSetupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteSetupToolStripMenuItem.Text = "Delete Setup";
            this.deleteSetupToolStripMenuItem.Click += new System.EventHandler(this.deleteSetupToolStripMenuItem_Click);
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::CapDemo.Properties.Resources.Contest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_CompetitionName);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_IDContest);
            this.Controls.Add(this.lbl_ContestName);
            this.Controls.Add(this.lbl_RoundName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "New_Game";
            this.Size = new System.Drawing.Size(294, 181);
            this.Load += new System.EventHandler(this.New_Game_Load);
            this.DoubleClick += new System.EventHandler(this.New_Game_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.New_Game_MouseClick);
            this.MouseEnter += new System.EventHandler(this.New_Game_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.New_Game_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.New_Game_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_CompetitionName;
        public System.Windows.Forms.Label lbl_RoundName;
        public System.Windows.Forms.Label lbl_ContestName;
        public System.Windows.Forms.Label lbl_IDContest;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSetupToolStripMenuItem;
    }
}

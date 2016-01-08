namespace CapDemo
{
    partial class Game
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
            this.lbl_IDContest = new System.Windows.Forms.Label();
            this.lbl_ContestName = new System.Windows.Forms.Label();
            this.lbl_RoundName = new System.Windows.Forms.Label();
            this.lbl_CompetitionName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IDContest
            // 
            this.lbl_IDContest.AutoSize = true;
            this.lbl_IDContest.Location = new System.Drawing.Point(4, 16);
            this.lbl_IDContest.Name = "lbl_IDContest";
            this.lbl_IDContest.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDContest.TabIndex = 19;
            this.lbl_IDContest.Visible = false;
            // 
            // lbl_ContestName
            // 
            this.lbl_ContestName.AutoSize = true;
            this.lbl_ContestName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ContestName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContestName.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ContestName.Location = new System.Drawing.Point(110, 138);
            this.lbl_ContestName.Name = "lbl_ContestName";
            this.lbl_ContestName.Size = new System.Drawing.Size(95, 16);
            this.lbl_ContestName.TabIndex = 18;
            this.lbl_ContestName.Text = "tên phần thi";
            this.lbl_ContestName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_RoundName
            // 
            this.lbl_RoundName.AutoSize = true;
            this.lbl_RoundName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoundName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoundName.ForeColor = System.Drawing.Color.Navy;
            this.lbl_RoundName.Location = new System.Drawing.Point(112, 113);
            this.lbl_RoundName.Name = "lbl_RoundName";
            this.lbl_RoundName.Size = new System.Drawing.Size(95, 16);
            this.lbl_RoundName.TabIndex = 17;
            this.lbl_RoundName.Text = "tên vòng thi";
            this.lbl_RoundName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_CompetitionName
            // 
            this.lbl_CompetitionName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CompetitionName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompetitionName.ForeColor = System.Drawing.Color.White;
            this.lbl_CompetitionName.Location = new System.Drawing.Point(187, 37);
            this.lbl_CompetitionName.Name = "lbl_CompetitionName";
            this.lbl_CompetitionName.Size = new System.Drawing.Size(102, 35);
            this.lbl_CompetitionName.TabIndex = 16;
            this.lbl_CompetitionName.Text = "tên";
            this.lbl_CompetitionName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phần Thi:";
            this.label3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(32, 113);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(73, 16);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Vòng thi:";
            this.lbl_Name.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // deleteSetupToolStripMenuItem
            // 
            this.deleteSetupToolStripMenuItem.Image = global::CapDemo.Properties.Resources.Cancel;
            this.deleteSetupToolStripMenuItem.Name = "deleteSetupToolStripMenuItem";
            this.deleteSetupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteSetupToolStripMenuItem.Text = "Delete Setup";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CapDemo.Properties.Resources.TWLW_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lbl_CompetitionName);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 72);
            this.panel1.TabIndex = 11;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Status.Location = new System.Drawing.Point(124, 89);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(50, 16);
            this.lbl_Status.TabIndex = 21;
            this.lbl_Status.Text = "Đã thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Trạng thái:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_IDContest);
            this.Controls.Add(this.lbl_ContestName);
            this.Controls.Add(this.lbl_RoundName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(294, 181);
            this.Load += new System.EventHandler(this.Game_Load);
            this.DoubleClick += new System.EventHandler(this.Game_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.Game_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Game_MouseLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_IDContest;
        public System.Windows.Forms.Label lbl_ContestName;
        public System.Windows.Forms.Label lbl_RoundName;
        public System.Windows.Forms.Label lbl_CompetitionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSetupToolStripMenuItem;
        public System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label4;
    }
}

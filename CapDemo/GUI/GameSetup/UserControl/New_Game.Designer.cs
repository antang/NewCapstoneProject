﻿namespace CapDemo.GUI.User_Controls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_CompetitionName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_RoundName = new System.Windows.Forms.Label();
            this.lbl_ContestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CapDemo.Properties.Resources.Untitled_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(59, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 64);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuộc Thi:";
            this.label1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(5, 135);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(73, 16);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Vòng thi:";
            this.lbl_Name.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_Name.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Number.Location = new System.Drawing.Point(262, 152);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(19, 20);
            this.lbl_Number.TabIndex = 3;
            this.lbl_Number.Text = "1";
            this.lbl_Number.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_Number.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_CompetitionName
            // 
            this.lbl_CompetitionName.AutoSize = true;
            this.lbl_CompetitionName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CompetitionName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompetitionName.ForeColor = System.Drawing.Color.Navy;
            this.lbl_CompetitionName.Location = new System.Drawing.Point(84, 107);
            this.lbl_CompetitionName.Name = "lbl_CompetitionName";
            this.lbl_CompetitionName.Size = new System.Drawing.Size(93, 16);
            this.lbl_CompetitionName.TabIndex = 5;
            this.lbl_CompetitionName.Text = "tên cuộc thi";
            this.lbl_CompetitionName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_CompetitionName.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phần Thi:";
            this.label3.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_RoundName
            // 
            this.lbl_RoundName.AutoSize = true;
            this.lbl_RoundName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RoundName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoundName.ForeColor = System.Drawing.Color.Navy;
            this.lbl_RoundName.Location = new System.Drawing.Point(84, 135);
            this.lbl_RoundName.Name = "lbl_RoundName";
            this.lbl_RoundName.Size = new System.Drawing.Size(95, 16);
            this.lbl_RoundName.TabIndex = 6;
            this.lbl_RoundName.Text = "tên vòng thi";
            this.lbl_RoundName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_RoundName.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_ContestName
            // 
            this.lbl_ContestName.AutoSize = true;
            this.lbl_ContestName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ContestName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContestName.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ContestName.Location = new System.Drawing.Point(84, 162);
            this.lbl_ContestName.Name = "lbl_ContestName";
            this.lbl_ContestName.Size = new System.Drawing.Size(95, 16);
            this.lbl_ContestName.TabIndex = 7;
            this.lbl_ContestName.Text = "tên phần thi";
            this.lbl_ContestName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_ContestName.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái Thiết Đặt:";
            this.label4.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Status.Location = new System.Drawing.Point(155, 76);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(54, 16);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "status";
            this.lbl_Status.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.lbl_Status.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteSetupToolStripMenuItem
            // 
            this.deleteSetupToolStripMenuItem.Image = global::CapDemo.Properties.Resources.Cancel;
            this.deleteSetupToolStripMenuItem.Name = "deleteSetupToolStripMenuItem";
            this.deleteSetupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteSetupToolStripMenuItem.Text = "Delete Setup";
            this.deleteSetupToolStripMenuItem.Click += new System.EventHandler(this.deleteSetupToolStripMenuItem_Click);
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ContestName);
            this.Controls.Add(this.lbl_RoundName);
            this.Controls.Add(this.lbl_CompetitionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "New_Game";
            this.Size = new System.Drawing.Size(294, 181);
            this.Load += new System.EventHandler(this.New_Game_Load);
            this.DoubleClick += new System.EventHandler(this.New_Game_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.New_Game_MouseClick);
            this.MouseLeave += new System.EventHandler(this.New_Game_MouseLeave);
            this.MouseHover += new System.EventHandler(this.New_Game_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.New_Game_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_CompetitionName;
        public System.Windows.Forms.Label lbl_RoundName;
        public System.Windows.Forms.Label lbl_ContestName;
        public System.Windows.Forms.Label lbl_Number;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSetupToolStripMenuItem;
    }
}

namespace CapDemo.GUI.User_Controls
{
    partial class Add_Team
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TeamScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblVong = new System.Windows.Forms.Label();
            this.btn_Paint = new System.Windows.Forms.Button();
            this.pnl_ColorCoat = new System.Windows.Forms.Panel();
            this.btn_Color = new System.Windows.Forms.Button();
            this.txt_Sequence = new System.Windows.Forms.TextBox();
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(285, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(20, 20);
            this.btn_Delete.TabIndex = 39;
            this.btn_Delete.Text = "X";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Màu";
            // 
            // txt_TeamScore
            // 
            this.txt_TeamScore.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeamScore.Location = new System.Drawing.Point(89, 74);
            this.txt_TeamScore.Multiline = true;
            this.txt_TeamScore.Name = "txt_TeamScore";
            this.txt_TeamScore.Size = new System.Drawing.Size(54, 30);
            this.txt_TeamScore.TabIndex = 36;
            this.txt_TeamScore.Text = "0";
            this.txt_TeamScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TeamScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TeamScore_KeyDown);
            this.txt_TeamScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeamScore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Điểm";
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeamName.Location = new System.Drawing.Point(89, 39);
            this.txt_TeamName.Multiline = true;
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(207, 30);
            this.txt_TeamName.TabIndex = 34;
            this.txt_TeamName.TextChanged += new System.EventHandler(this.txt_TeamName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên đội";
            // 
            // lblVong
            // 
            this.lblVong.AutoSize = true;
            this.lblVong.BackColor = System.Drawing.Color.Transparent;
            this.lblVong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVong.ForeColor = System.Drawing.Color.White;
            this.lblVong.Location = new System.Drawing.Point(14, 7);
            this.lblVong.Name = "lblVong";
            this.lblVong.Size = new System.Drawing.Size(64, 18);
            this.lblVong.TabIndex = 42;
            this.lblVong.Text = "Thứ tự";
            // 
            // btn_Paint
            // 
            this.btn_Paint.BackColor = System.Drawing.Color.White;
            this.btn_Paint.Enabled = false;
            this.btn_Paint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Paint.Location = new System.Drawing.Point(106, 131);
            this.btn_Paint.Name = "btn_Paint";
            this.btn_Paint.Size = new System.Drawing.Size(29, 10);
            this.btn_Paint.TabIndex = 41;
            this.btn_Paint.UseVisualStyleBackColor = false;
            this.btn_Paint.Visible = false;
            // 
            // pnl_ColorCoat
            // 
            this.pnl_ColorCoat.BackColor = System.Drawing.Color.White;
            this.pnl_ColorCoat.BackgroundImage = global::CapDemo.Properties.Resources.MauAo;
            this.pnl_ColorCoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_ColorCoat.Location = new System.Drawing.Point(176, 74);
            this.pnl_ColorCoat.Name = "pnl_ColorCoat";
            this.pnl_ColorCoat.Size = new System.Drawing.Size(78, 72);
            this.pnl_ColorCoat.TabIndex = 40;
            // 
            // btn_Color
            // 
            this.btn_Color.BackColor = System.Drawing.Color.Transparent;
            this.btn_Color.BackgroundImage = global::CapDemo.Properties.Resources.paint_pro;
            this.btn_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Color.Location = new System.Drawing.Point(76, 111);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(30, 30);
            this.btn_Color.TabIndex = 38;
            this.btn_Color.UseVisualStyleBackColor = false;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // txt_Sequence
            // 
            this.txt_Sequence.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sequence.Location = new System.Drawing.Point(89, 4);
            this.txt_Sequence.Multiline = true;
            this.txt_Sequence.Name = "txt_Sequence";
            this.txt_Sequence.Size = new System.Drawing.Size(54, 30);
            this.txt_Sequence.TabIndex = 43;
            this.txt_Sequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Sequence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Sequence_KeyDown);
            this.txt_Sequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sequence_KeyPress);
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(272, 134);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(15, 13);
            this.lbl_IDPlayer.TabIndex = 44;
            this.lbl_IDPlayer.Text = "id";
            this.lbl_IDPlayer.Visible = false;
            // 
            // Add_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.txt_Sequence);
            this.Controls.Add(this.pnl_ColorCoat);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TeamScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVong);
            this.Controls.Add(this.btn_Paint);
            this.DoubleBuffered = true;
            this.Name = "Add_Team";
            this.Size = new System.Drawing.Size(310, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblVong;
        public System.Windows.Forms.Panel pnl_ColorCoat;
        public System.Windows.Forms.TextBox txt_TeamScore;
        public System.Windows.Forms.TextBox txt_TeamName;
        public System.Windows.Forms.Button btn_Paint;
        public System.Windows.Forms.TextBox txt_Sequence;
        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Button btn_Delete;
    }
}

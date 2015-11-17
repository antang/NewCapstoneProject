namespace CapDemo.GUI.User_Controls
{
    partial class Setting_Game
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_AddGame = new System.Windows.Forms.Label();
            this.flp_Game = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(60, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(378, 39);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Danh sách các cuộc thi";
            // 
            // lbl_AddGame
            // 
            this.lbl_AddGame.AutoSize = true;
            this.lbl_AddGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AddGame.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddGame.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_AddGame.Location = new System.Drawing.Point(63, 101);
            this.lbl_AddGame.Name = "lbl_AddGame";
            this.lbl_AddGame.Size = new System.Drawing.Size(186, 23);
            this.lbl_AddGame.TabIndex = 4;
            this.lbl_AddGame.Text = "+ Thêm cuộc thi mới";
            this.lbl_AddGame.Click += new System.EventHandler(this.lbl_AddGame_Click);
            // 
            // flp_Game
            // 
            this.flp_Game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Game.Location = new System.Drawing.Point(67, 128);
            this.flp_Game.Name = "flp_Game";
            this.flp_Game.Size = new System.Drawing.Size(586, 384);
            this.flp_Game.TabIndex = 5;
            // 
            // Setting_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_Game);
            this.Controls.Add(this.lbl_AddGame);
            this.Controls.Add(this.lbl1);
            this.Name = "Setting_Game";
            this.Size = new System.Drawing.Size(710, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_AddGame;
        private System.Windows.Forms.FlowLayoutPanel flp_Game;

    }
}

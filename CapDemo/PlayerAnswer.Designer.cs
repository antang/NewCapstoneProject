namespace CapDemo
{
    partial class PlayerAnswer
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
            this.lbl_TeamAnswer = new System.Windows.Forms.Label();
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.lbl_Check = new System.Windows.Forms.Label();
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.pb_Result = new System.Windows.Forms.PictureBox();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TeamAnswer
            // 
            this.lbl_TeamAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamAnswer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamAnswer.ForeColor = System.Drawing.Color.Black;
            this.lbl_TeamAnswer.Location = new System.Drawing.Point(39, 36);
            this.lbl_TeamAnswer.Name = "lbl_TeamAnswer";
            this.lbl_TeamAnswer.Size = new System.Drawing.Size(162, 41);
            this.lbl_TeamAnswer.TabIndex = 1;
            this.lbl_TeamAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(-29, 8);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDPlayer.TabIndex = 2;
            this.lbl_IDPlayer.Visible = false;
            // 
            // lbl_Check
            // 
            this.lbl_Check.AutoSize = true;
            this.lbl_Check.Location = new System.Drawing.Point(-23, 8);
            this.lbl_Check.Name = "lbl_Check";
            this.lbl_Check.Size = new System.Drawing.Size(0, 13);
            this.lbl_Check.TabIndex = 3;
            this.lbl_Check.Visible = false;
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamName.BackColor = System.Drawing.Color.DimGray;
            this.lbl_TeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.ForeColor = System.Drawing.Color.White;
            this.lbl_TeamName.Location = new System.Drawing.Point(39, -1);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(162, 37);
            this.lbl_TeamName.TabIndex = 5;
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Result
            // 
            this.pb_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Result.Location = new System.Drawing.Point(0, 37);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(39, 40);
            this.pb_Result.TabIndex = 4;
            this.pb_Result.TabStop = false;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_TeamShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TeamShirt.Location = new System.Drawing.Point(0, 0);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(39, 37);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            this.pb_TeamShirt.Click += new System.EventHandler(this.pb_TeamShirt_Click);
            // 
            // PlayerAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.lbl_Check);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.lbl_TeamAnswer);
            this.Controls.Add(this.pb_TeamShirt);
            this.Name = "PlayerAnswer";
            this.Size = new System.Drawing.Size(200, 77);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.Label lbl_TeamAnswer;
        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Label lbl_Check;
        public System.Windows.Forms.Label lbl_TeamName;
        public System.Windows.Forms.PictureBox pb_Result;

    }
}

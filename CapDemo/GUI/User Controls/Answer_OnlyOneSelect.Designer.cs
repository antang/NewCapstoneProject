namespace CapDemo.GUI.User_Controls
{
    partial class Answer_OnlyOneSelect
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
            this.rad_check = new System.Windows.Forms.RadioButton();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rad_check
            // 
            this.rad_check.AutoSize = true;
            this.rad_check.Location = new System.Drawing.Point(2, 6);
            this.rad_check.Name = "rad_check";
            this.rad_check.Size = new System.Drawing.Size(32, 17);
            this.rad_check.TabIndex = 12;
            this.rad_check.TabStop = true;
            this.rad_check.Text = "A";
            this.rad_check.UseVisualStyleBackColor = true;
            this.rad_check.CheckedChanged += new System.EventHandler(this.rad_check_CheckedChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(313, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(23, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "X";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(262, 50);
            this.textBox1.TabIndex = 10;
            // 
            // Answer_OnlyOneSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rad_check);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.textBox1);
            this.Name = "Answer_OnlyOneSelect";
            this.Size = new System.Drawing.Size(338, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton rad_check;
    }
}

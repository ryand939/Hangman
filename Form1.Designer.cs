namespace part_8
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.listUsedChar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(708, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::part_8.Properties.Resources.first;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGameTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblGameTitle.Location = new System.Drawing.Point(359, 22);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(332, 29);
            this.lblGameTitle.TabIndex = 2;
            this.lblGameTitle.Text = "Part 8 ICS4U: Hangman";
            this.lblGameTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblGameTitle.MouseEnter += new System.EventHandler(this.lblGameTitle_MouseEnter);
            this.lblGameTitle.MouseLeave += new System.EventHandler(this.lblGameTitle_MouseLeave);
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserEntry.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserEntry.Location = new System.Drawing.Point(360, 276);
            this.txtUserEntry.MaxLength = 1;
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(37, 42);
            this.txtUserEntry.TabIndex = 3;
            this.txtUserEntry.MouseEnter += new System.EventHandler(this.txtUserEntry_MouseEnter);
            this.txtUserEntry.MouseLeave += new System.EventHandler(this.txtUserEntry_MouseLeave);
            // 
            // listUsedChar
            // 
            this.listUsedChar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listUsedChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsedChar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsedChar.FormattingEnabled = true;
            this.listUsedChar.ItemHeight = 22;
            this.listUsedChar.Location = new System.Drawing.Point(363, 72);
            this.listUsedChar.Name = "listUsedChar";
            this.listUsedChar.Size = new System.Drawing.Size(165, 198);
            this.listUsedChar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(360, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 200);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(403, 276);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSubmit_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserEntry);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listUsedChar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Part 8: Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.ListBox listUsedChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
    }
}


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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblGameTitle = new System.Windows.Forms.Label();
			this.txtUserEntry = new System.Windows.Forms.TextBox();
			this.listUsedChar = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblChar1 = new System.Windows.Forms.Label();
			this.lblChar6 = new System.Windows.Forms.Label();
			this.lblChar5 = new System.Windows.Forms.Label();
			this.lblChar4 = new System.Windows.Forms.Label();
			this.lblChar3 = new System.Windows.Forms.Label();
			this.lblChar2 = new System.Windows.Forms.Label();
			this.lblChar0 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblAddCharInfo = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGameTitle
			// 
			this.lblGameTitle.AutoSize = true;
			this.lblGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblGameTitle.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
			this.lblGameTitle.ForeColor = System.Drawing.Color.Black;
			this.lblGameTitle.Location = new System.Drawing.Point(230, 14);
			this.lblGameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGameTitle.Name = "lblGameTitle";
			this.lblGameTitle.Size = new System.Drawing.Size(245, 27);
			this.lblGameTitle.TabIndex = 2;
			this.lblGameTitle.Text = "Part 8 ICS4U: Hangman";
			this.lblGameTitle.UseCompatibleTextRendering = true;
			this.lblGameTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.lblGameTitle_Paint);
			this.lblGameTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// txtUserEntry
			// 
			this.txtUserEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUserEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUserEntry.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtUserEntry.Location = new System.Drawing.Point(233, 181);
			this.txtUserEntry.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserEntry.MaxLength = 1;
			this.txtUserEntry.Name = "txtUserEntry";
			this.txtUserEntry.Size = new System.Drawing.Size(25, 30);
			this.txtUserEntry.TabIndex = 3;
			this.txtUserEntry.MouseEnter += new System.EventHandler(this.txtUserEntry_MouseEnter);
			this.txtUserEntry.MouseLeave += new System.EventHandler(this.txtUserEntry_MouseLeave);
			// 
			// listUsedChar
			// 
			this.listUsedChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listUsedChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listUsedChar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listUsedChar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.listUsedChar.FormattingEnabled = true;
			this.listUsedChar.ItemHeight = 14;
			this.listUsedChar.Location = new System.Drawing.Point(235, 49);
			this.listUsedChar.Margin = new System.Windows.Forms.Padding(2);
			this.listUsedChar.Name = "listUsedChar";
			this.listUsedChar.Size = new System.Drawing.Size(98, 126);
			this.listUsedChar.TabIndex = 4;
			this.listUsedChar.SelectedIndexChanged += new System.EventHandler(this.listUsedChar_SelectedIndexChanged);
			this.listUsedChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(233, 47);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(103, 130);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblChar1);
			this.panel2.Controls.Add(this.lblChar6);
			this.panel2.Controls.Add(this.lblChar5);
			this.panel2.Controls.Add(this.lblChar4);
			this.panel2.Controls.Add(this.lblChar3);
			this.panel2.Controls.Add(this.lblChar2);
			this.panel2.Controls.Add(this.lblChar0);
			this.panel2.Location = new System.Drawing.Point(233, 222);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 59);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar1
			// 
			this.lblChar1.AutoSize = true;
			this.lblChar1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar1.Location = new System.Drawing.Point(57, 21);
			this.lblChar1.Name = "lblChar1";
			this.lblChar1.Size = new System.Drawing.Size(22, 30);
			this.lblChar1.TabIndex = 6;
			this.lblChar1.Text = "*";
			this.lblChar1.UseCompatibleTextRendering = true;
			this.lblChar1.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar2_Paint);
			this.lblChar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar6
			// 
			this.lblChar6.AutoSize = true;
			this.lblChar6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar6.Location = new System.Drawing.Point(247, 22);
			this.lblChar6.Name = "lblChar6";
			this.lblChar6.Size = new System.Drawing.Size(22, 30);
			this.lblChar6.TabIndex = 5;
			this.lblChar6.Text = "*";
			this.lblChar6.UseCompatibleTextRendering = true;
			this.lblChar6.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar7_Paint);
			this.lblChar6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar5
			// 
			this.lblChar5.AutoSize = true;
			this.lblChar5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar5.Location = new System.Drawing.Point(209, 21);
			this.lblChar5.Name = "lblChar5";
			this.lblChar5.Size = new System.Drawing.Size(22, 30);
			this.lblChar5.TabIndex = 4;
			this.lblChar5.Text = "*";
			this.lblChar5.UseCompatibleTextRendering = true;
			this.lblChar5.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar6_Paint);
			this.lblChar5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar4
			// 
			this.lblChar4.AutoSize = true;
			this.lblChar4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar4.Location = new System.Drawing.Point(171, 21);
			this.lblChar4.Name = "lblChar4";
			this.lblChar4.Size = new System.Drawing.Size(22, 30);
			this.lblChar4.TabIndex = 3;
			this.lblChar4.Text = "*";
			this.lblChar4.UseCompatibleTextRendering = true;
			this.lblChar4.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar5_Paint);
			this.lblChar4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar3
			// 
			this.lblChar3.AutoSize = true;
			this.lblChar3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar3.Location = new System.Drawing.Point(133, 21);
			this.lblChar3.Name = "lblChar3";
			this.lblChar3.Size = new System.Drawing.Size(22, 30);
			this.lblChar3.TabIndex = 2;
			this.lblChar3.Text = "*";
			this.lblChar3.UseCompatibleTextRendering = true;
			this.lblChar3.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar4_Paint);
			this.lblChar3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar2
			// 
			this.lblChar2.AutoSize = true;
			this.lblChar2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar2.Location = new System.Drawing.Point(95, 21);
			this.lblChar2.Name = "lblChar2";
			this.lblChar2.Size = new System.Drawing.Size(22, 30);
			this.lblChar2.TabIndex = 1;
			this.lblChar2.Text = "*";
			this.lblChar2.UseCompatibleTextRendering = true;
			this.lblChar2.Paint += new System.Windows.Forms.PaintEventHandler(this.LblChar3_Paint);
			this.lblChar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblChar0
			// 
			this.lblChar0.AutoSize = true;
			this.lblChar0.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChar0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblChar0.Location = new System.Drawing.Point(19, 21);
			this.lblChar0.Name = "lblChar0";
			this.lblChar0.Size = new System.Drawing.Size(22, 30);
			this.lblChar0.TabIndex = 0;
			this.lblChar0.Text = "*";
			this.lblChar0.UseCompatibleTextRendering = true;
			this.lblChar0.Paint += new System.Windows.Forms.PaintEventHandler(this.LvlChar1_Paint);
			this.lblChar0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(1, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hidden Word";
			this.label1.UseCompatibleTextRendering = true;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(245, 212);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(88, 20);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(357, 37);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(82, 21);
			this.panel4.TabIndex = 3;
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1, 4);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Information";
			this.label2.UseCompatibleTextRendering = true;
			this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblAddCharInfo);
			this.panel5.Location = new System.Drawing.Point(345, 47);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(174, 164);
			this.panel5.TabIndex = 4;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// lblAddCharInfo
			// 
			this.lblAddCharInfo.AutoSize = true;
			this.lblAddCharInfo.Font = new System.Drawing.Font("Verdana", 8F);
			this.lblAddCharInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblAddCharInfo.Location = new System.Drawing.Point(6, 12);
			this.lblAddCharInfo.Name = "lblAddCharInfo";
			this.lblAddCharInfo.Size = new System.Drawing.Size(158, 18);
			this.lblAddCharInfo.TabIndex = 0;
			this.lblAddCharInfo.Text = "Submit a character to begin";
			this.lblAddCharInfo.UseCompatibleTextRendering = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 4);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(526, 3);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSubmit.Image = global::part_8.Properties.Resources.chrome_eQbkOh3eCb;
			this.btnSubmit.Location = new System.Drawing.Point(262, 181);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(74, 30);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			this.btnSubmit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSubmit_Paint);
			this.btnSubmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseDown);
			this.btnSubmit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::part_8.Properties.Resources.first;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(211, 269);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DimGray;
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExit.Image = global::part_8.Properties.Resources.chrome_eQbkOh3eCb;
			this.btnExit.Location = new System.Drawing.Point(470, 12);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(50, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.button1_Click);
			this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
			this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseDown);
			this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtUserEntry);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.listUsedChar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblGameTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Part 8: Hangman";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragAnywhere_MouseDown);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblChar1;
        private System.Windows.Forms.Label lblChar6;
        private System.Windows.Forms.Label lblChar5;
        private System.Windows.Forms.Label lblChar4;
        private System.Windows.Forms.Label lblChar3;
        private System.Windows.Forms.Label lblChar2;
        private System.Windows.Forms.Label lblChar0;
		private System.Windows.Forms.Label lblAddCharInfo;
	}
}


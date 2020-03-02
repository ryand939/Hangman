using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace part_8
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //set up list for the used characters
        List<char> usedChar = new List<char>();
        List<Label> hiddenChar = new List<Label>();


        bool duplicateChar;
        bool incorrectEntry;
        string secretWord = "test13s";
        int incorrectCount = 0;
        int correctCharCheck = 0;
        bool gameComplete = false;
        string winMessage = "Winner!";
        string loseMessage = "Loser! ";
        bool paintCharRed = false;

        public Form1()
        {
            InitializeComponent();
            listUsedChar.DataSource = usedChar;
            hiddenChar.Add(lblChar0);
            hiddenChar.Add(lblChar1);
            hiddenChar.Add(lblChar2);
            hiddenChar.Add(lblChar3);
            hiddenChar.Add(lblChar4);
            hiddenChar.Add(lblChar5);
            hiddenChar.Add(lblChar6);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (gameComplete == false)
            {
                correctCharCheck = 0;
                duplicateChar = false;
                incorrectEntry = true;
                if (txtUserEntry.Text != "" && txtUserEntry.Text != " ") //if userentry is not blank or SPACE
                {
                    for (int x = 0; x < usedChar.Count; x++) //for every item in the list
                    {
                        if (txtUserEntry.Text[0] == usedChar[x])//check every char that is already in the list
                        {                                       //check if its a duplicate
                            duplicateChar = true;               //if it is a duplicate, make duplicatechar true
                        }
                    }
                    if (duplicateChar == false)
                    {
                        char userEntry = txtUserEntry.Text[0];
                        for (int x = 0; x < secretWord.Length; x++)//for every character in the secret word
                        {
                            if (userEntry == secretWord[x])         //check if the secret string contains the character entered
                            {                                      //if it does, set the label to reveal the specific character
                                hiddenChar[x].Text = secretWord[x].ToString();
                                hiddenChar[x].Location = new Point(hiddenChar[x].Location.X, hiddenChar[x].Location.Y - 6);
                                //bump the label up a bit just because it looks better
                                incorrectEntry = false;
                            }
                        }
                        usedChar.Add(userEntry);
                        listUsedChar.DataSource = null;
                        listUsedChar.DataSource = usedChar;

                    }
                    if (incorrectEntry == true && duplicateChar == false)
                    {
                        incorrectCount++;
                        switch (incorrectCount)
                        {
                            case 1:
                                pictureBox1.Image = Properties.Resources.second;
                                break;
                            case 2:
                                pictureBox1.Image = Properties.Resources.third;
                                break;
                            case 3:
                                pictureBox1.Image = Properties.Resources.fourth;
                                break;
                            case 4:
                                pictureBox1.Image = Properties.Resources.fifth;
                                break;
                            case 5:
                                pictureBox1.Image = Properties.Resources.sixth;
                                break;
                            case 6:
                                pictureBox1.Image = Properties.Resources.seventh;
                                break;
                        }
                    }
                }

                txtUserEntry.Text = ""; //delete the entry AFTER it has been added or ignored

                //check if the full word has been spelled out
                for (int x = 0; x < secretWord.Length; x++)
                {
                    if (secretWord[x].ToString() == hiddenChar[x].Text)
                    {
                        correctCharCheck++;
                    }
                }
                if (correctCharCheck == 7)
                {
                    gameComplete = true;
                    
                }
                if(incorrectCount == 6)
                {
                    gameComplete = true;
                    for (int x = 0; x < secretWord.Length; x++) //reveal the remaining characters in red
                    {
                        if(hiddenChar[x].Text == "*")
                        {
                            paintCharRed = true;
                            hiddenChar[x].Text = secretWord[x].ToString();
                        }
                    }
                }
            }
            

        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.Black;
            var borderStyle = ButtonBorderStyle.Outset;
            var borderWidth = 4;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0,0,this.Width,this.Height),
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset, //right side
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset); //bottom side
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            var borderStyleTopLeft = ButtonBorderStyle.Outset;
            var borderStyleBottomRight = ButtonBorderStyle.Inset;
            var borderWidth = 2; //default
            var borderColor = Color.Black;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0,0, btnExit.Width, btnExit.Height),
                                borderColor,//left
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//top
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//right
                                borderWidth,
                                borderStyleBottomRight,
                                borderColor,//left
                                borderWidth,
                                borderStyleBottomRight);
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            var borderStyle = ButtonBorderStyle.Outset;
            var borderWidth = 2;
            var borderColor = Color.Black;
            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset, //right side
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset); //bottom side
        }



       

        private void txtUserEntry_MouseEnter(object sender, EventArgs e)
        {
            txtUserEntry.ForeColor = Color.Silver;
        }

        private void txtUserEntry_MouseLeave(object sender, EventArgs e)
        {
            txtUserEntry.ForeColor = Color.DarkGray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var borderStyleTopLeft = ButtonBorderStyle.Outset;
            var borderStyleBottomRight = ButtonBorderStyle.Inset;
            var borderWidth = 2; //default
            var borderColor = Color.Black;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0, 0, panel1.Width, panel1.Height),
                                borderColor,//left
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//top
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//right
                                borderWidth,
                                borderStyleBottomRight,
                                borderColor,//left
                                borderWidth,
                                borderStyleBottomRight);
        }



        private void btnSubmit_Paint(object sender, PaintEventArgs e)
        {
            var borderStyleTopLeft = ButtonBorderStyle.Outset;
            var borderStyleBottomRight = ButtonBorderStyle.Inset;
            var borderWidth = 2; //default
            var borderColor = Color.Black;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0, 0, btnSubmit.Width, btnSubmit.Height),
                                borderColor,//left
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//top
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//right
                                borderWidth,
                                borderStyleBottomRight,
                                borderColor,//left
                                borderWidth,
                                borderStyleBottomRight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var borderStyleTopLeft = ButtonBorderStyle.Outset;
            var borderStyleBottomRight = ButtonBorderStyle.Inset;
            var borderWidth = 2; //default
            var borderColor = Color.Black;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0, 0, panel2.Width, panel2.Height),
                                borderColor,//left
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//top
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//right
                                borderWidth,
                                borderStyleBottomRight,
                                borderColor,//left
                                borderWidth,
                                borderStyleBottomRight);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e) //DROPSHADOW FOR LABEL
        {
           Font drawBoldFont = new Font("Verdana", 8, FontStyle.Bold);
           e.Graphics.DrawString(label1.Text, drawBoldFont,
           new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            var borderStyleTopLeft = ButtonBorderStyle.Outset;
            var borderStyleBottomRight = ButtonBorderStyle.Inset;
            var borderWidth = 2; //default
            var borderColor = Color.Black;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0, 0, panel5.Width, panel5.Height),
                                borderColor,//left
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//top
                                borderWidth,
                                borderStyleTopLeft,
                                borderColor,//right
                                borderWidth,
                                borderStyleBottomRight,
                                borderColor,//left
                                borderWidth,
                                borderStyleBottomRight);
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 8, FontStyle.Bold);
            e.Graphics.DrawString(label2.Text, drawBoldFont,
            new SolidBrush(Color.FromArgb(240, 240, 240)), 0, -1, StringFormat.GenericDefault);

        }

        private void lblGameTitle_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 13, FontStyle.Bold);
                e.Graphics.DrawString(lblGameTitle.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(179, 226, 46)), -1, -1, StringFormat.GenericDefault);
        }

        private void btnExit_MouseDown(object sender, MouseEventArgs e)
        {
            btnExit.Image = null;
        }

        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {

            btnExit.Image = Properties.Resources.chrome_eQbkOh3eCb;
        }

        private void btnSubmit_MouseDown(object sender, MouseEventArgs e)
        {

            btnSubmit.Image = null;
        }

        private void btnSubmit_MouseUp(object sender, MouseEventArgs e)
        {

            btnSubmit.Image = Properties.Resources.chrome_eQbkOh3eCb;
        }

        private void listUsedChar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LvlChar1_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar0.Location = new Point(lblChar0.Location.X, lblChar0.Location.Y - 6);
                e.Graphics.DrawString(lblChar0.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            { 
                e.Graphics.DrawString(lblChar0.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240,240,240)), -1,-1, StringFormat.GenericDefault);
            }
        }

        private void LblChar2_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar1.Location = new Point(lblChar1.Location.X, lblChar1.Location.Y - 6);
                e.Graphics.DrawString(lblChar1.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar1.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void LblChar3_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar2.Location = new Point(lblChar2.Location.X, lblChar2.Location.Y - 6);
                e.Graphics.DrawString(lblChar2.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar2.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void LblChar4_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar3.Location = new Point(lblChar3.Location.X, lblChar3.Location.Y - 6);
                e.Graphics.DrawString(lblChar3.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar3.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void LblChar5_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar4.Location = new Point(lblChar4.Location.X, lblChar4.Location.Y - 6);
                e.Graphics.DrawString(lblChar4.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar4.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void LblChar6_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar5.Location = new Point(lblChar5.Location.X, lblChar5.Location.Y - 6);
                e.Graphics.DrawString(lblChar5.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar5.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void LblChar7_Paint(object sender, PaintEventArgs e)
        {
            Font drawBoldFont = new Font("Verdana", 15, FontStyle.Bold);
            if (paintCharRed)
            {
                lblChar6.Location = new Point(lblChar6.Location.X, lblChar6.Location.Y - 6);
                e.Graphics.DrawString(lblChar6.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(196, 13, 0)), -1, -1, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(lblChar6.Text, drawBoldFont,
                new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);
            }
        }

        private void dragAnywhere_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}

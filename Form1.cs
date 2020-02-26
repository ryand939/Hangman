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

        string secretWord = "test";
        public Form1()
        {
            InitializeComponent();
            listUsedChar.DataSource = usedChar;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtUserEntry.Text != "")
            {
            char userEntry = txtUserEntry.Text[0];
            usedChar.Add(userEntry);
            listUsedChar.DataSource = null;
            listUsedChar.DataSource = usedChar;
            }
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
            new SolidBrush(Color.FromArgb(240, 240, 240)), -1, -1, StringFormat.GenericDefault);

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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void listUsedChar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

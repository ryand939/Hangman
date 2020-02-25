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

        
        public Form1()
        {
            InitializeComponent();
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
            var borderWidth = 3; //default
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

        

        private void lblGameTitle_MouseLeave(object sender, EventArgs e)
        {

            lblGameTitle.ForeColor = Color.Silver;
        }

        private void lblGameTitle_MouseEnter(object sender, EventArgs e)
        {

            lblGameTitle.ForeColor = Color.DarkGray;
        }

        private void txtUserEntry_MouseEnter(object sender, EventArgs e)
        {
            txtUserEntry.ForeColor = Color.Silver;
        }

        private void txtUserEntry_MouseLeave(object sender, EventArgs e)
        {
            txtUserEntry.ForeColor = Color.DarkGray;
        }
    }
}

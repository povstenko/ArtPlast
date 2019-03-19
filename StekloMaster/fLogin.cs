using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class fLogin : Form
    {
        LogInPage signIn;
        SignUpPage signUp;

        private Point mouseOffset;
        private bool isMouseDown = false;

        public fLogin()
        {
            InitializeComponent();

            btnExit.Parent = pictureBox1;
            btnExit.BackColor = Color.Transparent;

            signUp = new SignUpPage(this);
            this.Controls.Add(signUp);
            signUp.Top = 100;
            signUp.BringToFront();
            signUp.Visible = false;

            signIn = new LogInPage(this);
            this.Controls.Add(signIn);
            signIn.Top = 190;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (signIn.Visible)
            {
                lbl1.Text = "Have an account?";
                lbl2.Text = "Log In.";
                label3.Top = 20;
            }
            else
            {
                lbl1.Text = "Don't have an account?";
                lbl2.Text = "Sign Up.";
                label3.Top = 50;
            }
            signIn.Visible = !signIn.Visible;
            signUp.Visible = !signUp.Visible;
        }




        // Design
        private void pTop_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void pTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void pTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }
    }
}

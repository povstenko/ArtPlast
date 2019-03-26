using System;
using System.Drawing;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class fMain : Form
    {
        // Move window
        private Point mouseOffset;
        private bool isMouseDown = false;

        public fMain(bool isAdmin)
        {
            InitializeComponent();

            HidePages();
            pageHome.Visible = true;
            pSide.Height = button1.Height;
            pSide.Top = button1.Top;

            button4.Visible = isAdmin;
        }

        private void HidePages()
        {
            pageHome.Visible = false;
            pageOrder.Visible = false;
            pageMaterials.Visible = false;
            
            pageDatabase.Visible = false;
        }
        private void MoveSidePointer(Button btn)
        {
            pSide.Height = btn.Height;
            pSide.Top = btn.Top;
        }

        // Menu buttons
        private void button1_Click(object sender, EventArgs e)
        {
            HidePages();
            MoveSidePointer((Button)sender);
            pageHome.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HidePages();
            MoveSidePointer((Button)sender);
            pageOrder.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HidePages();
            MoveSidePointer((Button)sender);
            pageMaterials.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            HidePages();
            MoveSidePointer((Button)sender);
            pageDatabase.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Design
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DodgerBlue;
        }
        // Move window
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
    }
}

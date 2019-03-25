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
    public partial class fMain : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public fMain(bool isAdmin)
        {
            InitializeComponent();
            pSide.Height = button1.Height;
            pSide.Top = button1.Top;

            HidePages();
            pageHome.Visible = true;

            button4.Visible = isAdmin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pSide.Height = btn.Height;
            pSide.Top = btn.Top;
        }


        private void btnClose_MouseEnter(object sender, EventArgs e)
        { 
            btnExit.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DodgerBlue;
        }

        
    }
}

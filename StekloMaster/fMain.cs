using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class fMain : Form
    {
        // Move window
        private Point mouseOffset;
        private bool isMouseDown = false;

        // form shadow
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }


        public fMain(bool isAdmin)
        {
            m_aeroEnabled = true;
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

            pTop.BackColor = SystemColors.Menu;
            btnExit.BackColor = SystemColors.Menu;
            btnExit.BackgroundImage = Properties.Resources.icons8_delete_sign_24px;
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
            pTop.BackColor = Color.DodgerBlue;
            btnExit.BackColor = Color.DodgerBlue;
            pageDatabase.Visible = true;
            btnExit.BackgroundImage = Properties.Resources.close;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=support&oq=support&aqs=chrome..69i57j0l5.2975j0j7&sourceid=chrome&ie=UTF-8");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Design
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.BackgroundImage = Properties.Resources.close;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            if(pageDatabase.Visible)
            {
                btnExit.BackColor = Color.DodgerBlue;
                btnExit.BackgroundImage = Properties.Resources.close;
            }
            else
            {
                btnExit.BackColor = SystemColors.Menu;
                btnExit.BackgroundImage = Properties.Resources.icons8_delete_sign_24px;
            }
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

        // Form Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderDemo
{
    public partial class Form1 : Form
    {
        const int offset = 10;

        public Form1()
        {
            InitializeComponent();

            ExpandCollapseSettings();
        }

        private void ExpandCollapseSettings()
        {
            btn1.Tag = 0;
            btn2.Tag = 0;
            btn3.Tag = 0;

            btn1.Top = offset;
            btn2.Top = btn1.Top + btn1.Height + offset;
            btn3.Top = btn2.Top + btn2.Height + offset;

            p1.Width = btn1.Width;
            p2.Width = btn2.Width;
            p3.Width = btn3.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)btn1.Tag == 0)
            {
                // expand
                btn1.Image = global::OrderDemo.Properties.Resources.icons8_collapse_arrow_24;
                p1.Top = btn1.Bottom;
                p1.Visible = true;

                btn2.Top = p1.Bottom + offset;
                p2.Top = btn2.Bottom;

                if ((int)btn2.Tag == 0)
                    btn3.Top = btn2.Bottom + offset;
                else
                    btn3.Top = p2.Bottom + offset;

                p3.Top = btn3.Bottom;

                btn1.Tag = 1;
            }
            else
            {
                // hide
                btn1.Image = global::OrderDemo.Properties.Resources.icons8_expand_arrow_24;
                p1.Visible = false;

                btn2.Top = btn1.Bottom + offset;
                p2.Top = btn2.Bottom;

                if ((int)btn2.Tag == 0)
                    btn3.Top = btn2.Bottom + offset;
                else
                    btn3.Top = p2.Bottom + offset;

                p3.Top = btn3.Bottom;

                btn1.Tag = 0;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((int)btn2.Tag == 0)
            {
                // expand
                btn2.Image = global::OrderDemo.Properties.Resources.icons8_collapse_arrow_24;
                p2.Top = btn2.Bottom;
                p2.Visible = true;

                btn3.Top = p2.Bottom + offset;
                p3.Top = btn3.Bottom;

                btn2.Tag = 1;
            }
            else
            {
                // hide
                btn2.Image = global::OrderDemo.Properties.Resources.icons8_expand_arrow_24;
                p2.Visible = false;

                btn3.Top = btn2.Bottom + offset;
                p3.Top = btn3.Bottom;

                btn2.Tag = 0;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((int)btn3.Tag == 0)
            {
                // expand
                btn3.Image = global::OrderDemo.Properties.Resources.icons8_collapse_arrow_24;
                p3.Top = btn3.Bottom;
                p3.Visible = true;

                btn3.Tag = 1;
            }
            else
            {
                // hide
                btn3.Image = global::OrderDemo.Properties.Resources.icons8_expand_arrow_24;
                p3.Visible = false;

                btn3.Tag = 0;
            }
        }
    }
}
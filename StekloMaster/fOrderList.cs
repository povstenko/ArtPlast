using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class fOrderList : Form
    {
        
        public fOrderList()
        {
            InitializeComponent();
        }
        public fOrderList(string text)
        {
            InitializeComponent();

            richTextBox1.Text = text;
        }
    }
}

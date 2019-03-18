using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWork
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(string user) : this()
        {
            label3.Text = user.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Task clock = new Task(correctTime);
            clock.Start();
        }

        public void correctTime()
        {
            while (true)
            {
                toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
                toolStripStatusLabel4.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            IncomesForm incomesForm = new IncomesForm();
            incomesForm.ShowDialog();
            ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ExpensesForm expensesForm = new ExpensesForm();
            expensesForm.ShowDialog();
            ShowDialog();
        }
    }
}

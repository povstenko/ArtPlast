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
    public partial class fAddUser : Form
    {
        private User user;
        internal User User { get => user;}

        public fAddUser()
        {
            InitializeComponent();
            user = new User();
        }

        // Design
        private void tbxLogin_Click(object sender, EventArgs e)
        {
            p1.BackColor = Color.DodgerBlue;
            p2.BackColor = Color.SlateGray;
            p3.BackColor = Color.SlateGray;
            p4.BackColor = Color.SlateGray;
            p5.BackColor = Color.SlateGray;
        }
        private void tbxPassword_Click(object sender, EventArgs e)
        {
            p2.BackColor = Color.DodgerBlue;
            p1.BackColor = Color.SlateGray;
            p3.BackColor = Color.SlateGray;
            p4.BackColor = Color.SlateGray;
            p5.BackColor = Color.SlateGray;
        }
        private void tbxName_Click(object sender, EventArgs e)
        {
            p3.BackColor = Color.DodgerBlue;
            p1.BackColor = Color.SlateGray;
            p2.BackColor = Color.SlateGray;
            p4.BackColor = Color.SlateGray;
            p5.BackColor = Color.SlateGray;
        }

        private void tbxSurname_Click(object sender, EventArgs e)
        {
            p4.BackColor = Color.DodgerBlue;
            p1.BackColor = Color.SlateGray;
            p2.BackColor = Color.SlateGray;
            p3.BackColor = Color.SlateGray;
            p5.BackColor = Color.SlateGray;
        }

        private void tbxEmail_Click(object sender, EventArgs e)
        {
            p5.BackColor = Color.DodgerBlue;
            p1.BackColor = Color.SlateGray;
            p2.BackColor = Color.SlateGray;
            p3.BackColor = Color.SlateGray;
            p4.BackColor = Color.SlateGray;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User(0, tbxName.Text, tbxSurname.Text, tbxLogin.Text, tbxPassword.Text, tbxEmail.Text, cbxAdmin.Checked);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                user = null;
                MessageBox.Show(ex.Message);
            }
        }
    }
}

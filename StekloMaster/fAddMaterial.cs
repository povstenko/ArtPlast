using System;
using System.Drawing;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class fAddMaterial : Form
    {
        private Material material;
        internal Material Material { get => material;}

        public fAddMaterial()
        {
            InitializeComponent();
            material = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                material = new Material(0, tbxCategory.Text, tbxName.Text, tbxColor.Text, Convert.ToInt32(tbxCost.Text), richTextBox1.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                material = null;
                MessageBox.Show(ex.Message);
            }
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
    }
}

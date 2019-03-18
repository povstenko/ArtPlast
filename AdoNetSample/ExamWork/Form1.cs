using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWork
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        public Form1()
        {

            InitializeComponent();


            strbuilder = new SqlConnectionStringBuilder();
            strbuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            strbuilder.InitialCatalog = "HomeExpense";
            strbuilder.IntegratedSecurity = true;
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Georgiev\ExamWork\ExamWork\ExamWork\HomeExpense.mdf; Integrated Security = True
            //strbuilder.AttachDBFilename = Directory.GetCurrentDirectory()+"..//..//HomeExpense.mdf";
            strbuilder.AttachDBFilename = get_url_database("HomeExpense.mdf");
            sqlConnect = new SqlConnection(strbuilder.ConnectionString);


        }

        private string get_url_database(string databasename)
        {
            string s = $"{DIR_PATH}\\{databasename}";
            return s;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Users where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", sqlConnect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Hide();
                    MainWindow form2 = new MainWindow(textBox1.Text);
                    form2.ShowDialog();
                    ShowDialog();
                }
                else
                {
                label4.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnect != null)
                {
                    sqlConnect.Close();
                }
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                RegistrationForm regForm = new RegistrationForm(sqlConnect);
                regForm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnect != null)
                {
                    sqlConnect.Close();
                }
            }
        }
    }
}

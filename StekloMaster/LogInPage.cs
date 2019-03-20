using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StekloMaster
{
    public partial class LogInPage : UserControl
    {

        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        private fLogin login;
        public LogInPage(fLogin loginForm)
        {
            InitializeComponent();
            login = loginForm;

            strbuilder = new SqlConnectionStringBuilder();
            strbuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            strbuilder.InitialCatalog = "WindowShop";
            strbuilder.IntegratedSecurity = true;

            strbuilder.AttachDBFilename = GetDatabaseURL("WindowShop.mdf");
            sqlConnect = new SqlConnection(strbuilder.ConnectionString);
            
        }
        public LogInPage()
        {
            InitializeComponent();

            login = null;
        }
        private string GetDatabaseURL(string databasename)
        {
            return $"{DIR_PATH}\\{databasename}";
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From [User] where [Login] = '" + tbxLogin.Text + "' and [Password] = '" + tbxPassword.Text + "'", sqlConnect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                {
                    fMain main = new fMain();
                    login.Hide();
                    main.ShowDialog();
                    login.Close();
                }
                else
                {
                    p1.BackColor = Color.Red;
                    p2.BackColor = Color.Red;
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






        // Design
        private void tbxLogin_Click(object sender, EventArgs e)
        {
            p1.BackColor = Color.DodgerBlue;
            p2.BackColor = Color.SlateGray;
        }
        private void tbxPassword_Click(object sender, EventArgs e)
        {
            p2.BackColor = Color.DodgerBlue;
            p1.BackColor = Color.SlateGray;
        }
    }
}

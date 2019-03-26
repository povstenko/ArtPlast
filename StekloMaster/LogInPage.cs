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
        bool isAdmin;
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
            isAdmin = false;
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
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT COUNT (*) FROM [User] where [Login] = '{tbxLogin.Text}' AND [Password] = '{tbxPassword.Text }'", sqlConnect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                {
                    // if account exist
                    sda = new SqlDataAdapter($"SELECT COUNT (*) FROM [User] WHERE [Login] = '{tbxLogin.Text}' AND [Password] = '{tbxPassword.Text }' AND [isAdmin] = 'True'", sqlConnect);
                    dt = new DataTable();
                    sda.Fill(dt);
                    if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                    {
                        // if admin
                        isAdmin = true;
                    }
                    else
                    {
                        //if user
                        isAdmin = false;
                    }
                    fMain main = new fMain(isAdmin);
                    login.Hide();
                    main.ShowDialog();
                    login.Close();
                }
                else
                { 
                    // if account doesnt exist
                    p1.BackColor = Color.Red;
                    p2.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(1 + ex.Message);
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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StekloMaster
{
    public partial class SignUpPage : UserControl
    {
        // Connect
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";
        bool checking = false;

        private fLogin login;

        public SignUpPage(fLogin loginForm)
        {
            InitializeComponent();
            login = loginForm;

            // Connect
            strbuilder = new SqlConnectionStringBuilder();
            strbuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            strbuilder.InitialCatalog = "WindowShop";
            strbuilder.IntegratedSecurity = true;
            strbuilder.AttachDBFilename = GetDatabaseURL("WindowShop.mdf");
            sqlConnect = new SqlConnection(strbuilder.ConnectionString);
        }
        private string GetDatabaseURL(string databasename)
        {
            return $"{DIR_PATH}\\{databasename}";
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                if (!string.IsNullOrEmpty(tbxPassword.Text) && !string.IsNullOrEmpty(tbxLogin.Text)
                    && !string.IsNullOrEmpty(tbxEmail.Text) && !string.IsNullOrEmpty(tbxName.Text)
                    && !string.IsNullOrEmpty(tbxSurname.Text))
                {
                    cmd = new SqlCommand("SELECT*FROM [User]", sqlConnect);
                    reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        if (tbxLogin.Text == Convert.ToString(reader["Login"]))
                        {
                            p1.BackColor = Color.Red;
                            MessageBox.Show("User with that username was created, please choose another username");
                            checking = false;
                            break;
                        }
                        else if (tbxEmail.Text == Convert.ToString(reader["Email"]))
                        {
                            p5.BackColor = Color.Red;
                            MessageBox.Show("User with that email was created, please choose another username");
                            checking = false;
                            break;
                        }
                        else
                        {
                            checking = true;
                        }
                    }
                    if (checking)
                    {
                        reader.Close();
                        SqlCommand cmdAdd = new SqlCommand();
                        cmdAdd.CommandText = "INSERT INTO [User](FirstName, SecondName, Login, Password, Email, isAdmin) VALUES(@name, @surname, @login, @password, @email, @admin)";
                        cmdAdd.Connection = sqlConnect;
                        cmdAdd.Parameters.AddWithValue("name", tbxName.Text);
                        cmdAdd.Parameters.AddWithValue("surname", tbxSurname.Text);
                        cmdAdd.Parameters.AddWithValue("login", tbxLogin.Text);
                        cmdAdd.Parameters.AddWithValue("password", tbxPassword.Text);
                        cmdAdd.Parameters.AddWithValue("email", tbxEmail.Text);
                        cmdAdd.Parameters.AddWithValue("admin", cbxAdmin.Checked);
                        await cmdAdd.ExecuteNonQueryAsync();

                        fMain main = new fMain(cbxAdmin.Checked);
                        login.Hide();
                        main.ShowDialog();
                        login.Close();
                    }
                }
                else
                {
                    p1.BackColor = Color.Red;
                    p2.BackColor = Color.Red;
                    p3.BackColor = Color.Red;
                    p4.BackColor = Color.Red;
                    p5.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                else if (sqlConnect != null)
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
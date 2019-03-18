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

namespace StekloMaster
{
	public partial class fMain : Form
	{
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";
        bool checking = false;
        bool isAdmin = false;
        public fMain()
		{
			InitializeComponent();

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
        private async void RefreshData()
        {
            try
            {
                await sqlConnect.OpenAsync();
                cmd = new SqlCommand("SELECT*FROM [User]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                listBox1.Items.Clear();
                while (await reader.ReadAsync())
                {
                    listBox1.Items.Add($"{reader["FirstName"]} {reader["SecondName"]} {reader["Login"]} {reader["Password"]}");
                }
                reader.Close();
                cmd = new SqlCommand("SELECT*FROM [Materials]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                listBox2.Items.Clear();
                while (await reader.ReadAsync())
                {
                    listBox2.Items.Add($"{reader["Category"]} {reader["Name"]} {reader["Color"]} {reader["CostPerMeter"]}");
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
                    groupBox2.Visible = true;
                }
                else
                {
                    tbxLogin.Clear();
                    tbxPassword.Clear();
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

            //RefreshData();
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                await sqlConnect.OpenAsync();
                if (!string.IsNullOrEmpty(tbxNewPassword.Text) && !string.IsNullOrEmpty(tbxNewLogin.Text) 
                    && !string.IsNullOrEmpty(tbxNewEmail.Text) && !string.IsNullOrEmpty(tbxNewName.Text) 
                    && !string.IsNullOrEmpty(tbxNewSurname.Text))
                {
                    cmd = new SqlCommand("SELECT*FROM [User]", sqlConnect);
                    reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        if (tbxNewPassword.Text == Convert.ToString(reader["Login"]))
                        {
                            MessageBox.Show("User with that username was created, please choose another username");
                            checking = false;
                            //tbxNewPassword.Clear();
                            //tbxNewLogin.Clear();
                            //textBox3.Clear();
                            break;
                        }
                        else
                        {
                            checking = true;
                        }

                    }
                    //if (tbxNewLogin.Text != textBox3.Text)
                    //{
                    //    MessageBox.Show("Entered passwords are not similar");
                    //    checking = false;
                    //    tbxNewPassword.Clear();
                    //    tbxNewLogin.Clear();
                    //    textBox3.Clear();
                    //}
                    //else
                    //{
                    if (checking)
                    {
                        reader.Close();
                        SqlCommand cmdAdd = new SqlCommand();
                        cmdAdd.CommandText = "INSERT INTO [User](FirstName, SecondName, Login, Password, Email, isAdmin) VALUES(@name, @surname, @login, @password, @email, @admin)";
                        cmdAdd.Connection = sqlConnect;
                        cmdAdd.Parameters.AddWithValue("name", tbxNewName.Text);
                        cmdAdd.Parameters.AddWithValue("surname", tbxNewSurname.Text);
                        cmdAdd.Parameters.AddWithValue("login", tbxNewLogin.Text);
                        cmdAdd.Parameters.AddWithValue("password", tbxNewPassword.Text);
                        cmdAdd.Parameters.AddWithValue("email", tbxNewEmail.Text);
                        cmdAdd.Parameters.AddWithValue("admin", chbxAdmin.Checked);
                        await cmdAdd.ExecuteNonQueryAsync();
                        MessageBox.Show($"User {tbxNewLogin.Text} was added....");
                        //tbxNewPassword.Clear();
                        //tbxNewLogin.Clear();
                        //textBox3.Clear();
                    }
                    //}
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

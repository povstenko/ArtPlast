using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWork
{
    public partial class RegistrationForm : Form
    {
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        bool checking = false;

        public RegistrationForm()
        {
            InitializeComponent();

        }

        public RegistrationForm(SqlConnection connect) : this()
        {
            sqlConnect = connect;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    cmd = new SqlCommand("SELECT*FROM Users",sqlConnect);
                    reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        if (textBox1.Text==Convert.ToString(reader["Username"]))
                        {
                            MessageBox.Show("User with that username was created, please choose another username");
                            checking = false;
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            break;
                        }
                        else
                        {
                            checking = true;
                        }

                    }
                    if (textBox2.Text!=textBox3.Text)
                    {
                        MessageBox.Show("Entered passwords are not similar");
                        checking = false;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        if (checking)
                        {
                            reader.Close();
                            SqlCommand cmdAdd = new SqlCommand();
                            cmdAdd.CommandText = "INSERT INTO Users(Username,Password) VALUES(@username,@password)";
                            cmdAdd.Connection = sqlConnect;
                            cmdAdd.Parameters.AddWithValue("username",textBox1.Text);
                            cmdAdd.Parameters.AddWithValue("password", textBox2.Text);
                            await cmdAdd.ExecuteNonQueryAsync();
                            MessageBox.Show($"User {textBox1.Text} was added....");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader!=null)
                {
                    reader.Close();
                }
                else if (sqlConnect!=null)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            Close();
        }
    }
}

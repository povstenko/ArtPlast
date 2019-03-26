using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StekloMaster
{
    public partial class PageDatabase : UserControl
    {
        // Connection
        SqlConnectionStringBuilder strbuilder;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        List<Material> materials;
        List<User> users;

        public PageDatabase()
        {
            InitializeComponent();
            // Connection
            strbuilder = new SqlConnectionStringBuilder();
            strbuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            strbuilder.InitialCatalog = "WindowShop";
            strbuilder.IntegratedSecurity = true;
            strbuilder.AttachDBFilename = GetDatabaseURL("WindowShop.mdf");
            sqlConnect = new SqlConnection(strbuilder.ConnectionString);

            InitializeDataGridView();
            cmbxTables.SelectedIndex = 0;

            dgwMaterials.Visible = true;
            dgwUsers.Visible = false;

            lblDatabase.Text = strbuilder.InitialCatalog;

            materials = new List<Material>();
            users = new List<User>();
        }
        private void PageDatabase_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cmbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        // Add row
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgwMaterials.Visible)
            {
                // add new row in Materials
                fAddMaterial am = new fAddMaterial();
                if (am.ShowDialog() == DialogResult.OK)
                {
                    Material newM = am.Material;
                    sqlConnect.Close();
                    try
                    {
                        await sqlConnect.OpenAsync();
                        cmd = new SqlCommand($"INSERT INTO [Materials] VALUES ('{newM.Category}', '{newM.Name}', '{newM.Color}', {newM.CostPerMeter}, '{newM.Description}')", sqlConnect);
                        reader = await cmd.ExecuteReaderAsync();
                        await reader.ReadAsync();

                        RefreshData();
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
            }
            else
            {
                // add new row in User
                fAddUser au = new fAddUser();
                if (au.ShowDialog() == DialogResult.OK)
                {
                    User newU = au.User;
                    sqlConnect.Close();
                    try
                    {
                        await sqlConnect.OpenAsync();
                        cmd = new SqlCommand($"INSERT INTO [User] VALUES ('{newU.FirstName}', '{newU.SecondName}', '{newU.Login}', '{newU.Password}', '{newU.Email}', '{newU.IsAdmin}')", sqlConnect);
                        reader = await cmd.ExecuteReaderAsync();
                        await reader.ReadAsync();

                        RefreshData();
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
            }
        }

        // Remove row
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwMaterials.Visible)
            {
                // remove row from Materials
                if (dgwMaterials.CurrentCell != null)
                {
                    Material mat = materials[dgwMaterials.CurrentRow.Index];

                    if (MessageBox.Show($"Do you want to delete this row from table [Materials]. It will be deleted permanentaly. Data: ({mat.ToString()})", "Delete row", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        sqlConnect.Close();
                        try
                        {
                            await sqlConnect.OpenAsync();
                            cmd = new SqlCommand($"DELETE FROM [Materials] WHERE [Id] = '{mat.Id}'", sqlConnect);
                            reader = await cmd.ExecuteReaderAsync();
                            await reader.ReadAsync();

                            RefreshData();
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
                }
            }
            else
            {
                // remove row from User
                if (dgwUsers.CurrentCell != null)
                {
                    User user = users[dgwUsers.CurrentRow.Index];

                    if (MessageBox.Show($"Do you want to delete this row from table [User]. It will be deleted permanentaly. Data: ({user.ToString()})", "Delete row", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        sqlConnect.Close();
                        try
                        {
                            await sqlConnect.OpenAsync();
                            cmd = new SqlCommand($"DELETE FROM [User] WHERE [Id] = '{user.Id}'", sqlConnect);
                            reader = await cmd.ExecuteReaderAsync();
                            await reader.ReadAsync();

                            RefreshData();
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
                }
            }
        }

        private void InitializeDataGridView()
        {
            var columnId = new DataGridViewColumn();
            columnId.HeaderText = "Id"; //текст в шапке
            columnId.Width = 30; //ширина колонки
            columnId.ReadOnly = true; //значение в этой колонке нельзя править
            columnId.Name = "id"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            columnId.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            columnId.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Category"; //текст в шапке
            column1.Width = 125; //ширина колонки
            column1.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            column2.Width = 125;
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Color";
            column3.Width = 93;
            column3.Name = "color";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "CostPerMeter";
            column4.Name = "cost";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.Width = 269;
            column5.HeaderText = "Description";
            column5.Name = "description";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            dgwMaterials.Columns.Add(columnId);
            dgwMaterials.Columns.Add(column1);
            dgwMaterials.Columns.Add(column2);
            dgwMaterials.Columns.Add(column3);
            dgwMaterials.Columns.Add(column4);
            dgwMaterials.Columns.Add(column5);

            var columnId2 = new DataGridViewColumn();
            columnId2.HeaderText = "Id"; //текст в шапке
            columnId2.Width = 30; //ширина колонки
            columnId2.ReadOnly = true; //значение в этой колонке нельзя править
            columnId2.Name = "id"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            columnId2.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            columnId2.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "FirstName"; //текст в шапке
            column6.Width = 125; //ширина колонки
            column6.Name = "firstn"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column6.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "SacondName";
            column7.Width = 125;
            column7.Name = "secondn";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Login";
            column8.Width = 93;
            column8.Name = "login";
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Password";
            column9.Name = "password";
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.Width = 200;
            column10.HeaderText = "Email";
            column10.Name = "email";
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.Width = 69;
            column11.HeaderText = "isAdmin";
            column11.Name = "admin";
            column11.CellTemplate = new DataGridViewTextBoxCell();

            dgwUsers.Columns.Add(columnId2);
            dgwUsers.Columns.Add(column6);
            dgwUsers.Columns.Add(column7);
            dgwUsers.Columns.Add(column8);
            dgwUsers.Columns.Add(column9);
            dgwUsers.Columns.Add(column10);
            dgwUsers.Columns.Add(column11);
        }

        // Data
        private string GetDatabaseURL(string databasename)
        {
            return $"{DIR_PATH}\\{databasename}";
        }
        private async void RefreshData()
        {
            sqlConnect.Close();
            try
            {
                await sqlConnect.OpenAsync();

                cmd = new SqlCommand($"SELECT * FROM {cmbxTables.Text} {tbxCommand.Text}", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwMaterials.Rows.Clear();
                dgwUsers.Rows.Clear();
                materials.Clear();
                users.Clear();
                while (await reader.ReadAsync())
                {
                    if(cmbxTables.Text == "[Materials]")
                    {
                        dgwMaterials.Visible = true;
                        dgwUsers.Visible = false;
                        dgwMaterials.Rows.Add(reader["Id"], reader["Category"], reader["Name"], reader["Color"], reader["CostPerMeter"], reader["Description"]);

                        int id = (int)reader["Id"];
                        string cat = (string)reader["Category"];
                        string name = (string)reader["Name"];
                        string color = (string)reader["Color"];
                        int cost = Convert.ToInt32(reader["CostPerMeter"]);
                        string descr = (string)reader["Description"];
                        materials.Add(new Material(id, cat, name, color, cost, descr));
                    }
                    else
                    {
                        dgwUsers.Visible = true;
                        dgwMaterials.Visible = false;
                        dgwUsers.Rows.Add(reader["Id"], reader["FirstName"], reader["SecondName"], reader["Login"], reader["Password"], reader["Email"], reader["isAdmin"]);
                        
                        User u = new User(
                            (int)reader["Id"], 
                            (string)reader["FirstName"],
                            (string)reader["SecondName"], 
                            (string)reader["Login"], 
                            (string)reader["Password"], 
                            (string)reader["Email"], 
                            (bool)reader["isAdmin"]);
                        users.Add(u);
                    }
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
    }
}

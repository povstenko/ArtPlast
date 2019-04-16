using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace StekloMaster
{
    public partial class PageMaterials : UserControl
    {
        // Connection
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        List<string> infos;
        bool isAsc;

        public PageMaterials()
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
            cmbxSearchIn.SelectedIndex = 0;
            cmbxOrder.SelectedIndex = 0;

            infos = new List<string>();
            isAsc = true;
        }
        private void PageMaterials_Load(object sender, EventArgs e)
        {
            RefreshData(null);
		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                dgwMaterials.Rows.Clear();
                SearchData(cmbxSearchIn.Text, tbxSearch.Text, cmbxOrder.Text);
            }
            else
            {
                dgwMaterials.Rows.Clear();
                RefreshData(cmbxOrder.Text);
            }
        }

        private void InitializeDataGridView()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Category"; //текст в шапке
            column1.Width = 150; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            column2.Width = 150;
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Color";
            column3.Width = 93;
            column3.Name = "color";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Cost";
            column4.Name = "Cost";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dgwMaterials.Columns.Add(column1);
            dgwMaterials.Columns.Add(column2);
            dgwMaterials.Columns.Add(column3);
            dgwMaterials.Columns.Add(column4);

            dgwMaterials.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
        }

        // Data
        private string GetDatabaseURL(string databasename)
        {
            return $"{DIR_PATH}\\{databasename}";
        }
        private async void RefreshData(string order)
        {
            sqlConnect.Close();
            try
            {
                string asc = "";
                if (isAsc)
                    asc = "ASC";
                else
                    asc = "DESC";

                await sqlConnect.OpenAsync();
                if (order != null)
                    cmd = new SqlCommand($"SELECT*FROM [Materials] ORDER BY [{order}] {asc}", sqlConnect);
                else
                    cmd = new SqlCommand($"SELECT*FROM [Materials] ORDER BY [Category] {asc}", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwMaterials.Rows.Clear();
                infos.Clear();
                while (await reader.ReadAsync())
                {
                    dgwMaterials.Rows.Add(reader["Category"], reader["Name"], reader["Color"], reader["CostPerMeter"]);
                    infos.Add((string)reader["Description"]);
                }
				rtbxInfo.Text = infos[dgwMaterials.CurrentCell.RowIndex];
			}
            catch (Exception)
            {

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
        private async void SearchData(string where, string what, string how)
        {
            try
            {
                sqlConnect.Close();
                await sqlConnect.OpenAsync();
                cmd = new SqlCommand($"SELECT*FROM [Materials] WHERE [{where}] LIKE '%{what}%' ORDER BY [{how}]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                infos.Clear();
                while (await reader.ReadAsync())
                {
                    dgwMaterials.Rows.Add(reader["Category"], reader["Name"], reader["Color"], reader["CostPerMeter"]);
                    infos.Add((string)reader["Description"]);
                }
                reader.Close();
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

        // Show Description
        private void dgwMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMaterials.CurrentCell.RowIndex != -1)
            {
                rtbxInfo.Text = infos[dgwMaterials.CurrentCell.RowIndex];
            }
        }

        // Asc/Desc mode
        private void btnAsc_Click(object sender, EventArgs e)
        {
            if(btnAsc.BackColor == Color.WhiteSmoke)
            {
                btnAsc.BackColor = Color.DodgerBlue;
                btnAsc.Image = Properties.Resources.ASCW24;
                btnDesc.BackColor = Color.WhiteSmoke;
                btnDesc.Image = Properties.Resources.DESCB24;

                isAsc = true;
                RefreshData(null);
            }
        }
        private void btnDesc_Click(object sender, EventArgs e)
        {
            if (btnDesc.BackColor == Color.WhiteSmoke)
            {
                btnDesc.BackColor = Color.DodgerBlue;
                btnDesc.Image = Properties.Resources.DESCW24;
                btnAsc.BackColor = Color.WhiteSmoke;
                btnAsc.Image = Properties.Resources.ASCB24;

                isAsc = false;
                RefreshData(null);
            }
        }
    }
}
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
    public partial class PageDatabase : UserControl
    {
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        public PageDatabase()
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

        private async void RefreshData(string order)
        {
            sqlConnect.Close();
            try
            {

                await sqlConnect.OpenAsync();

                cmd = new SqlCommand($"SELECT*FROM [Materials] ORDER BY [Category] ASC", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwMaterials.Rows.Clear();

                while (await reader.ReadAsync())
                {
                    dgwMaterials.Rows.Add(reader["Category"], reader["Name"], reader["Color"], reader["CostPerMeter"]);
                }
            }
            catch (Exception ex)
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
    }
}

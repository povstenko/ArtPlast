using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StekloMaster
{
    public partial class PageOrder : UserControl
    {
        List<Material> materials;
        List<Material> cart;
        string orderString;
        string NL = Environment.NewLine;
        string BR = "-------------------------------------------";

        // Connection
        SqlConnectionStringBuilder strbuilder = null;
        SqlConnection sqlConnect = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string DIR_PATH = Directory.GetCurrentDirectory() + "..\\..\\..\\";

        // Design
        const int OFFSET = 10;
        Image IMG_COLLAPSE = global::StekloMaster.Properties.Resources.collapse_arrow_24;
        Image IMG_EXPAND = global::StekloMaster.Properties.Resources.expand_arrow_24;

        public PageOrder()
        {
            InitializeComponent();
            InitializeExpandMenu();
            InitializeDataGridView();

            materials = new List<Material>();
            cart = new List<Material>();
            orderString = "";
            btnBuy.Enabled = false;

            // Connection
            strbuilder = new SqlConnectionStringBuilder();
            strbuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            strbuilder.InitialCatalog = "WindowShop";
            strbuilder.IntegratedSecurity = true;
            strbuilder.AttachDBFilename = GetDatabaseURL("WindowShop.mdf");
            sqlConnect = new SqlConnection(strbuilder.ConnectionString);
        }
        private void PageOrder_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        // Price
        private double ComputePrice(Material frame, Material glass, List<Material> furniture)
        {
            double frameCost = 0;
            if (frame != null)
            {
                frameCost = (double)frame.CostPerMeter;
                
            }

            double glassCost = 0;
            if (glass != null)
            {
                glassCost = (double)glass.CostPerMeter;

            }

            double furnitureCost = 0;
            if (furniture != null)
            {
                foreach (Material i in furniture)
                    furnitureCost += (double)i.CostPerMeter;
            }

            double h = 0.0;
            double w = 0.0;
            double c = 0.0;//frame width
            try
            {
                h = Convert.ToDouble(tbxH.Text);
                w = Convert.ToDouble(tbxW.Text);
                c = Convert.ToDouble(tbxFrame.Text);
            }
            catch(Exception) {/*if cant convert*/}

            double formula1 = h*w - 2*h*c - 2*w*c + 4*c*c;// = (h-2c)(w-2c) =
            double formula2 = h*w - formula1;// = 2c(h + w - 2c).
            double res = (frameCost * formula2) + (glassCost * formula1) + furnitureCost;

            //build string
            if(frame != null && glass != null && furniture != null)
            {
                orderString = "";
                orderString += $"                    ORDER                 " + NL;
                orderString += BR + NL;
                orderString += $"FRAME" + NL;
                orderString += $"{frame?.Name} {frame?.Color} ----------- ${frameCost * formula2}" + NL;
                orderString += BR + NL;
                orderString += $"GLASS" + NL;
                orderString += $"{glass?.Name} {glass?.Color} ----------- ${glassCost * formula1}" + NL;
                orderString += BR + NL;
                orderString += $"FURNITURE" + NL;
                foreach (Material m in furniture)
                orderString += $"{m.Name} {m.Color} ----------- ${m.CostPerMeter}" + NL;
                orderString += BR + NL;
                orderString += $"TOTAL" + NL;
                orderString += $"Price                          ${res}" + NL;
                orderString += $"Full Price ----------- ${res / 10.0 + res}" + NL;
                orderString += BR;

                btnBuy.Enabled = true;
            }
            else
                btnBuy.Enabled = false;

            return res;
        }
        private void UpdatePrice()
        {
            if (tbxH.Text != "" && tbxW.Text != "")
            {
                Material f = null, g = null;// frame glass
                List<Material> fs = null;// furnitures
                bool tmp = false;
                foreach (Material item in cart)
                    if (item.Category == "Frame")
                        f = item;
                    else if (item.Category == "Glass")
                        g = item;
                    else
                        tmp = true;
                if (tmp)
                {
                    fs = new List<Material>();
                    foreach (Material item in cart)
                        if (item.Category != "Glass" && item.Category != "Frame")
                            fs.Add(item);
                }

                double res = ComputePrice(f, g, fs);
                lblPrice.Text = res.ToString();
                lblFullPrice.Text = (res / 10.0 + res).ToString();
            }
        }
        private void tbxH_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        // Data
        private void InitializeDataGridView()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Category"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Color";
            column3.Name = "color";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Cost";
            column4.Width = 67; //ширина колонки
            column4.Name = "Cost";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dgwCart.Columns.Add(column1);
            dgwCart.Columns.Add(column2);
            dgwCart.Columns.Add(column3);
            dgwCart.Columns.Add(column4);
            dgwCart.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Name";
            column6.Name = "name";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Color";
            column7.Name = "color";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Cost";
            column8.Width = 80; //ширина колонки
            column8.Name = "Cost";
            column8.CellTemplate = new DataGridViewTextBoxCell();

            dgwFrame.Columns.Add(column6);
            dgwFrame.Columns.Add(column7);
            dgwFrame.Columns.Add(column8);
            dgwFrame.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Name";
            column10.Name = "name";
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Color";
            column11.Name = "color";
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Cost";
            column12.Width = 80; //ширина колонки
            column12.Name = "Cost";
            column12.CellTemplate = new DataGridViewTextBoxCell();

            dgwGlass.Columns.Add(column10);
            dgwGlass.Columns.Add(column11);
            dgwGlass.Columns.Add(column12);
            dgwGlass.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Category"; //текст в шапке
            column13.Width = 70; //ширина колонки
            column13.ReadOnly = true; //значение в этой колонке нельзя править
            column13.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column13.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Name";
            column14.Name = "name";
            column14.CellTemplate = new DataGridViewTextBoxCell();

            var column15 = new DataGridViewColumn();
            column15.HeaderText = "Color";
            column15.Width = 60;
            column15.Name = "color";
            column15.CellTemplate = new DataGridViewTextBoxCell();

            var column16 = new DataGridViewColumn();
            column16.HeaderText = "Cost";
            column16.Width = 50; //ширина колонки
            column16.Name = "Cost";
            column16.CellTemplate = new DataGridViewTextBoxCell();

            dgwFurniture.Columns.Add(column13);
            dgwFurniture.Columns.Add(column14);
            dgwFurniture.Columns.Add(column15);
            dgwFurniture.Columns.Add(column16);
            dgwFurniture.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
        }
        private string GetDatabaseURL(string databasename)
        {
            return $"{DIR_PATH}\\{databasename}";
        }
        private async void RefreshData()
        {
            sqlConnect.Close();
            try
            {
                // add to Frame
                await sqlConnect.OpenAsync();
                cmd = new SqlCommand($"SELECT*FROM [Materials] WHERE [Category] = 'Frame' ORDER BY [Name],[CostPerMeter]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwFrame.Rows.Clear();
                while (await reader.ReadAsync())
                {
                    dgwFrame.Rows.Add(reader["Name"], reader["Color"], reader["CostPerMeter"]);
                }

                // add to Glass
                reader.Close();
                cmd = new SqlCommand($"SELECT*FROM [Materials] WHERE [Category] = 'Glass' ORDER BY [Name],[CostPerMeter]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwGlass.Rows.Clear();
                while (await reader.ReadAsync())
                {
                    dgwGlass.Rows.Add(reader["Name"], reader["Color"], reader["CostPerMeter"]);
                }

                // add to Furniture
                reader.Close();
                cmd = new SqlCommand($"SELECT*FROM [Materials] WHERE [Category] = 'Sill' OR [Category] = 'Furniture' OR [Category] = 'Section' ORDER BY [Category],[Name],[Color]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                dgwFurniture.Rows.Clear();
                while (await reader.ReadAsync())
                {
                    dgwFurniture.Rows.Add(reader["Category"], reader["Name"], reader["Color"], reader["CostPerMeter"]);
                }

                // add to list from database
                reader.Close();
                cmd = new SqlCommand($"SELECT*FROM [Materials]", sqlConnect);
                reader = await cmd.ExecuteReaderAsync();
                materials.Clear();
                while (await reader.ReadAsync())
                {
                    Material m = new Material(Convert.ToInt32(reader["Id"]),
                        (string)reader["Category"],
                        (string)reader["Name"],
                        (string)reader["Color"],
                        Convert.ToInt32(reader["CostPerMeter"]),
                        (string)reader["Description"]);
                    materials.Add(m);
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

        // Add/Remove to Cart
        private void AddToCart(string cat, string n, string col, string cost)
        {
            foreach (Material item in materials)
                if(item.Category == cat &&
                    item.Name == n &&
                    item.Color == col &&
                    item.CostPerMeter == Convert.ToInt32(cost))
                {

                    int buf = 0;
                    if(cat == "Frame" || cat == "Glass")
                        foreach (Material j in cart)
                            if (j.Category == cat) buf++;
                    if(buf == 0)
                        cart.Add(item);
                    else MessageBox.Show("You cant add more " + cat +" in your cart.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //update dataGridView
                    dgwCart.Rows.Clear();
                    foreach (Material i in cart)
                        dgwCart.Rows.Add(i.Category, i.Name, i.Color, i.CostPerMeter);
                }
            UpdatePrice();
        }
        private void RemoveFromCart(string cat, string n, string col, string cost)
        {
            foreach (Material item in materials)
                if (item.Category == cat &&
                    item.Name == n &&
                    item.Color == col &&
                    item.CostPerMeter == Convert.ToInt32(cost))
                {
                    cart.Remove(item);

                    //update dataGridView
                    dgwCart.Rows.Clear();
                    foreach (Material i in cart)
                        dgwCart.Rows.Add(i.Category, i.Name, i.Color, i.CostPerMeter);
                }
            UpdatePrice();
        }
        // 
        private void dgwFrame_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left && dgwFrame.CurrentCell != null)
            {
                DataGridViewCellCollection cells = dgwFrame.CurrentRow.Cells;

                string name = cells[0].Value.ToString();
                string color = cells[1].Value.ToString();
                string cost = cells[2].Value.ToString();

                AddToCart("Frame", name, color, cost);
            }
        }
        private void dgwGlass_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left && dgwGlass.CurrentCell != null)
            {
                DataGridViewCellCollection cells = dgwGlass.CurrentRow.Cells;

                string name = cells[0].Value.ToString();
                string color = cells[1].Value.ToString();
                string cost = cells[2].Value.ToString();

                AddToCart("Glass", name, color, cost);
            }
        }
        private void dgwFurniture_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left && dgwFurniture.CurrentCell != null)
            {
                DataGridViewCellCollection cells = dgwFurniture.CurrentRow.Cells;

                string category = cells[0].Value.ToString();
                string name = cells[1].Value.ToString();
                string color = cells[2].Value.ToString();
                string cost = cells[3].Value.ToString();

                AddToCart(category, name, color, cost);
            }
        }
        private void dgwCart_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left && dgwCart.CurrentCell != null)
            {
                DataGridViewCellCollection cells = dgwCart.CurrentRow.Cells;

                string category = cells[0].Value.ToString();
                string name = cells[1].Value.ToString();
                string color = cells[2].Value.ToString();
                string cost = cells[3].Value.ToString();

                RemoveFromCart(category, name, color, cost);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            fOrderList ol = new fOrderList(orderString);
            ol.ShowDialog();
        }

        // Design
        private void tbxH_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DodgerBlue;
            panel2.BackColor = Color.SlateGray;
			panel3.BackColor = Color.SlateGray;
		}
        private void tbxW_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DodgerBlue;
            panel1.BackColor = Color.SlateGray;
			panel3.BackColor = Color.SlateGray;
		}
		private void tbxFrame_Click(object sender, EventArgs e)
		{
			panel3.BackColor = Color.DodgerBlue;
			panel1.BackColor = Color.SlateGray;
			panel2.BackColor = Color.SlateGray;
		}

		// ExpandMenu
		private void InitializeExpandMenu()
        {
            b1.Tag = 0;
            b2.Tag = 0;
            b3.Tag = 0;

            b2.Width = b1.Width;
            b3.Width = b1.Width;

            b2.Height = b1.Height;
            b3.Height = b1.Height;

            p1.Width = b1.Width;
            p2.Width = b2.Width;
            p3.Width = b3.Width;

            b2.Top = b1.Bottom + OFFSET;
            b3.Top = b2.Bottom + OFFSET;

            CheckExpandMenuSpace();
        }
        private void CheckExpandMenuSpace()
        {
            if (((int)b1.Tag + (int)b2.Tag + (int)b3.Tag) >= 2)
            {
                pSize.Visible = false;
            }
            else
                pSize.Visible = true;
        }
        private void ExpandMenu1_Click(object sender, EventArgs e)
        {
            if ((int)b1.Tag == 0)
            {
                // expand
                b1.Image = IMG_COLLAPSE;
                p1.Top = b1.Bottom;
                p1.Visible = true;

                b2.Top = p1.Bottom + OFFSET;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + OFFSET;
                else
                    b3.Top = p2.Bottom + OFFSET;

                p3.Top = b3.Bottom;

                b1.Tag = 1;
            }
            else
            {
                // hide
                b1.Image = IMG_EXPAND;
                p1.Visible = false;

                b2.Top = b1.Bottom + OFFSET;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + OFFSET;
                else
                    b3.Top = p2.Bottom + OFFSET;

                p3.Top = b3.Bottom;

                b1.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
        private void ExpandMenu2_Click(object sender, EventArgs e)
        {
            if ((int)b2.Tag == 0)
            {
                // expand
                b2.Image = IMG_COLLAPSE;
                p2.Top = b2.Bottom;
                p2.Visible = true;

                b3.Top = p2.Bottom + OFFSET;
                p3.Top = b3.Bottom;

                b2.Tag = 1;
            }
            else
            {
                // hide
                b2.Image = IMG_EXPAND;
                p2.Visible = false;

                b3.Top = b2.Bottom + OFFSET;
                p3.Top = b3.Bottom;

                b2.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
        private void ExpandMenu3_Click(object sender, EventArgs e)
        {
            if ((int)b3.Tag == 0)
            {
                // expand
                b3.Image = IMG_COLLAPSE;
                p3.Top = b3.Bottom;
                p3.Visible = true;

                b3.Tag = 1;
            }
            else
            {
                // hide
                b3.Image = IMG_EXPAND;
                p3.Visible = false;

                b3.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
	}
}
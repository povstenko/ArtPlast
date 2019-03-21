using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class PageOrder : UserControl
    {
        const int OFFSET = 10;
        Image IMG_COLLAPSE = global::StekloMaster.Properties.Resources.collapse_arrow_24;
        Image IMG_EXPAND = global::StekloMaster.Properties.Resources.expand_arrow_24;
    
        public PageOrder()
        {
            InitializeComponent();
            InitializeExpandMenu();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Category"; //текст в шапке
            //column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            //column2.Width = 150;
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Color";
            //column3.Width = 93;
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
            //column6.Width = 150;
            column6.Name = "name";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Color";
            //column7.Width = 93;
            column7.Name = "color";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Cost";
            column8.Width = 80; //ширина колонки
            column8.Name = "Cost";
            column8.CellTemplate = new DataGridViewTextBoxCell();

            //dgwFrame.Columns.Add(column5);
            dgwFrame.Columns.Add(column6);
            dgwFrame.Columns.Add(column7);
            dgwFrame.Columns.Add(column8);
            dgwFrame.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки






            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Name";
            //column10.Width = 150;
            column10.Name = "name";
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Color";
            //column11.Width = 93;
            column11.Name = "color";
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Cost";
            column12.Width = 80; //ширина колонки
            column12.Name = "Cost";
            column12.CellTemplate = new DataGridViewTextBoxCell();

            //dgwGlass.Columns.Add(column9);
            dgwGlass.Columns.Add(column10);
            dgwGlass.Columns.Add(column11);
            dgwGlass.Columns.Add(column12);
            dgwGlass.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки





            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Category"; //текст в шапке
            column13.Width = 70; //ширина колонки
            column13.ReadOnly = true; //значение в этой колонке нельзя править
            column13.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column13.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column13.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Name";
            //column14.Width = 150;
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

        private void CheckExpandMenuSpace()
        {
            if (((int)b1.Tag + (int)b2.Tag + (int)b3.Tag) >= 2)
            {
                pSize.Visible = false;
            }
            else
                pSize.Visible = true;
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

            //b1.Top = OFFSET;
            b2.Top = b1.Bottom + OFFSET;
            b3.Top = b2.Bottom + OFFSET;

            CheckExpandMenuSpace();
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

namespace StekloMaster
{
    partial class PageMaterials
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwMaterials = new System.Windows.Forms.DataGridView();
            this.cmbxSearchIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxOrder = new System.Windows.Forms.ComboBox();
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMaterials
            // 
            this.dgwMaterials.AllowUserToAddRows = false;
            this.dgwMaterials.AllowUserToDeleteRows = false;
            this.dgwMaterials.AllowUserToResizeColumns = false;
            this.dgwMaterials.AllowUserToResizeRows = false;
            this.dgwMaterials.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwMaterials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMaterials.Location = new System.Drawing.Point(22, 20);
            this.dgwMaterials.MultiSelect = false;
            this.dgwMaterials.Name = "dgwMaterials";
            this.dgwMaterials.ReadOnly = true;
            this.dgwMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMaterials.Size = new System.Drawing.Size(534, 488);
            this.dgwMaterials.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgwMaterials, "Materials");
            this.dgwMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMaterials_CellContentClick);
            // 
            // cmbxSearchIn
            // 
            this.cmbxSearchIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbxSearchIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxSearchIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSearchIn.FormattingEnabled = true;
            this.cmbxSearchIn.Items.AddRange(new object[] {
            "Category",
            "Name",
            "Color",
            "CostPerMeter"});
            this.cmbxSearchIn.Location = new System.Drawing.Point(574, 90);
            this.cmbxSearchIn.Name = "cmbxSearchIn";
            this.cmbxSearchIn.Size = new System.Drawing.Size(200, 21);
            this.cmbxSearchIn.TabIndex = 1;
            this.cmbxSearchIn.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(571, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.SlateGray;
            this.p1.Location = new System.Drawing.Point(574, 58);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(166, 1);
            this.p1.TabIndex = 9;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearch.Location = new System.Drawing.Point(574, 42);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(166, 16);
            this.tbxSearch.TabIndex = 8;
            this.tbxSearch.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(571, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(571, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Order by:";
            // 
            // cmbxOrder
            // 
            this.cmbxOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbxOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxOrder.FormattingEnabled = true;
            this.cmbxOrder.Items.AddRange(new object[] {
            "Category",
            "Name",
            "Color",
            "CostPerMeter"});
            this.cmbxOrder.Location = new System.Drawing.Point(574, 141);
            this.cmbxOrder.Name = "cmbxOrder";
            this.cmbxOrder.Size = new System.Drawing.Size(200, 21);
            this.cmbxOrder.TabIndex = 13;
            this.cmbxOrder.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbxInfo.Location = new System.Drawing.Point(574, 240);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.Size = new System.Drawing.Size(200, 268);
            this.rtbxInfo.TabIndex = 15;
            this.rtbxInfo.Text = "";
            this.toolTip1.SetToolTip(this.rtbxInfo, "Description");
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesc.FlatAppearance.BorderSize = 0;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDesc.ForeColor = System.Drawing.Color.Black;
            this.btnDesc.Image = global::StekloMaster.Properties.Resources.DESCB24;
            this.btnDesc.Location = new System.Drawing.Point(616, 178);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(36, 36);
            this.btnDesc.TabIndex = 17;
            this.btnDesc.Tag = "DESC";
            this.toolTip1.SetToolTip(this.btnDesc, "Descending");
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsc.FlatAppearance.BorderSize = 0;
            this.btnAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAsc.ForeColor = System.Drawing.Color.White;
            this.btnAsc.Image = global::StekloMaster.Properties.Resources.ASCW24;
            this.btnAsc.Location = new System.Drawing.Point(574, 178);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(36, 36);
            this.btnAsc.TabIndex = 16;
            this.btnAsc.Tag = "ASC";
            this.toolTip1.SetToolTip(this.btnAsc, "Ascending");
            this.btnAsc.UseVisualStyleBackColor = false;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::StekloMaster.Properties.Resources.icons8_search_24;
            this.btnSearch.Location = new System.Drawing.Point(746, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PageMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.rtbxInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.cmbxSearchIn);
            this.Controls.Add(this.dgwMaterials);
            this.Name = "PageMaterials";
            this.Size = new System.Drawing.Size(788, 528);
            this.Load += new System.EventHandler(this.PageMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMaterials;
        private System.Windows.Forms.ComboBox cmbxSearchIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxOrder;
        private System.Windows.Forms.RichTextBox rtbxInfo;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

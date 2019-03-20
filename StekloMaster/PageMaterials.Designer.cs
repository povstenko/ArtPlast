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
            this.dgwMaterials = new System.Windows.Forms.DataGridView();
            this.cmbxSearchIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxOrder = new System.Windows.Forms.ComboBox();
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(746, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "S";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // 
            // PageMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}

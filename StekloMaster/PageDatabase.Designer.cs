namespace StekloMaster
{
    partial class PageDatabase
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
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxTables = new System.Windows.Forms.ComboBox();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMaterials
            // 
            this.dgwMaterials.AllowUserToResizeColumns = false;
            this.dgwMaterials.AllowUserToResizeRows = false;
            this.dgwMaterials.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMaterials.Location = new System.Drawing.Point(3, 35);
            this.dgwMaterials.MultiSelect = false;
            this.dgwMaterials.Name = "dgwMaterials";
            this.dgwMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwMaterials.Size = new System.Drawing.Size(785, 492);
            this.dgwMaterials.TabIndex = 1;
            this.dgwMaterials.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgwMaterials_RowsAdded);
            // 
            // tbxCommand
            // 
            this.tbxCommand.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbxCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCommand.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCommand.ForeColor = System.Drawing.Color.White;
            this.tbxCommand.Location = new System.Drawing.Point(233, 8);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(410, 18);
            this.tbxCommand.TabIndex = 2;
            this.tbxCommand.Text = "ORDER BY [Id] ASC";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_search_24;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Location = new System.Drawing.Point(649, 6);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(24, 24);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT * FROM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbxTables
            // 
            this.cmbxTables.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmbxTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxTables.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.cmbxTables.ForeColor = System.Drawing.Color.White;
            this.cmbxTables.FormattingEnabled = true;
            this.cmbxTables.Items.AddRange(new object[] {
            "[Materials]",
            "[User]"});
            this.cmbxTables.Location = new System.Drawing.Point(118, 4);
            this.cmbxTables.Name = "cmbxTables";
            this.cmbxTables.Size = new System.Drawing.Size(109, 26);
            this.cmbxTables.TabIndex = 5;
            this.cmbxTables.SelectedIndexChanged += new System.EventHandler(this.cmbxTables_SelectedIndexChanged);
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToResizeColumns = false;
            this.dgwUsers.AllowUserToResizeRows = false;
            this.dgwUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(3, 35);
            this.dgwUsers.MultiSelect = false;
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwUsers.Size = new System.Drawing.Size(785, 492);
            this.dgwUsers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 8);
            this.label2.TabIndex = 7;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatabase.ForeColor = System.Drawing.Color.White;
            this.lblDatabase.Location = new System.Drawing.Point(721, 13);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(67, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "WindowShop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_database_24;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(701, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PageDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbxTables);
            this.Controls.Add(this.dgwMaterials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.dgwUsers);
            this.Controls.Add(this.label2);
            this.Name = "PageDatabase";
            this.Size = new System.Drawing.Size(791, 530);
            this.Load += new System.EventHandler(this.PageDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMaterials;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxTables;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

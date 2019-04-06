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
            this.components = new System.ComponentModel.Container();
            this.dgwMaterials = new System.Windows.Forms.DataGridView();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxTables = new System.Windows.Forms.ComboBox();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMaterials
            // 
            this.dgwMaterials.AllowUserToAddRows = false;
            this.dgwMaterials.AllowUserToDeleteRows = false;
            this.dgwMaterials.AllowUserToResizeColumns = false;
            this.dgwMaterials.AllowUserToResizeRows = false;
            this.dgwMaterials.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMaterials.Location = new System.Drawing.Point(3, 35);
            this.dgwMaterials.MultiSelect = false;
            this.dgwMaterials.Name = "dgwMaterials";
            this.dgwMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMaterials.Size = new System.Drawing.Size(785, 492);
            this.dgwMaterials.TabIndex = 1;
            // 
            // tbxCommand
            // 
            this.tbxCommand.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbxCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCommand.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCommand.ForeColor = System.Drawing.Color.White;
            this.tbxCommand.Location = new System.Drawing.Point(237, 8);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(410, 18);
            this.tbxCommand.TabIndex = 2;
            this.tbxCommand.Text = "ORDER BY [Id] ASC";
            this.toolTip1.SetToolTip(this.tbxCommand, "SQL selection query string");
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
            this.toolTip1.SetToolTip(this.label1, "SQL selection query string");
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
            this.cmbxTables.Size = new System.Drawing.Size(113, 26);
            this.cmbxTables.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmbxTables, "SQL selection query string");
            this.cmbxTables.SelectedIndexChanged += new System.EventHandler(this.cmbxTables_SelectedIndexChanged);
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.AllowUserToResizeColumns = false;
            this.dgwUsers.AllowUserToResizeRows = false;
            this.dgwUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(3, 35);
            this.dgwUsers.MultiSelect = false;
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsers.Size = new System.Drawing.Size(785, 492);
            this.dgwUsers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 26);
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
            this.toolTip1.SetToolTip(this.lblDatabase, "Database");
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_subtract_32;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(748, 483);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnRemove, "Remove current row from table");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_plus_math_32;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(712, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnAdd, "Add new row in table");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.toolTip1.SetToolTip(this.pictureBox1, "Database");
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_play_24;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Location = new System.Drawing.Point(652, 6);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(24, 24);
            this.btnExecute.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnExecute, "Execute query");
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // PageDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbxTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwMaterials);
            this.Controls.Add(this.dgwUsers);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

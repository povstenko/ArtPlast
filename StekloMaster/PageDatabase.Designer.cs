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
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            this.dgwMaterials = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbxInfo.Location = new System.Drawing.Point(566, 301);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.Size = new System.Drawing.Size(200, 208);
            this.rtbxInfo.TabIndex = 27;
            this.rtbxInfo.Text = "";
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
            this.dgwMaterials.Location = new System.Drawing.Point(14, 21);
            this.dgwMaterials.MultiSelect = false;
            this.dgwMaterials.Name = "dgwMaterials";
            this.dgwMaterials.ReadOnly = true;
            this.dgwMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMaterials.Size = new System.Drawing.Size(534, 488);
            this.dgwMaterials.TabIndex = 18;
            // 
            // PageDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtbxInfo);
            this.Controls.Add(this.dgwMaterials);
            this.Name = "PageDatabase";
            this.Size = new System.Drawing.Size(788, 528);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbxInfo;
        private System.Windows.Forms.DataGridView dgwMaterials;
    }
}

namespace StekloMaster
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pageOrder = new StekloMaster.PageOrder();
            this.pageHome = new StekloMaster.PageHome();
            this.pageMaterials = new StekloMaster.PageMaterials();
            this.pageDatabase = new StekloMaster.PageDatabase();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.pMenu.Controls.Add(this.pSide);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Controls.Add(this.button7);
            this.pMenu.Controls.Add(this.button4);
            this.pMenu.Controls.Add(this.button3);
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(204, 554);
            this.pMenu.TabIndex = 6;
            this.pMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            this.pMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseMove);
            this.pMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseUp);
            // 
            // pSide
            // 
            this.pSide.BackColor = System.Drawing.Color.DodgerBlue;
            this.pSide.Location = new System.Drawing.Point(0, 65);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(10, 54);
            this.pSide.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StekloMaster.Properties.Resources.artplast;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::StekloMaster.Properties.Resources.icons8_online_support_24;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(10, 500);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 54);
            this.button7.TabIndex = 6;
            this.button7.Text = "       Open Support";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::StekloMaster.Properties.Resources.icons8_database_administrator_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "       Edit Database";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::StekloMaster.Properties.Resources.icons8_product_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "       Materials";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::StekloMaster.Properties.Resources.icons8_open_window_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 54);
            this.button2.TabIndex = 11;
            this.button2.Text = "       Buy Window";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StekloMaster.Properties.Resources.icons8_home_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "       Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.SystemColors.Menu;
            this.pTop.Controls.Add(this.btnExit);
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(995, 24);
            this.pTop.TabIndex = 7;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            this.pTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseMove);
            this.pTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::StekloMaster.Properties.Resources.icons8_delete_sign_24px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(949, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 24);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // pageOrder
            // 
            this.pageOrder.BackColor = System.Drawing.Color.White;
            this.pageOrder.Location = new System.Drawing.Point(204, 24);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Size = new System.Drawing.Size(788, 528);
            this.pageOrder.TabIndex = 9;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.White;
            this.pageHome.Location = new System.Drawing.Point(204, 24);
            this.pageHome.Name = "pageHome";
            this.pageHome.Size = new System.Drawing.Size(788, 528);
            this.pageHome.TabIndex = 10;
            // 
            // pageMaterials
            // 
            this.pageMaterials.BackColor = System.Drawing.Color.White;
            this.pageMaterials.Location = new System.Drawing.Point(204, 24);
            this.pageMaterials.Name = "pageMaterials";
            this.pageMaterials.Size = new System.Drawing.Size(788, 528);
            this.pageMaterials.TabIndex = 10;
            // 
            // pageDatabase
            // 
            this.pageDatabase.Location = new System.Drawing.Point(204, 24);
            this.pageDatabase.Name = "pageDatabase";
            this.pageDatabase.TabIndex = 11;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 554);
            this.Controls.Add(this.pageHome);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pageOrder);
            this.Controls.Add(this.pageMaterials);
            this.Controls.Add(this.pageDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PageHome pageHome;
        private PageOrder pageOrder;
        private PageMaterials pageMaterials;
        private PageDatabase pageDatabase;
    }
}


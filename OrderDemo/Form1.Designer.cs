namespace OrderDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Menu;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(267, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "0";
            this.btn1.Text = "Frame";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.Location = new System.Drawing.Point(12, 147);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(267, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "0";
            this.btn2.Text = "Glass";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Menu;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.Location = new System.Drawing.Point(12, 282);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(267, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "0";
            this.btn3.Text = "Furniture";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p1.Location = new System.Drawing.Point(12, 41);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(267, 100);
            this.p1.TabIndex = 3;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p2.Location = new System.Drawing.Point(12, 176);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(267, 100);
            this.p2.TabIndex = 4;
            this.p2.Visible = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p3.Location = new System.Drawing.Point(12, 311);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(267, 100);
            this.p3.TabIndex = 5;
            this.p3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 509);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
    }
}


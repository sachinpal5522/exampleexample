namespace shopmanagement
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Editcategory = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.comboboxpanel = new System.Windows.Forms.Panel();
            this.categorycombo = new MetroFramework.Controls.MetroComboBox();
            this.combohoverpanel = new System.Windows.Forms.Panel();
            this.prodnamepanel = new System.Windows.Forms.Panel();
            this.prodnametxt = new System.Windows.Forms.TextBox();
            this.txtpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.comboboxpanel.SuspendLayout();
            this.prodnamepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Editcategory);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Controls.Add(this.comboboxpanel);
            this.panel2.Controls.Add(this.prodnamepanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 418);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 418);
            this.panel1.TabIndex = 6;
            // 
            // Editcategory
            // 
            this.Editcategory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Editcategory.BackgroundImage = global::shopmanagement.Properties.Resources.edit;
            this.Editcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editcategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Editcategory.FlatAppearance.BorderSize = 0;
            this.Editcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editcategory.Location = new System.Drawing.Point(216, 80);
            this.Editcategory.Name = "Editcategory";
            this.Editcategory.Size = new System.Drawing.Size(30, 30);
            this.Editcategory.TabIndex = 5;
            this.Editcategory.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Location = new System.Drawing.Point(21, 279);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(200, 40);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deletebtn.Location = new System.Drawing.Point(21, 223);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(200, 40);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete ";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addbtn.Location = new System.Drawing.Point(21, 163);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(200, 40);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // comboboxpanel
            // 
            this.comboboxpanel.Controls.Add(this.categorycombo);
            this.comboboxpanel.Controls.Add(this.combohoverpanel);
            this.comboboxpanel.Location = new System.Drawing.Point(10, 80);
            this.comboboxpanel.Name = "comboboxpanel";
            this.comboboxpanel.Size = new System.Drawing.Size(200, 31);
            this.comboboxpanel.TabIndex = 1;
            // 
            // categorycombo
            // 
            this.categorycombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorycombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorycombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorycombo.ForeColor = System.Drawing.Color.Honeydew;
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.ItemHeight = 23;
            this.categorycombo.Location = new System.Drawing.Point(0, 0);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(200, 29);
            this.categorycombo.Style = MetroFramework.MetroColorStyle.Green;
            this.categorycombo.TabIndex = 1;
            this.categorycombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.categorycombo.UseCustomBackColor = true;
            this.categorycombo.UseCustomForeColor = true;
            this.categorycombo.UseSelectable = true;
            this.categorycombo.UseStyleColors = true;
            this.categorycombo.Enter += new System.EventHandler(this.categorycombo_Enter);
            this.categorycombo.Leave += new System.EventHandler(this.categorycombo_Leave);
            // 
            // combohoverpanel
            // 
            this.combohoverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.combohoverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combohoverpanel.Location = new System.Drawing.Point(0, 29);
            this.combohoverpanel.Name = "combohoverpanel";
            this.combohoverpanel.Size = new System.Drawing.Size(200, 2);
            this.combohoverpanel.TabIndex = 0;
            // 
            // prodnamepanel
            // 
            this.prodnamepanel.Controls.Add(this.prodnametxt);
            this.prodnamepanel.Controls.Add(this.txtpanel);
            this.prodnamepanel.Location = new System.Drawing.Point(10, 30);
            this.prodnamepanel.Name = "prodnamepanel";
            this.prodnamepanel.Size = new System.Drawing.Size(200, 31);
            this.prodnamepanel.TabIndex = 0;
            // 
            // prodnametxt
            // 
            this.prodnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodnametxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodnametxt.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnametxt.ForeColor = System.Drawing.SystemColors.Window;
            this.prodnametxt.Location = new System.Drawing.Point(0, 0);
            this.prodnametxt.Name = "prodnametxt";
            this.prodnametxt.Size = new System.Drawing.Size(200, 27);
            this.prodnametxt.TabIndex = 1;
            this.prodnametxt.Text = "Enter product name";
            this.prodnametxt.Enter += new System.EventHandler(this.prodnametxt_Enter);
            this.prodnametxt.Leave += new System.EventHandler(this.prodnametxt_Leave);
            // 
            // txtpanel
            // 
            this.txtpanel.BackColor = System.Drawing.Color.Honeydew;
            this.txtpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtpanel.Location = new System.Drawing.Point(0, 29);
            this.txtpanel.Name = "txtpanel";
            this.txtpanel.Size = new System.Drawing.Size(200, 2);
            this.txtpanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 418);
            this.panel3.TabIndex = 2;
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.Size = new System.Drawing.Size(615, 418);
            this.ProductGridView.TabIndex = 0;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(870, 418);
            this.panel2.ResumeLayout(false);
            this.comboboxpanel.ResumeLayout(false);
            this.prodnamepanel.ResumeLayout(false);
            this.prodnamepanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Panel prodnamepanel;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Panel txtpanel;
        private System.Windows.Forms.TextBox prodnametxt;
        private System.Windows.Forms.Panel combohoverpanel;
        private System.Windows.Forms.Panel comboboxpanel;
        private MetroFramework.Controls.MetroComboBox categorycombo;
        private System.Windows.Forms.Button Editcategory;
        private System.Windows.Forms.Panel panel1;
    }
}

namespace shopmanagement
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnbtn = new System.Windows.Forms.Button();
            this.soldbtn = new System.Windows.Forms.Button();
            this.Pricepanel = new System.Windows.Forms.Panel();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.priceoverpanel = new System.Windows.Forms.Panel();
            this.qtytxtpanel = new System.Windows.Forms.Panel();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.qtyoverpanel = new System.Windows.Forms.Panel();
            this.categorycombopanel = new System.Windows.Forms.Panel();
            this.categorycombo = new MetroFramework.Controls.MetroComboBox();
            this.catoverpanel = new System.Windows.Forms.Panel();
            this.procombopanel = new System.Windows.Forms.Panel();
            this.productcombo = new MetroFramework.Controls.MetroComboBox();
            this.prooverpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Pricepanel.SuspendLayout();
            this.qtytxtpanel.SuspendLayout();
            this.categorycombopanel.SuspendLayout();
            this.procombopanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.returnbtn);
            this.panel1.Controls.Add(this.soldbtn);
            this.panel1.Controls.Add(this.Pricepanel);
            this.panel1.Controls.Add(this.qtytxtpanel);
            this.panel1.Controls.Add(this.categorycombopanel);
            this.panel1.Controls.Add(this.procombopanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 418);
            this.panel1.TabIndex = 0;
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.returnbtn.FlatAppearance.BorderSize = 0;
            this.returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.returnbtn.Location = new System.Drawing.Point(27, 247);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(200, 40);
            this.returnbtn.TabIndex = 7;
            this.returnbtn.Text = "RETURN ORDER";
            this.returnbtn.UseVisualStyleBackColor = false;
            // 
            // soldbtn
            // 
            this.soldbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.soldbtn.FlatAppearance.BorderSize = 0;
            this.soldbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.soldbtn.Location = new System.Drawing.Point(27, 189);
            this.soldbtn.Name = "soldbtn";
            this.soldbtn.Size = new System.Drawing.Size(200, 40);
            this.soldbtn.TabIndex = 6;
            this.soldbtn.Text = "PLACE ORDER";
            this.soldbtn.UseVisualStyleBackColor = false;
            // 
            // Pricepanel
            // 
            this.Pricepanel.Controls.Add(this.pricetxt);
            this.Pricepanel.Controls.Add(this.priceoverpanel);
            this.Pricepanel.Location = new System.Drawing.Point(80, 117);
            this.Pricepanel.Name = "Pricepanel";
            this.Pricepanel.Size = new System.Drawing.Size(145, 31);
            this.Pricepanel.TabIndex = 5;
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricetxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricetxt.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.ForeColor = System.Drawing.SystemColors.Window;
            this.pricetxt.Location = new System.Drawing.Point(0, 0);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(145, 27);
            this.pricetxt.TabIndex = 1;
            this.pricetxt.Text = "Price";
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricetxt.Enter += new System.EventHandler(this.pricetxt_Enter);
            this.pricetxt.Leave += new System.EventHandler(this.pricetxt_Leave);
            // 
            // priceoverpanel
            // 
            this.priceoverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.priceoverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.priceoverpanel.Location = new System.Drawing.Point(0, 29);
            this.priceoverpanel.Name = "priceoverpanel";
            this.priceoverpanel.Size = new System.Drawing.Size(145, 2);
            this.priceoverpanel.TabIndex = 0;
            // 
            // qtytxtpanel
            // 
            this.qtytxtpanel.Controls.Add(this.qtytxt);
            this.qtytxtpanel.Controls.Add(this.qtyoverpanel);
            this.qtytxtpanel.Location = new System.Drawing.Point(25, 117);
            this.qtytxtpanel.Name = "qtytxtpanel";
            this.qtytxtpanel.Size = new System.Drawing.Size(41, 31);
            this.qtytxtpanel.TabIndex = 4;
            // 
            // qtytxt
            // 
            this.qtytxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qtytxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qtytxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qtytxt.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytxt.ForeColor = System.Drawing.SystemColors.Window;
            this.qtytxt.Location = new System.Drawing.Point(0, 0);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(41, 27);
            this.qtytxt.TabIndex = 1;
            this.qtytxt.Text = "Qty";
            this.qtytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtytxt.Enter += new System.EventHandler(this.qtytxt_Enter);
            this.qtytxt.Leave += new System.EventHandler(this.qtytxt_Leave);
            // 
            // qtyoverpanel
            // 
            this.qtyoverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.qtyoverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.qtyoverpanel.Location = new System.Drawing.Point(0, 29);
            this.qtyoverpanel.Name = "qtyoverpanel";
            this.qtyoverpanel.Size = new System.Drawing.Size(41, 2);
            this.qtyoverpanel.TabIndex = 0;
            // 
            // categorycombopanel
            // 
            this.categorycombopanel.Controls.Add(this.categorycombo);
            this.categorycombopanel.Controls.Add(this.catoverpanel);
            this.categorycombopanel.Location = new System.Drawing.Point(25, 20);
            this.categorycombopanel.Name = "categorycombopanel";
            this.categorycombopanel.Size = new System.Drawing.Size(200, 31);
            this.categorycombopanel.TabIndex = 3;
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
            // catoverpanel
            // 
            this.catoverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.catoverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.catoverpanel.Location = new System.Drawing.Point(0, 29);
            this.catoverpanel.Name = "catoverpanel";
            this.catoverpanel.Size = new System.Drawing.Size(200, 2);
            this.catoverpanel.TabIndex = 0;
            // 
            // procombopanel
            // 
            this.procombopanel.Controls.Add(this.productcombo);
            this.procombopanel.Controls.Add(this.prooverpanel);
            this.procombopanel.Location = new System.Drawing.Point(25, 70);
            this.procombopanel.Name = "procombopanel";
            this.procombopanel.Size = new System.Drawing.Size(200, 31);
            this.procombopanel.TabIndex = 2;
            // 
            // productcombo
            // 
            this.productcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productcombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productcombo.ForeColor = System.Drawing.Color.Honeydew;
            this.productcombo.FormattingEnabled = true;
            this.productcombo.ItemHeight = 23;
            this.productcombo.Location = new System.Drawing.Point(0, 0);
            this.productcombo.Name = "productcombo";
            this.productcombo.Size = new System.Drawing.Size(200, 29);
            this.productcombo.Style = MetroFramework.MetroColorStyle.Green;
            this.productcombo.TabIndex = 1;
            this.productcombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.productcombo.UseCustomBackColor = true;
            this.productcombo.UseCustomForeColor = true;
            this.productcombo.UseSelectable = true;
            this.productcombo.UseStyleColors = true;
            this.productcombo.Enter += new System.EventHandler(this.productcombo_Enter);
            this.productcombo.Leave += new System.EventHandler(this.productcombo_Leave);
            // 
            // prooverpanel
            // 
            this.prooverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.prooverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prooverpanel.Location = new System.Drawing.Point(0, 29);
            this.prooverpanel.Name = "prooverpanel";
            this.prooverpanel.Size = new System.Drawing.Size(200, 2);
            this.prooverpanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 418);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrderDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 418);
            this.panel2.TabIndex = 1;
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.AllowUserToDeleteRows = false;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(615, 418);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(870, 418);
            this.panel1.ResumeLayout(false);
            this.Pricepanel.ResumeLayout(false);
            this.Pricepanel.PerformLayout();
            this.qtytxtpanel.ResumeLayout(false);
            this.qtytxtpanel.PerformLayout();
            this.categorycombopanel.ResumeLayout(false);
            this.procombopanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel procombopanel;
        private MetroFramework.Controls.MetroComboBox productcombo;
        private System.Windows.Forms.Panel prooverpanel;
        private System.Windows.Forms.Panel categorycombopanel;
        private MetroFramework.Controls.MetroComboBox categorycombo;
        private System.Windows.Forms.Panel catoverpanel;
        private System.Windows.Forms.Panel qtytxtpanel;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.Panel qtyoverpanel;
        private System.Windows.Forms.Panel Pricepanel;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Panel priceoverpanel;
        private System.Windows.Forms.Button soldbtn;
        private System.Windows.Forms.Button returnbtn;
        private System.Windows.Forms.DataGridView OrderDataGridView;
    }
}

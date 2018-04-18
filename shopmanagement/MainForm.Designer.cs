namespace shopmanagement
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockbtn = new System.Windows.Forms.Button();
            this.Administrator = new System.Windows.Forms.Button();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.ActivePane = new System.Windows.Forms.Panel();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlelable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPane = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopTitle = new System.Windows.Forms.Label();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.product = new shopmanagement.Product();
            this.dashboard = new shopmanagement.Dashboard();
            this.Stockcontrol = new shopmanagement.Stock();
            this.administratorcontent = new shopmanagement.administrator();
            this.order = new shopmanagement.Order();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.stockbtn);
            this.panel1.Controls.Add(this.Administrator);
            this.panel1.Controls.Add(this.Orderbtn);
            this.panel1.Controls.Add(this.Productbtn);
            this.panel1.Controls.Add(this.ActivePane);
            this.panel1.Controls.Add(this.DashboardBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 500);
            this.panel1.TabIndex = 0;
            // 
            // stockbtn
            // 
            this.stockbtn.FlatAppearance.BorderSize = 0;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stockbtn.Location = new System.Drawing.Point(5, 150);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(125, 30);
            this.stockbtn.TabIndex = 7;
            this.stockbtn.Text = "Stock";
            this.stockbtn.UseVisualStyleBackColor = true;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            // 
            // Administrator
            // 
            this.Administrator.FlatAppearance.BorderSize = 0;
            this.Administrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Administrator.Location = new System.Drawing.Point(5, 470);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(125, 30);
            this.Administrator.TabIndex = 6;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Orderbtn
            // 
            this.Orderbtn.FlatAppearance.BorderSize = 0;
            this.Orderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orderbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Orderbtn.Location = new System.Drawing.Point(5, 250);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(125, 30);
            this.Orderbtn.TabIndex = 4;
            this.Orderbtn.Text = "Order";
            this.Orderbtn.UseVisualStyleBackColor = true;
            this.Orderbtn.Click += new System.EventHandler(this.Orderbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.FlatAppearance.BorderSize = 0;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Productbtn.Location = new System.Drawing.Point(5, 200);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(125, 30);
            this.Productbtn.TabIndex = 3;
            this.Productbtn.Text = "Product";
            this.Productbtn.UseVisualStyleBackColor = true;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // ActivePane
            // 
            this.ActivePane.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ActivePane.Location = new System.Drawing.Point(0, 100);
            this.ActivePane.Name = "ActivePane";
            this.ActivePane.Size = new System.Drawing.Size(5, 30);
            this.ActivePane.TabIndex = 2;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardBtn.Location = new System.Drawing.Point(5, 100);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(125, 30);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.titlelable);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 82);
            this.panel2.TabIndex = 0;
            // 
            // titlelable
            // 
            this.titlelable.AutoSize = true;
            this.titlelable.Font = new System.Drawing.Font("Ed Wood Movies", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.ForeColor = System.Drawing.Color.MintCream;
            this.titlelable.Location = new System.Drawing.Point(12, 55);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(101, 18);
            this.titlelable.TabIndex = 9;
            this.titlelable.Text = "Stock Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shopmanagement.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(40, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopPane
            // 
            this.TopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPane.Controls.Add(this.panel4);
            this.TopPane.Controls.Add(this.panel3);
            this.TopPane.Controls.Add(this.TopTitle);
            this.TopPane.Controls.Add(this.minimizebtn);
            this.TopPane.Controls.Add(this.closebtn);
            this.TopPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPane.Location = new System.Drawing.Point(130, 0);
            this.TopPane.Name = "TopPane";
            this.TopPane.Size = new System.Drawing.Size(870, 82);
            this.TopPane.TabIndex = 1;
            this.TopPane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseDown);
            this.TopPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseMove);
            this.TopPane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 77);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 5);
            this.panel3.TabIndex = 11;
            // 
            // TopTitle
            // 
            this.TopTitle.AutoSize = true;
            this.TopTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.TopTitle.Location = new System.Drawing.Point(348, 7);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(183, 45);
            this.TopTitle.TabIndex = 10;
            this.TopTitle.Text = "Dashboard";
            this.TopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackgroundImage = global::shopmanagement.Properties.Resources.minimize;
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Location = new System.Drawing.Point(823, 8);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(20, 20);
            this.minimizebtn.TabIndex = 9;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::shopmanagement.Properties.Resources.close;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Location = new System.Drawing.Point(844, 8);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 20);
            this.closebtn.TabIndex = 8;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product.Location = new System.Drawing.Point(130, 82);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(870, 418);
            this.product.TabIndex = 3;
            this.product.Load += new System.EventHandler(this.product_Load);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(1000, 500);
            this.dashboard.TabIndex = 2;
            // 
            // Stockcontrol
            // 
            this.Stockcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stockcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stockcontrol.Location = new System.Drawing.Point(0, 0);
            this.Stockcontrol.Name = "Stockcontrol";
            this.Stockcontrol.Size = new System.Drawing.Size(1000, 500);
            this.Stockcontrol.TabIndex = 6;
            this.Stockcontrol.Load += new System.EventHandler(this.Stockcontrol_Load);
            // 
            // administratorcontent
            // 
            this.administratorcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.administratorcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administratorcontent.Location = new System.Drawing.Point(0, 0);
            this.administratorcontent.Name = "administratorcontent";
            this.administratorcontent.Size = new System.Drawing.Size(1000, 500);
            this.administratorcontent.TabIndex = 5;
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order.Location = new System.Drawing.Point(0, 0);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(1000, 500);
            this.order.TabIndex = 4;
            this.order.Load += new System.EventHandler(this.order_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.product);
            this.Controls.Add(this.TopPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.Stockcontrol);
            this.Controls.Add(this.administratorcontent);
            this.Controls.Add(this.order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPane.ResumeLayout(false);
            this.TopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopPane;
        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel ActivePane;
        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Orderbtn;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Label TopTitle;
        private System.Windows.Forms.Panel panel3;
        private Product product;
        private Dashboard dashboard;
        private Order order;
        private administrator administratorcontent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button stockbtn;
        private Stock Stockcontrol;
    }
}
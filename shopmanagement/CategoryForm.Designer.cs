namespace shopmanagement
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Top_Pane = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.catepanel = new System.Windows.Forms.Panel();
            this.CatNametext = new System.Windows.Forms.TextBox();
            this.cateoverpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.Top_Pane.SuspendLayout();
            this.panel2.SuspendLayout();
            this.catepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Pane
            // 
            this.Top_Pane.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Top_Pane.Controls.Add(this.closebtn);
            this.Top_Pane.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Pane.Location = new System.Drawing.Point(0, 0);
            this.Top_Pane.Name = "Top_Pane";
            this.Top_Pane.Size = new System.Drawing.Size(599, 22);
            this.Top_Pane.TabIndex = 1;
            this.Top_Pane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseDown);
            this.Top_Pane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseMove);
            this.Top_Pane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPane_MouseUp);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::shopmanagement.Properties.Resources.close;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Location = new System.Drawing.Point(579, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 22);
            this.closebtn.TabIndex = 10;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.catepanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 417);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(2, 415);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 417);
            this.panel1.TabIndex = 10;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deletebtn.Location = new System.Drawing.Point(23, 282);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(160, 40);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Delete Category";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Location = new System.Drawing.Point(23, 210);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(160, 40);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update Category";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Addbtn.Location = new System.Drawing.Point(23, 141);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(160, 40);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add Category";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // catepanel
            // 
            this.catepanel.Controls.Add(this.CatNametext);
            this.catepanel.Controls.Add(this.cateoverpanel);
            this.catepanel.Location = new System.Drawing.Point(18, 58);
            this.catepanel.Name = "catepanel";
            this.catepanel.Size = new System.Drawing.Size(170, 31);
            this.catepanel.TabIndex = 6;
            // 
            // CatNametext
            // 
            this.CatNametext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatNametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatNametext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatNametext.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNametext.ForeColor = System.Drawing.SystemColors.Window;
            this.CatNametext.Location = new System.Drawing.Point(0, 0);
            this.CatNametext.Name = "CatNametext";
            this.CatNametext.Size = new System.Drawing.Size(170, 27);
            this.CatNametext.TabIndex = 1;
            this.CatNametext.Text = "category name";
            this.CatNametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CatNametext.Enter += new System.EventHandler(this.CatNametext_Enter);
            this.CatNametext.Leave += new System.EventHandler(this.CatNametext_Leave);
            // 
            // cateoverpanel
            // 
            this.cateoverpanel.BackColor = System.Drawing.Color.Honeydew;
            this.cateoverpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cateoverpanel.Location = new System.Drawing.Point(0, 29);
            this.cateoverpanel.Name = "cateoverpanel";
            this.cateoverpanel.Size = new System.Drawing.Size(170, 2);
            this.cateoverpanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.CategoryGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(202, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 417);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 2);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(395, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 417);
            this.panel4.TabIndex = 11;
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToAddRows = false;
            this.CategoryGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CategoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryGridView.EnableHeadersVisualStyles = false;
            this.CategoryGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryGridView.Location = new System.Drawing.Point(44, 44);
            this.CategoryGridView.MultiSelect = false;
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.ReadOnly = true;
            this.CategoryGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGridView.Size = new System.Drawing.Size(321, 361);
            this.CategoryGridView.TabIndex = 3;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(599, 439);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Top_Pane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.Top_Pane.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.catepanel.ResumeLayout(false);
            this.catepanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Pane;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel catepanel;
        private System.Windows.Forms.TextBox CatNametext;
        private System.Windows.Forms.Panel cateoverpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shopmanagement
{
    public partial class MainForm : Form
    {
        public Form1 RefToForm1 { get; set; }
        private bool mouseDown;
        private Point lastLocation;  
        public MainForm()
        {
            InitializeComponent();
            dashboard.BringToFront();
            Administrator.Visible = false;
        }

        //**********************************UI design functions******************************************//

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm1.Show();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // for draggin the form around the window
        private void TopPane_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPane_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ActivePane.Top = DashboardBtn.Top;
            TopTitle.Text = "Dashboard";
            dashboard.BringToFront();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            ActivePane.Top = Productbtn.Top;
            TopTitle.Text = "Product";
            product.populatecategory();
            product.BringToFront();
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            ActivePane.Top = Orderbtn.Top;
            TopTitle.Text = "Order";
            order.populatecategory();
            order.BringToFront();
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            ActivePane.Top = Administrator.Top;
            TopTitle.Text = "Administrator";
            administratorcontent.BringToFront();
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            ActivePane.Top = stockbtn.Top;
            TopTitle.Text = "Stock Purchased";
            Stockcontrol.populatecategory();
            Stockcontrol.BringToFront();
           
        }
        //****************************************UI DESIGN ENDS HERE***************************************//

        private void Stockcontrol_Load(object sender, EventArgs e)
        {
            Stockcontrol.con = RefToForm1.cn;
            Stockcontrol.populatecategory();
        }

        private void order_Load(object sender, EventArgs e)
        {
            order.con = RefToForm1.cn;
            order.populatecategory();
        }

        private void product_Load(object sender, EventArgs e)
        {
            product.con = RefToForm1.cn;
            product.populatecategory();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            dashboard.con = RefToForm1.cn;
        }
    }
}

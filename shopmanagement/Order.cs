﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace shopmanagement
{
    public partial class Order : UserControl
    {
        public SqlConnection con;
        public Order()
        {
            InitializeComponent();
        }

        //---------------------------------design function-----------------------------------//
        private void categorycombo_Enter(object sender, EventArgs e)
        {
            catoverpanel.BackColor = Color.MediumSeaGreen;
        }

        private void categorycombo_Leave(object sender, EventArgs e)
        {
            catoverpanel.BackColor = Color.Honeydew;
        }

        private void productcombo_Enter(object sender, EventArgs e)
        {
            prooverpanel.BackColor = Color.MediumSeaGreen;
        }

        private void productcombo_Leave(object sender, EventArgs e)
        {
            prooverpanel.BackColor = Color.Honeydew;
        }

        private void qtytxt_Enter(object sender, EventArgs e)
        {
            qtyoverpanel.BackColor = Color.MediumSeaGreen;
            qtytxt.Clear();
        }

        private void qtytxt_Leave(object sender, EventArgs e)
        {
            qtyoverpanel.BackColor = Color.Honeydew;
        }

        private void pricetxt_Enter(object sender, EventArgs e)
        {
            priceoverpanel.BackColor = Color.MediumSeaGreen;
            pricetxt.Clear();
        }

        private void pricetxt_Leave(object sender, EventArgs e)
        {
            priceoverpanel.BackColor = Color.Honeydew;
        }

        public void populatecategory()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select id,UPPER(CategoryName) Category from Category order by Category");
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            categorycombo.DataSource = dt;
            categorycombo.DisplayMember = dt.Columns[1].ColumnName;
            categorycombo.ValueMember = dt.Columns[0].ColumnName;
            int id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            populateproduct(id);
            populategrid();
        }

        void populategrid()
        {

            SqlCommand cmd = new SqlCommand("select * from StockPurchased", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            OrderDataGridView.DataSource = dt;
        }

        void populateproduct(int id)
        {
            SqlCommand cmd1 = new SqlCommand("select id,UPPER(name)product_name from product where cid =" + id + " order by product_name");
            cmd1.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            productcombo.DataSource = dt1;
            productcombo.DisplayMember = dt1.Columns[1].ColumnName;
            productcombo.ValueMember = dt1.Columns[0].ColumnName;
        }
        //----------------------------------ends here-----------------------------------//

    }
}

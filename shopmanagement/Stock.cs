﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace shopmanagement
{
    public partial class Stock : UserControl
    {

        public Stock()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        private int RowId;
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

        private void categorycombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(categorycombo.SelectedValue);
            populateproduct(id);
        }

        public void populatecategory()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select id,UPPER(CategoryName) Category from Category order by Category");
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0) {
                categorycombo.DataSource = dt;
                categorycombo.DisplayMember = dt.Columns[1].ColumnName;
                categorycombo.ValueMember = dt.Columns[0].ColumnName;
                int id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                populateproduct(id);
            }
            
            populategrid();
        }

        void populategrid()
        {

            SqlCommand cmd = new SqlCommand("select * from StockPurchased", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            da.Fill(dtGrid);
            ProductGridView.DataSource = dtGrid;
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




        private void addbtn_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);

            int pid = Convert.ToInt32(productcombo.SelectedValue);
            int buyprice = Convert.ToInt32(pricetxt.Text);
            int qty = Convert.ToInt32(qtytxt.Text);
            SqlCommand cmd = new SqlCommand("insert into StockPurchased values(" + pid + "," + qty + "," + buyprice + ",'" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("Something went wrong");
            }
            populategrid();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete product " + RowId+" ??", "Alert!!!", MessageBoxButtons.YesNo);

            if (result==DialogResult.Yes) {
                SqlCommand cmd = new SqlCommand("delete from StockPurchased where id=" + RowId, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 0)
                {
                    MessageBox.Show("Something went wrong");
                }
                populategrid();
            }
        }

        private void ProductGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                RowId = Convert.ToInt32(e.Row.Cells[0].FormattedValue.ToString());
            }
        }
    }     
}

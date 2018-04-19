using System;
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
        private int RowId;
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

            SqlCommand cmd = new SqlCommand("select * from Orders", con);
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

        private void categorycombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(categorycombo.SelectedValue);
            populateproduct(id);
        }
        //----------------------------------ends here-----------------------------------//
        private void soldbtn_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(productcombo.SelectedValue);
            int sellprice = Convert.ToInt32(pricetxt.Text);
            int qty = Convert.ToInt32(qtytxt.Text);
            SqlCommand cmd = new SqlCommand("insert into Orders values('"+DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")+"'," + pid + "," + qty + "," + sellprice +")", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("Something went wrong");
            }
            populategrid();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You sure want to return  order " + RowId + " ??", "Alert!!!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from Orders where id=" + RowId, con);
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

        private void OrderDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                RowId = Convert.ToInt32(e.Row.Cells[0].FormattedValue.ToString());
            }
        }
    }
}

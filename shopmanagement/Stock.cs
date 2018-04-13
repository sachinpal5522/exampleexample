using System;
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
        //----------------------------------ends here-----------------------------------//

        public void populate()
        {
           // con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select id,UPPER(CategoryName) from Category");
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            categorycombo.DataSource = dt;
            categorycombo.DisplayMember = dt.Columns[1].ColumnName;
            categorycombo.ValueMember = dt.Columns[0].ColumnName;

            SqlCommand cmd1 = new SqlCommand("select id,UPPER(name) from product");
            cmd1.Connection = con;
            da = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            productcombo.DataSource = dt1;
            productcombo.DisplayMember = dt1.Columns[1].ColumnName;
            productcombo.ValueMember = dt1.Columns[0].ColumnName;
        }

     
        private void addbtn_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            
            int cid =Convert.ToInt32(categorycombo.SelectedValue);
            int pid = Convert.ToInt32(productcombo.SelectedValue);
            int buyprice=Convert.ToInt32(pricetxt.Text);
            int qty=Convert.ToInt32(qtytxt.Text);
            SqlCommand cmd = new SqlCommand( "insert into StockPurchased values("+cid+","+pid+","+qty+","+buyprice+")",con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i!=0)
            {
                MessageBox.Show("Data added Successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

    }
}

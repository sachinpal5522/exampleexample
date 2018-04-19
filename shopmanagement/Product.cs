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
    public partial class Product : UserControl
    {
        public SqlConnection con;
        private int RowId;
        public Product()
        {
            InitializeComponent();
        }

// -------------------------------desgin functions---------------------------------//

        private void prodnametxt_Enter(object sender, EventArgs e)
        {
            txtpanel.BackColor = Color.MediumSeaGreen;
            prodnametxt.Clear();
        }

        private void prodnametxt_Leave(object sender, EventArgs e)
        {
            txtpanel.BackColor = Color.Honeydew;
        }

        private void categorycombo_Enter(object sender, EventArgs e)
        {
            combohoverpanel.BackColor = Color.MediumSeaGreen;
        }

        private void categorycombo_Leave(object sender, EventArgs e)
        {
            combohoverpanel.BackColor = Color.Honeydew;
        }

        public void populatecategory()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select id,UPPER(CategoryName) Category from Category order by Category");
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                categorycombo.DataSource = dt;
                categorycombo.DisplayMember = dt.Columns[1].ColumnName;
                categorycombo.ValueMember = dt.Columns[0].ColumnName;
                int id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            }
            populategrid();
        }

        void populategrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Product", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ProductGridView.DataSource = dt;
        }

        private void Editcategory_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.con = con;
            cat.ShowDialog();

        }
        //--------------------------------------ends here----------------------------------//

        private void addbtn_Click(object sender, EventArgs e)
        {
            string product = prodnametxt.Text;
            int cid = Convert.ToInt32(categorycombo.SelectedValue);
            SqlCommand cmd = new SqlCommand("insert into Product values('"+product+"',"+cid+",0,0)", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("Something went wrong");
            }
            populategrid();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(categorycombo.SelectedValue);
            SqlCommand cmd = new SqlCommand("UPDATE Product set Name = '"+prodnametxt.Text+"',cid="+ cid + " where id="+RowId, con);
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
            var result = MessageBox.Show("Do you want to delete product " + RowId + " ??", "Alert!!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from Product where id=" + RowId, con);
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
                prodnametxt.Text = e.Row.Cells[1].FormattedValue.ToString();
                categorycombo.SelectedValue= e.Row.Cells[2].FormattedValue.ToString();
            }
        }
    }
}

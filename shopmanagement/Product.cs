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
        SqlConnection con;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ToString());
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select id,UPPER(CategoryName) from Category");
            cmd3.Connection = con;
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            da.Fill(dt2);
            categorycombo.DataSource = dt2;
            categorycombo.DisplayMember = dt2.Columns[1].ColumnName;
            categorycombo.ValueMember = dt2.Columns[0].ColumnName;
            con.Close();

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
        //--------------------------------------ends here----------------------------------//

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}

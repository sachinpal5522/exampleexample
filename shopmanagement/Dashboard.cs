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

namespace shopmanagement
{
    public partial class Dashboard : UserControl
    {
        public SqlConnection con;
        public Dashboard()
        {
            InitializeComponent();
            masalachat.Visible = false;
         //   select p.Name,(o.sellprice - o.buyprice) as profit from Product p,Orders o where p.id = o.pid
        }

        private void drawgraph(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            masalachat.DataSource = dt;
            masalachat.Series["Profit"].XValueMember = dt.Columns[0].ColumnName;
            masalachat.Series["Profit"].YValueMembers = dt.Columns[1].ColumnName;
            masalachat.DataBind();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            masalachat.Visible = true;
            SqlCommand cmd = new SqlCommand("select p.Name,(o.sellprice - o.buyprice) as Profit from Product p,Orders o where p.id = o.pid", con);
            drawgraph(cmd);
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            masalachat.Visible = true;
            SqlCommand cmd = new SqlCommand("select CategoryName,sum(o.sellprice-o.buyprice) as Profit from Product p,Orders o,Category c where p.Id=o.pid and p.Cid=c.Id group by CategoryName", con);
            drawgraph(cmd);
        }
    }
}

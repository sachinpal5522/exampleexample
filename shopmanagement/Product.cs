using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanagement
{
    public partial class Product : UserControl
    {
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
        //--------------------------------------ends here----------------------------------//

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}

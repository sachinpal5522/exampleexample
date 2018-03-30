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
    public partial class Order : UserControl
    {
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
//----------------------------------ends here-----------------------------------//

    }
}

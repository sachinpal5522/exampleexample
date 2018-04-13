using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace shopmanagement
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }






//**********************************UI design functions******************************************//
        private void uidtext_Enter(object sender, EventArgs e)
        {
            loginline.BackColor = Color.MediumSeaGreen; //changes the underline color of userid textbox if focused
        }

        private void passtext_Enter(object sender, EventArgs e)
        {
            passline.BackColor = Color.MediumSeaGreen; //changes the underline color of pss textbox if focused
        }

        private void passtext_Leave(object sender, EventArgs e)
        {
            passline.BackColor = Color.Honeydew; 
            //changes the underline color back to white pass textbox is out of focuse
        }

        private void uidtext_Leave(object sender, EventArgs e)
        {
            //changes the underline color back to white when userid textbox is out of focuse
            loginline.BackColor = Color.Honeydew; 
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // for draggin the form around the window
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //****************************************UI DESIGN ENDS HERE***************************************//

        private void loginbtn_Click(object sender, EventArgs e)
        {

            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDatabase"].ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*)FROM login WHERE uid='" + uidtext.Text + "' and password='" + passtext.Text + "'");

            cmd.Connection = cn;
            int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();

            if (OBJ > 0 == true)
            {
                MainForm m = new MainForm();
                m.RefToForm1 = this;
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("UserId & Password Is not correct Try again..!!");
            }

        }
    }
}


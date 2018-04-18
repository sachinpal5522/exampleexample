﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shopmanagement
{
    public partial class CategoryForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SqlConnection con;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populategrid();
        }
        
        //----------------------------------design code------------------------------------//
        private void CatNametext_Enter(object sender, EventArgs e)
        {
            cateoverpanel.BackColor = Color.MediumSeaGreen;
            CatNametext.Clear();
        }

        private void CatNametext_Leave(object sender, EventArgs e)
        {
            cateoverpanel.BackColor = Color.Honeydew;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // for draggin the form around the window
        private void TopPane_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPane_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //---------------------------------ends here---------------------------------------//
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string name = CatNametext.Text;
            SqlCommand cmd = new SqlCommand("insert into Category values('"+name+"')", con);
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

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void populategrid()
        {
            SqlCommand cmd = new SqlCommand("select CategoryName from Category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CategoryGridView.DataSource = dt;
        }
    }
}

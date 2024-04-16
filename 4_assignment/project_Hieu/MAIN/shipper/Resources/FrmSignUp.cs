﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shipper_end.Resources
{
 

    public partial class FrmSignUp : Form
    {
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn =null;
        SqlDataAdapter daShip;
        DataTable dtShip;
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = txtUser.Text;
            string pass= txtPass.Text;
            string confirm = txtConfirm.Text;
            int role = 1;
            if (phone == "" || pass == "")
            {
                MessageBox.Show("Please enter complete information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match! Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "insert into account values('" + phone + "','" + pass + "','"+role+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Congratulations! You have successfully created an account.", "Succes", MessageBoxButtons.OK);
                this.Hide();

            }
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();
        }
    }
}

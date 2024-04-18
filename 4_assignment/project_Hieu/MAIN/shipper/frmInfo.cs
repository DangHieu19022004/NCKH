using shipper_end.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shipper_end
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        string phone;
        string pass;
        int role;
        public frmInfo(string phone,string pass, int role)
        {
            InitializeComponent();
            this.phone=phone;
            this.pass=pass;
            this.role=role;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(StrCon);
            conn.Open ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string home = txtHomeTown.Text;
            string area = cbArea.Text;
            string license = txtLicenses.Text;

            if (name == "" || home == "" || area==""||license=="")
            {
                MessageBox.Show("Please enter complete information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string sql1 = "insert into account values('" + phone + "','" + pass + "','" + role + "')";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    cmd1.ExecuteNonQuery();
                    string sql2 = "insert into shipper_table values(N'" + name + "',N'" + home + "','" + phone + "',N'" + area + "',N'" + license + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Congratulations, you have successfully created an account.", "Succes", MessageBoxButtons.OK);

                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("...........", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}

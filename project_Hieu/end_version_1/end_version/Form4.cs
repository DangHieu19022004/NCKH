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
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace end_version
{

    public partial class Form4 : Form
    {
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";

        Microsoft.Data.SqlClient.SqlConnection? con = null;


        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            con = new Microsoft.Data.SqlClient.SqlConnection(StrCon);
            con.Open();
            string n = this.Text;
            string sql = "SELECT * FROM shipper_table WHERE name = @name";
            Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", n);
            Microsoft.Data.SqlClient.SqlDataAdapter daShipper = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dtShipper = new DataTable();
            daShipper.Fill(dtShipper);
            dgvShipper.DataSource = dtShipper;
        }

    }
}

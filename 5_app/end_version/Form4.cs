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
using Microsoft.SqlServer;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace end_version
{

    public partial class Form4 : Form
    {
        string StrCon = @"Data Source=LEVANQUANG;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        // dùng dòng kia mới kết nối được, nếu cop nguyên ra k được đâu :)))=))
        SqlConnection con = null;

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            con = new SqlConnection(StrCon);
            con.Open();
            string n = this.Text;
            string sql = "SELECT * FROM shipper_table WHERE name = @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", n);
            SqlDataAdapter daShipper = new SqlDataAdapter(cmd);
            DataTable dtShipper = new DataTable();
            daShipper.Fill(dtShipper);
            dgvShipper.DataSource = dtShipper;
        }

    }
}

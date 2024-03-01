using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_version
{
    public partial class dgvOrders : Form
    {
        public dgvOrders()
        {
            InitializeComponent();
        }
        string StrCon = @"Data Source=LEVANQUANG;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        // dùng dòng kia mới kết nối được, nếu cop nguyên ra k được đâu :)))=))
        SqlConnection con = null;

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(StrCon);
            con.Open();
            string sql = "SELECT * FROM orders_table";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter daOrders = new SqlDataAdapter(cmd);
            DataTable dtOrders = new DataTable();
            daOrders.Fill(dtOrders);
            dataGridView1.DataSource = dtOrders;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

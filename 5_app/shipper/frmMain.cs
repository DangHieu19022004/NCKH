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
    public partial class frmMain : Form
    {
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        DataTable dt;
        SqlDataAdapter da;
        int vitrichon = -1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();
            string sql = "select * from orders_table";
            da= new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            if (vitrichon >= 0)
            {
               txtName.Text = dt.Rows[vitrichon][5].ToString();
                txtPhone.Text = dt.Rows[vitrichon][6].ToString();
                txtAdre.Text = dt.Rows[vitrichon][2].ToString();
                txtID.Text = dt.Rows[vitrichon][7].ToString();
                txtStatus.Text = dt.Rows[vitrichon][4].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dt.Rows[vitrichon][7].ToString();
            string status = "Đã giao";
            string sql = "update orders_table set Status='" + status + "' where order_id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            dt.Rows.Clear();
            da.Fill(dt);
        }
    }
}

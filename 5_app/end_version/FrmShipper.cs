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

namespace end_version
{
    public partial class FrmShipper : Form
    {
        public FrmShipper()
        {
            InitializeComponent();

        }

        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        SqlDataAdapter daShip;
        DataTable dtShip;
        int vitrichon = -1;

        private void frmShipper_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();
            string sql = "select shipper_id as 'ID' ,name as 'Name',phone_number as 'Phone number',license_plates as 'License plates' ,home_town as 'Home town',district as 'Area' from shipper_table";
            daShip = new SqlDataAdapter(sql, conn);
            dtShip = new DataTable();
            daShip.Fill(dtShip);
            dgvInfo.DataSource = dtShip;

        }

        private void cbShip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            if (vitrichon >= 0)
            {
                txtName.Text = dtShip.Rows[vitrichon][1].ToString();
                txtPhone.Text = dtShip.Rows[vitrichon][2].ToString();
                txtLicense.Text = dtShip.Rows[vitrichon][3].ToString();
                txtHomeTown.Text = dtShip.Rows[vitrichon][4].ToString();
                txtArea.Text = dtShip.Rows[vitrichon][5].ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this shipper?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả từ MessageBox
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dtShip.Rows[vitrichon][0].ToString());
                string sql = "delete from shipper_table where shipper_id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtShip.Rows.Clear();
                daShip.Fill(dtShip);
                
                string phone = dtShip.Rows[vitrichon][2].ToString();
                string acc = "delete from account where username = '" + phone + "'";
                SqlCommand sqlCommand = new SqlCommand(acc, conn);
                sqlCommand.ExecuteNonQuery();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

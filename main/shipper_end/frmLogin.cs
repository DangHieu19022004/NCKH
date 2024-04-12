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

namespace shipper_end
{
    
    
    public partial class frmLogin : Form
    {
        string StrCon = @"Data Source=LEVANQUANG;Initial Catalog=shipper;Integrated Security=True";
        SqlConnection conn = null;
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string u = txtUser.Text;
                string p = txtPas.Text;
                conn = new SqlConnection(StrCon);
                conn.Open();
                string sql = $"Select * from account where  username='{u}' and password='{p} '";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dat = cmd.ExecuteReader();
                if (dat.Read())
                {
                    this.Hide(); /*ẩn form hiện thời */
                    frmMain frmMain = new frmMain();
                    /*C# hay có kiểu khởi tạo đối tượng bởi câu lệnh new => c++: khai báo động*/
                    frmMain.ShowDialog();
                    /*Hiển thị ra form và phải thao tác với mình nó ,Show() thì dễ dãi hơn ,ko như vậy*/
                }
                else
                {

                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /*Thông báo , tiêu đề, nút có thể ấn ,icon hiển thị */
                }
                conn.Close();
            }


            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

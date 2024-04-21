using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace shipper_end
{
    public partial class FrmMain : Form
    {
        public string[] CoordinateStorage = "21.007527, 105.824441".Split(',');
        public List<PointLatLng> start = new List<PointLatLng>();
        public List<PointLatLng> end = new List<PointLatLng>();
        public List<string> ordersIDList = new List<string>();

        public string phonenum;
        public int idshipper;

        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        DataTable dt;
        SqlDataAdapter da;
        int vitrichon = -1;
        public FrmMain(string phoneNum)
        {
            InitializeComponent();
            phonenum = phoneNum;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitAPI();

            conn = new SqlConnection(StrCon);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT shipper_id FROM shipper_table WHERE phone_number = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phonenum);
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                idshipper = read.GetInt32(read.GetOrdinal("shipper_id"));
            }

            conn.Close();

            conn.Open();

            string sql = "SELECT orders_table.order_id, total_shipping_cost, weight, distance, adress, customer_name, phone_number FROM assignment, orders_table WHERE assignment.order_id = orders_table.order_id and shipper_id = @idShip ";
            SqlCommand cmdOrder = new SqlCommand(sql, conn);
            cmdOrder.Parameters.AddWithValue("@idShip", idshipper);
            SqlDataReader reading = cmdOrder.ExecuteReader();
            while(reading.Read())
            {
                ordersIDList.Add(reading.GetInt32(reading.GetOrdinal("order_id")).ToString());
            }

            // must close sqlcommand before use da.Fill
            conn.Close();

            da= new SqlDataAdapter(cmdOrder);
            dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;

            makeRoot();
        }
        //
        public double getRoute(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 14);
            double km = route.Distance;
            return km;
        }

        public void InitAPI()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";
        }

        //start
        static int n;
        static int[] X = new int[5]; // Khởi tạo mảng X với kích thước phù hợp
        static bool[] visited = new bool[5]; // Khởi tạo mảng visited với kích thước phù hợp
        static double d = 0, ans = int.MaxValue, cmin = int.MaxValue;
        static List<double> path = new List<double>(), bestPath = new List<double>();
        static void UpdateBestPath()
        {
            bestPath = new List<double>(path);
        }

        static void Try(int i, double[,] inputAlgorithm)
        {
            for (int j = 0; j < n; j++) // Chỉ số bắt đầu từ 0
            {
                if (!visited[j])
                {
                    visited[j] = true;
                    X[i] = j;
                    d += inputAlgorithm[X[i - 1], X[i]];
                    path.Add(j);
                    if (i == n - 1) // Chỉ số kết thúc tại n - 1
                    {
                        ans = Math.Min(ans, d + inputAlgorithm[X[n - 1], 0]);
                        if (ans == d + inputAlgorithm[X[n - 1], 0])
                        {
                            UpdateBestPath();
                        }
                    }
                    else if (d + (n - i) * cmin <= ans)
                    {
                        Try(i + 1, inputAlgorithm);
                    }
                    visited[j] = false;
                    d -= inputAlgorithm[X[i - 1], X[i]];
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        static void FindMinValue(double[,] inputAlgorithm)
        {
            cmin = int.MaxValue;
            for (int i = 0; i < n; i++) // Chỉ số bắt đầu từ 0
            {
                for (int j = 0; j < n; j++) // Chỉ số bắt đầu từ 0
                {
                    if (inputAlgorithm[i, j] != 0)
                    {
                        cmin = Math.Min(cmin, inputAlgorithm[i, j]);
                    }
                }
            }
        }
        static void RunAlgorithm(double[,] inputAlgorithm)
        {
            n = inputAlgorithm.GetLength(0); // Xác định n dựa trên kích thước của mảng inputAlgorithm
            X[0] = 0; visited[0] = true; // Chỉ số bắt đầu từ 0
            path.Add(0);
            FindMinValue(inputAlgorithm);
            Try(1, inputAlgorithm);
        }
        //end
        class ConvertKQ
        {
            public int sttkey { get; set; }
            public string addr { get; set; }
            public string coordiNate { get; set; }
            public ConvertKQ(int Sttkey, string Addr, string coordinate)
            {
                sttkey = Sttkey;
                addr = Addr;
                coordiNate = coordinate;
            }
        }

        List<ConvertKQ> convertKQ = new List<ConvertKQ>();
        public void makeRoot()
        {
            convertKQ.Add(new ConvertKQ(1, "Đại học thủy lợi", "21.007527, 105.824441"));
            int i = 1;
            foreach(string ord in ordersIDList)
            {
                conn = new SqlConnection(StrCon);
                conn.Open();
                SqlCommand cmdOr = new SqlCommand("SELECT adress, Coordinate FROM orders_table WHERE order_id = " + ord, conn);
                SqlDataReader ReadOr = cmdOr.ExecuteReader();
                if (ReadOr.Read())
                {
                    string addr = ReadOr.GetString(ReadOr.GetOrdinal("adress"));
                    string coordinnate = ReadOr.GetString(ReadOr.GetOrdinal("Coordinate"));
                    i += 1;
                    convertKQ.Add(new ConvertKQ(i, addr, coordinnate));
                }
                conn.Close();
            }

            double[,] inputAlgorithm = new double[convertKQ.Count, convertKQ.Count];
            for(int m = 0; m < convertKQ.Count; m++)
            {
                string[] latlongStart = convertKQ[m].coordiNate.ToString().Split(',');
                start.Add(new PointLatLng(Convert.ToDouble(latlongStart[0]), Convert.ToDouble(latlongStart[1])));
                for(int n = 0; n < convertKQ.Count; n++)
                {
                    string[] latloneEnd = convertKQ[n].coordiNate.ToString().Split(',');
                    end.Add(new PointLatLng(Convert.ToDouble(latloneEnd[0]), Convert.ToDouble(latloneEnd[1])));
                    inputAlgorithm[m,n] = getRoute(start[m], end[n]);
                }
            }
            RunAlgorithm(inputAlgorithm);

            string result = "";
            foreach(int e in bestPath)
            {

                for (int f = 0; f < convertKQ.Count; f++)
                {
                    if ((e + 1) == convertKQ[f].sttkey)
                    {
                        result += convertKQ[f].addr.Trim();
                        if (e != bestPath.Last())
                        {
                            result += "   ->  ";
                        }
                    }
                }
            }
            lbShow.Text = result;
        }

        //

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            if (vitrichon >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[vitrichon];
                txtName.Text = row.Cells["customer_name"].Value.ToString();
                txtPhone.Text = row.Cells["phone_number"].Value.ToString();
                txtAdre.Text = row.Cells["adress"].Value.ToString();
                txbShipCost.Text = row.Cells["total_shipping_cost"].Value.ToString();
                txbW.Text = row.Cells["weight"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you have returned the item to the customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả từ MessageBox
            if (result == DialogResult.Yes)
            {
                conn = new SqlConnection(StrCon);
                conn.Open();
                string id = dt.Rows[vitrichon][0].ToString();
                string status = "Đã giao";
                string sql = "update orders_table set Status='" + status + "' where order_id ='" + id + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dt.Rows.Clear();
                da.Fill(dt);

                DateTime date = DateTime.Now;
                SqlCommand sqlCommand = new SqlCommand("update assignment set delivery_date = '" + date.ToString("yyyy-MM-dd") + "' where order_id ='" + id + "' ", conn);
                sqlCommand.ExecuteNonQuery();
            }
     

        }
    }
}

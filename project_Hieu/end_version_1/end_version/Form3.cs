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
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace end_version
{
    public partial class Form3 : Form
    {

        //public List<PointLatLng> start = new List<PointLatLng>();
        //public List<PointLatLng> end = new List<PointLatLng>();
        //public void InitAPI()
        //{
        //    GMapProviders.GoogleMap.ApiKey = @"AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";
        //}

        public Form3()
        {
            InitializeComponent();
            //InitAPI();
        }
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        // dùng dòng kia mới kết nối được, nếu cop nguyên ra k được đâu :)))=))
        SqlConnection? con = null;

        private void Form3_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(StrCon);
            //con.Open();
            //string sql = "SELECT * FROM orders_table";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //SqlDataAdapter daOrders = new SqlDataAdapter(cmd);
            //DataTable dtOrders = new DataTable();
            //daOrders.Fill(dtOrders);
            //dataGridView1.DataSource = dtOrders;

            addContentToCboBox();
        }
        private void addContentToCboBox()
        {
            con = new SqlConnection(StrCon);
            con.Open();

            SqlCommand Sqlcomd = new SqlCommand();
            Sqlcomd.CommandType = CommandType.Text;
            Sqlcomd.CommandText = "SELECT * FROM orders_table";
            Sqlcomd.Connection = con;

            SqlDataAdapter daOrders = new SqlDataAdapter(Sqlcomd);
            DataTable dtOrders = new DataTable();
            daOrders.Fill(dtOrders);
            dataGridView1.DataSource = dtOrders;

            //SqlCommand Sqlcomd1 = new SqlCommand();
            //Sqlcomd1.CommandType = CommandType.Text;
            //Sqlcomd1.CommandText = $"SELECT shipper_id, name FROM shipper_table";
            //Sqlcomd1.Connection = con;
            //SqlDataReader read = Sqlcomd1.ExecuteReader();
            //while (read.Read())
            //{
            //    string idshipper = read.GetString(0);
            //    string name = read.GetString(1);
            //    string line = idshipper.Trim() + " - " + name;
            //    comboBox1.Items.Add(line);
            //}
            
            con.Close();
        }
        //public double getRoute(PointLatLng start, PointLatLng end)
        //{
        //    var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 14);
        //    double km = route.Distance;
        //    return km;
        //}
        //List<string> list = new List<string>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

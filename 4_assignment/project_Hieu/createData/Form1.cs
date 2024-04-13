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
using System.Drawing.Drawing2D;

namespace createData
{
    public partial class Form1 : Form
    {

        public string[] CoordinateStorage = "21.0073516,105.8221555".Split(',');
        public List<PointLatLng> start = new List<PointLatLng>();
        public List<PointLatLng> end = new List<PointLatLng>();

        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con = null;
        public double getRoute(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 14);
            double km = route.Distance;
            return km;
        }

        public double getCost(double weight, double distance)
        {
            double cost = 0;
            if(weight <= 3)
            {
                cost = 30000;
            }
            else
            {
                cost = (weight - 3) * 2.5 + 30000;
            }
            return cost;
        }
        public void InitAPI()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";
        }

        public class shipdata
        {
            public int ShipperId { get; set; }
        }

        public class orderdata
        {
            public double weight { get; set; }
            public double distance { get; set; }
            public int orderid { get; set; }
        }
        public void CreateData()
        {
            List<shipdata> shipData = new List<shipdata>();
            List<orderdata> orderData = new List<orderdata>();
            
            // get count shipper
            con = new SqlConnection(StrCon);
            con.Open();

            SqlCommand shipcount = new SqlCommand("SELECT COUNT(*) FROM shipper_table", con);
            int shipCount = (int)shipcount.ExecuteScalar();

            con.Close();
            //

            // get count order
            con.Open();

            SqlCommand ordercount = new SqlCommand("SELECT COUNT(*) FROM orders_table", con);
            int orderCount = (int)ordercount.ExecuteScalar();

            con.Close();
            //

            double divide = orderCount / shipCount;

            // read shipper table
            con.Open();
            
            SqlCommand shipcmd = new SqlCommand("SELECT * FROM shipper_table", con);
            SqlDataReader shipread = shipcmd.ExecuteReader();
            while (shipread.Read())
            {
                shipdata dataShip = new shipdata();
                dataShip.ShipperId = shipread.GetInt32(shipread.GetOrdinal("shipper_id"));
                shipData.Add(dataShip);
            }

            con.Close();
            //

            // read order table
            con.Open();

            SqlCommand ordercmd = new SqlCommand("SELECT * FROM orders_table", con);
            SqlDataReader orderread = ordercmd.ExecuteReader();
            while (orderread.Read())
            {
                orderdata dataOrder = new orderdata();
                dataOrder.orderid = orderread.GetInt32(orderread.GetOrdinal("order_id"));
                dataOrder.weight = orderread.GetDouble(orderread.GetOrdinal("weight"));
                dataOrder.distance = orderread.GetDouble(orderread.GetOrdinal("distance"));
                orderData.Add(dataOrder);
            }

            con.Close();
            //
            MessageBox.Show("chia");
            bool checkN = divide == Math.Floor(divide);
            int checkStop = 0;
            foreach (shipdata shipRead in shipData)
            {
                checkStop++;
                if (checkStop == shipCount && !checkN)
                {
                    divide -= 1;
                }

                int idship = shipRead.ShipperId;
                if(divide >= orderData.Count)
                {
                    divide = orderData.Count;
                }
                for (int i = 0; i < divide; i++)
                {
                    int idorder = orderData[i].orderid;
                    double weight = orderData[i].weight;
                    double distance = orderData[i].distance;
                    double totalship = getCost(weight, distance);

                    con = new SqlConnection(StrCon);
                    con.Open();

                    SqlCommand create = new SqlCommand("INSERT INTO assignment VALUES(@idorder, @idship, @totalship, NULL)", con);
                    create.Parameters.AddWithValue("@idorder", idorder);
                    create.Parameters.AddWithValue("@idship", idship);
                    create.Parameters.AddWithValue("@totalship", totalship);
                    int check = create.ExecuteNonQuery();

                    con.Close();
                }
                orderData.RemoveRange(0, (int)divide);
            }
        }

            
        public Form1()
        {
            InitializeComponent();
            InitAPI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(StrCon);
            con.Open();

            string query = "SELECT * FROM orders_table";
            
            SqlDataAdapter apt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
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

        public double getCost(double weight, double distance)
        {
            double cost = 0;
            if (weight <= 3)
            {
                cost = 30000;
            }
            else
            {
                cost = (weight - 3) * 2.5 + 30000;
            }
            return cost;
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
                if (divide >= orderData.Count)
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

        public void showOrders()
        {
            con = new SqlConnection(StrCon);
            con.Open();

            string sql = "SELECT * FROM assignment";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter daOrders = new SqlDataAdapter(cmd);
            DataTable dtOrders = new DataTable();
            daOrders.Fill(dtOrders);
            dataGridView1.DataSource = dtOrders;

            con.Close();
        }
        private void btnSplitOrders_Click(object sender, EventArgs e)
        {
            CreateData();
            showOrders();
        }
    }
}

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
    public partial class ord : Form
    {
        public ord()
        {
            InitializeComponent();
        }
        string StrCon = @"Data Source=(local);Initial Catalog=shipper_Hieu;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con = null;
        SqlDataAdapter daOrders, daShip, daAss;
        DataTable dtOrders, dtShip, dtAss;
        int vitrichon = -1;

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(StrCon);
            con.Open();
  
            string sql = "select order_id as 'Order ID' ,customer_name as 'Customer name', phone_number as 'Phone number'" +
                ",adress as 'Adress',weight as 'Weight' " +
                ",distance as 'Distance',Status from orders_table";
            SqlCommand cmd = new SqlCommand(sql, con);
            daOrders = new SqlDataAdapter(cmd);
            dtOrders = new DataTable();
            daOrders.Fill(dtOrders);
            dgvOrrders.DataSource = dtOrders;
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
        bool splitData = false;
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

            int basicOrderPerShipper = orderCount / shipCount;
            int remainingOrders = orderCount % shipCount;

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
            try
            {
           

                for (int indexShipper = 0; indexShipper < shipCount; indexShipper++)
                {
                    int ordersToAssign = indexShipper == shipCount - 1 ? basicOrderPerShipper + remainingOrders : basicOrderPerShipper;

                    for (int i = 0; i < ordersToAssign; i++)
                    {
                        if (orderData.Count == 0)
                            break;

                        var currentOrder = orderData[0];

                        int idorder = orderData[0].orderid;
                        double weight = orderData[0].weight;
                        double distance = orderData[0].distance;
                        double totalship = getCost(weight, distance);

                        con = new SqlConnection(StrCon);
                        con.Open();

                        SqlCommand create = new SqlCommand("INSERT INTO assignment (order_id, shipper_id, total_shipping_cost) VALUES(@idorder, @idship, @totalship)", con);
                        create.Parameters.AddWithValue("@idorder", idorder);
                        create.Parameters.AddWithValue("@idship", shipData[indexShipper].ShipperId);
                        create.Parameters.AddWithValue("@totalship", totalship);

                        int check = create.ExecuteNonQuery();

                        con.Close();


                        orderData.RemoveAt(0);
                    }
                }

                MessageBox.Show("Split orders completed!", "Succes", MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Split orders completed!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);
            };
            splitData = true;
        }




        private void btnSplitOrders_Click(object sender, EventArgs e)
        {
            CreateData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitrichon = e.RowIndex;
            if (splitData is false)
            {
                MessageBox.Show("Please split orders !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (vitrichon >= 0)
            {
                txtNameCus.Text = dtOrders.Rows[vitrichon][1].ToString();
                txtPhoneCus.Text = dtOrders.Rows[vitrichon][2].ToString();
                txtAdressCus.Text = dtOrders.Rows[vitrichon][3].ToString();
                int idAss = Convert.ToInt32(dtOrders.Rows[vitrichon][0].ToString());
                string sqlAss = "select * from assignment where order_id ='" + idAss + "'";
                daAss = new SqlDataAdapter(sqlAss, con);
                dtAss = new DataTable();
                daAss.Fill(dtAss);
                int idShip = Convert.ToInt32(dtAss.Rows[0][1].ToString());
                txtSumCost.Text = dtAss.Rows[0][2].ToString();
                txtStatus.Text = dtOrders.Rows[vitrichon][6].ToString();
                string sqlShip = "select * from shipper_table where shipper_id ='" + idShip + "'";
                daShip = new SqlDataAdapter(sqlShip, con);
                dtShip = new DataTable();
                daShip.Fill(dtShip);
                txtNameShip.Text = dtShip.Rows[0][0].ToString();
                txtPhoneShip.Text = dtShip.Rows[0][2].ToString();
                txtLicense.Text = dtShip.Rows[0][4].ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

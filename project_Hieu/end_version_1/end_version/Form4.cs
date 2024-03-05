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

    public partial class Form4 : Form
    {
        ////start
        //static int n;
        //static int[] X = new int[5]; // Khởi tạo mảng X với kích thước phù hợp
        //static bool[] visited = new bool[5]; // Khởi tạo mảng visited với kích thước phù hợp
        //static double d = 0, ans = int.MaxValue, cmin = int.MaxValue;
        //static List<double> path = new List<double>(), bestPath = new List<double>();
        //static void UpdateBestPath()
        //{
        //    bestPath = new List<double>(path);
        //}

        //class ConvertKQ
        //{
        //    public int sttkey { get; set; }
        //    public string addr { get; set; }

        //    public ConvertKQ(int Sttkey, string Addr)
        //    {
        //        sttkey = Sttkey;
        //        addr = Addr;
        //    }
        //}

        //List<ConvertKQ> convertKQ = new List<ConvertKQ>();
        //static void Try(int i, double[,] inputAlgorithm)
        //{
        //    for (int j = 0; j < n; j++) // Chỉ số bắt đầu từ 0
        //    {
        //        if (!visited[j])
        //        {
        //            visited[j] = true;
        //            X[i] = j;
        //            d += inputAlgorithm[X[i - 1], X[i]];
        //            path.Add(j);
        //            if (i == n - 1) // Chỉ số kết thúc tại n - 1
        //            {
        //                ans = Math.Min(ans, d + inputAlgorithm[X[n - 1], 0]);
        //                if (ans == d + inputAlgorithm[X[n - 1], 0])
        //                {
        //                    UpdateBestPath();
        //                }
        //            }
        //            else if (d + (n - i) * cmin <= ans)
        //            {
        //                Try(i + 1, inputAlgorithm);
        //            }
        //            visited[j] = false;
        //            d -= inputAlgorithm[X[i - 1], X[i]];
        //            path.RemoveAt(path.Count - 1);
        //        }
        //    }
        //}

        //static void FindMinValue(double[,] inputAlgorithm)
        //{
        //    cmin = int.MaxValue;
        //    for (int i = 0; i < n; i++) // Chỉ số bắt đầu từ 0
        //    {
        //        for (int j = 0; j < n; j++) // Chỉ số bắt đầu từ 0
        //        {
        //            if (inputAlgorithm[i, j] != 0)
        //            {
        //                cmin = Math.Min(cmin, inputAlgorithm[i, j]);
        //            }
        //        }
        //    }
        //}
        //static void RunAlgorithm(double[,] inputAlgorithm)
        //{
        //    n = inputAlgorithm.GetLength(0); // Xác định n dựa trên kích thước của mảng inputAlgorithm
        //    X[0] = 0; visited[0] = true; // Chỉ số bắt đầu từ 0
        //    path.Add(0);
        //    FindMinValue(inputAlgorithm);
        //    Try(1, inputAlgorithm);
        //}
        ////end

        //public List<PointLatLng> start = new List<PointLatLng>();
        //public List<PointLatLng> end = new List<PointLatLng>();
        //public void InitAPI()
        //{
        //    GMapProviders.GoogleMap.ApiKey = @"AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";
        //}

        string StrCon = @"Data Source=DOLPHIN;Initial Catalog=shipper;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection? con = null;

        public Form4()
        {
            InitializeComponent();
            //InitAPI();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            con = new Microsoft.Data.SqlClient.SqlConnection(StrCon);
            con.Open();
            string n = this.Text;
            string sql = "SELECT * FROM shipper_table WHERE name = @name";
            Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", n);
            Microsoft.Data.SqlClient.SqlDataAdapter daShipper = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dtShipper = new DataTable();
            daShipper.Fill(dtShipper);
            dgvShipper.DataSource = dtShipper;
            //addContentToCboBox();
        }
        //private void addContentToCboBox()
        //{
        //    con = new SqlConnection(StrCon);
        //    con.Open();

        //    SqlCommand Sqlcomd = new SqlCommand();
        //    Sqlcomd.CommandType = CommandType.Text;
        //    Sqlcomd.CommandText = "SELECT * FROM orders_table";
        //    Sqlcomd.Connection = con;

        //    SqlCommand Sqlcomd1 = new SqlCommand();
        //    Sqlcomd1.CommandType = CommandType.Text;
        //    Sqlcomd1.CommandText = $"SELECT shipper_id, name FROM shipper_table";
        //    Sqlcomd1.Connection = con;
        //    SqlDataReader read = Sqlcomd1.ExecuteReader();
        //    while (read.Read())
        //    {
        //        string idshipper = read.GetString(0);
        //        string name = read.GetString(1);
        //        string line = idshipper.Trim() + " - " + name;
        //        comboBox1.Items.Add(line);
        //    }

        //    con.Close();
        //}
        //public double getRoute(PointLatLng start, PointLatLng end)
        //{
        //    var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 14);
        //    double km = route.Distance;
        //    return km;
        //}
        //List<string> list = new List<string>();
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "";
        //    if (comboBox1.SelectedItem == null) { return; }
        //    string[] line = comboBox1.SelectedItem.ToString().Split('-');
        //    string idshipper = line[0].Trim();

        //    con = new SqlConnection(StrCon);
        //    con.Open();

        //    bool isEmpty = true;
        //    SqlCommand Sqlcomd = new SqlCommand();
        //    Sqlcomd.CommandType = CommandType.Text;
        //    Sqlcomd.CommandText = $"SELECT * FROM orders_table WHERE shipper_id = '{idshipper}'";
        //    Sqlcomd.Connection = con;
        //    SqlDataReader reader = Sqlcomd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        isEmpty = false;
        //        int stt = reader.GetInt32(5);
        //        string address = reader.GetString(4);
        //        string coordinates = reader.GetString(6);
        //        convertKQ.Add(new ConvertKQ(stt, address));
        //        string all = address + "/" + coordinates;
        //        list.Add(all);
        //    }
        //    if (isEmpty)
        //    {
        //        label1.Text = "chưa có đơn hàng";
        //        return;
        //    }
        //    double[,] inputAlgorithm = new double[list.Count, list.Count];
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        string[] stringstart = list[i].ToString().Split("/");
        //        string[] latlongstart = stringstart[1].Trim().Split(',');
        //        start.Add(new PointLatLng(Convert.ToDouble(latlongstart[0]), Convert.ToDouble(latlongstart[1])));
        //        for (int j = 0; j < list.Count; j++)
        //        {
        //            string[] stringend = list[j].ToString().Split("/");
        //            string[] latlongend = stringend[1].Trim().Split(',');
        //            end.Add(new PointLatLng(Convert.ToDouble(latlongend[0]), Convert.ToDouble(latlongend[1])));
        //            inputAlgorithm[i, j] = getRoute(start[i], end[j]);
        //        }
        //    }
        //    RunAlgorithm(inputAlgorithm);

        //    string result = "";
        //    foreach (double i in bestPath)
        //    {
        //        for (int j = 0; j < convertKQ.Count; j++)
        //        {
        //            if ((i + 1) == convertKQ[j].sttkey)
        //            {
        //                result += convertKQ[j].addr.Trim();
        //                if (i != bestPath.Last())
        //                {
        //                    result += " -> ";
        //                }
        //            }
        //        }
        //    }
        //    label1.Text = result;

        //    convertKQ.Clear();
        //    start.Clear();
        //    end.Clear();
        //    con.Close();
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

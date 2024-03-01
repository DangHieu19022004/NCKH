using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace longitude
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.google.com/maps/@9.779349,105.6189045,11z");
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string[] urls = webView21.Source.ToString().Split('/');
            string[] paramters;
            if (urls[urls.Length - 1].Contains("data"))
            {
                paramters = urls[urls.Length - 2].Split(',');
                if (paramters.Length >= 3)
                {
                    textBox1.Text = paramters[0];
                    textBox2.Text = paramters[1];
                    textBox3.Text = paramters[2];
                }
            }
            else
            {
                paramters = urls[urls.Length - 1].Split(',');
                if (paramters.Length >= 3)
                {
                    textBox1.Text = paramters[0];
                    textBox2.Text = paramters[1];
                    textBox3.Text = paramters[2];
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nameText = textBox4.Text;
            string searchUrl = $"https://www.google.com/maps/search/{nameText}";
            webView21.CoreWebView2.Navigate(searchUrl);
        }
        // Các lớp ánh xạ dữ liệu JSON
        public class Distance
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class Duration
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class EndLocation
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class StartLocation
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Step
        {
            public Distance distance { get; set; }
            public Duration duration { get; set; }
        }

        public class Leg
        {
            public Distance distance { get; set; }
            public Duration duration { get; set; }
            public List<Step> steps { get; set; }
        }

        public class Route
        {
            public List<Leg> legs { get; set; }
        }

        public class RootObject
        {
            public List<Route> routes { get; set; }
            public string status { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start = textBox4.Text;
            string end = textBox5.Text;

            string apiUrl = $"https://maps.googleapis.com/maps/api/directions/json?origin={start}&destination={end}&key=AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";

            try
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(apiUrl);
                    RootObject root = JsonConvert.DeserializeObject<RootObject>(json);

                    if (root.status == "OK")
                    {
                        // Lấy thông tin về quãng đường đi
                        string distance = root.routes[0].legs[0].distance.text;
                        string duration = root.routes[0].legs[0].duration.text;

                        // Hiển thị thông tin vào textBox6
                        textBox6.Text = $"Distance: {distance}\r\nDuration: {duration}";
                    }
                    else
                    {
                        MessageBox.Show("No route found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
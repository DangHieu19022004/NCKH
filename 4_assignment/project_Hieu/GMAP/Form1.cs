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


namespace GMAP_Balaij_S
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBhFQr0Lj0Mhe8HLKrLlY4q89AOhVvf53w";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";

            map.SetPositionByKeywords("Hà Nội");
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(txtLat.Text);
            double lon = Convert.ToDouble(txtLon.Text);
            map.Position = new PointLatLng(lat, lon);
            map.MinZoom = 15;
            map.MaxZoom = 100;
            map.Zoom = 15;

            PointLatLng point = new PointLatLng(lat, lon);

            

            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);

            //1. create a overlay
            GMapOverlay markers = new GMapOverlay("markers");

            //2. add all available markers to that overlay
            markers.Markers.Add(marker);

            //3. cover map with overlay
            map.Overlays.Add(markers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text),
                Convert.ToDouble(txtLon.Text)));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);


            lbDistance.Text = route.Distance + " km";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string addr = textBox1.Text;
            map.SetPositionByKeywords(addr);
        }
    }
}

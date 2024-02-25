using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GmapControltest
{
    public partial class Form1 : Form
    {
        private GMapOverlay markersOverlay;
        public Form1()
        {
            InitializeComponent();
            markersOverlay = new GMapOverlay("markers");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string coordinate = comboBox1.SelectedItem.ToString();
            string[] parts = coordinate.Split(',');
            double latitude = double.Parse(parts[0], CultureInfo.InvariantCulture);
            double longitude = double.Parse(parts[1], CultureInfo.InvariantCulture);
            AddMarker(latitude, longitude);
            
        }

        private void AddMarker(double latitude, double longitude)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);
            gMapControl1.Position = new PointLatLng(latitude, longitude);
            gMapControl1.Zoom = 30;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 16;
            gMapControl1.Zoom = 4;
            //gMapControl1.Position = new GMap.NET.PointLatLng(66.41, 94.25);
            //gMapControl1.SetPositionByKeywords("Paris, France");
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.ShowTileGridLines = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            markersOverlay.Markers.Clear();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //      static string baseUri =
        //"http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false";
        //      string location = string.Empty;

        //      public static void RetrieveFormatedAddress(string lat, string lng)
        //      {
        //          string requestUri = string.Format(baseUri, lat, lng);

        //          using (WebClient wc = new WebClient())
        //          {
        //              string result = wc.DownloadString(requestUri);
        //              var xmlElm = XElement.Parse(result);
        //              var status = (from elm in xmlElm.Descendants()
        //                            where
        //                  elm.Name == "status"
        //                            select elm).FirstOrDefault();
        //              if (status.Value.ToLower() == "ok")
        //              {
        //                  var res = (from elm in xmlElm.Descendants()
        //                             where
        //                      elm.Name == "formatted_address"
        //                             select elm).FirstOrDefault();
        //                  requestUri = res.Value;
        //              }
        //          }
        //          MessageBox.Show(requestUri);
        //      }
        public static Coordinate GetCoordinates(string region)
        {
            using (var client = new WebClient())
            {

                string uri = "http://maps.google.com/maps/geo?q='" + region +
                  "'&output=csv&key=sadfwet56346tyeryhretu6434tertertreyeryeryE1";

                string[] geocodeInfo = client.DownloadString(uri).Split(',');

                return new Coordinate(Convert.ToDouble(geocodeInfo[2]),
                           Convert.ToDouble(geocodeInfo[3]));
            }
        }

        public struct Coordinate
        {
            private double lat;
            private double lng;

            public Coordinate(double latitude, double longitude)
            {
                lat = latitude;
                lng = longitude;

            }

            public double Latitude { get { return lat; } set { lat = value; } }
            public double Longitude { get { return lng; } set { lng = value; } }

        }
    }
}
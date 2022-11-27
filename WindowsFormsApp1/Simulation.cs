using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using DECODEclass;


namespace WindowsFormsApp1
{
    public partial class Simulation : Form
    {
        
        List<marker> markers = new List<marker>();
        //SMR
        static Bitmap smrA = (Bitmap)Image.FromFile("smrR.png");
        GMarkerGoogle SMRmarker = new GMarkerGoogle(new PointLatLng(41.29561833, 2.095114167), smrA);
        GMapOverlay SMRlayer=new GMapOverlay("SMR");
       

        //MLAT
        static Bitmap mlatA = (Bitmap)Image.FromFile("mlatR.png");
        GMarkerGoogle MLATmarker = new GMarkerGoogle(new PointLatLng(41.29706278, 2.078447222),mlatA);
        GMapOverlay MLATlayer=new GMapOverlay("MLAT");

        //ADSB
        GMapOverlay ADSBlayer= new GMapOverlay("ADS-B");

        public Simulation()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            createListMark();


            gMapControl1.ShowCenter = false; //Marker cross red not visible
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapControl1.Position = new PointLatLng(41.29561833, 2.095114167); //SMR
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;



            SMRlayer.Markers.Add(SMRmarker);
            SMRlayer.Markers.Add(MLATmarker);
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = String.Format("Estás aquí");

            // Add Overlays to map
            gMapControl1.Overlays.Add(SMRlayer);
            gMapControl1.Overlays.Add(MLATlayer);

        }

        private void createListMark()
        {
            //marker(double t, string c, int i, int SIC, double pos1, double pos2)
            for (int i = 0; i < Main.main.myListCAT10.Count; i++)
            {
                markers.Add(new marker(Main.main.myListCAT10[i].TimeOfDay, "10", i, Main.main.myListCAT10[i].SIC, Main.main.myListCAT10[i].x, Main.main.myListCAT10[i].y));
            }
            for (int i = 0; i < Main.main.myListCAT10.Count; i++)
            {
                markers.Add(new marker(Main.main.myListCAT21[i].timeReportTrans, "21", i,Main.main.myListCAT10[i].SIC, Main.main.myListCAT10[i].latitude, Main.main.myListCAT10[i].longitude));
            }

            markers = markers.OrderBy(mark => mark.time).ToList();
        }
    }
}

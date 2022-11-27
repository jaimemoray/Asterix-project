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



namespace WindowsFormsApp1
{
    public partial class Simulation : Form
    {

        //SMR

        //GMapMarker SMRmarker=GMapMarker(new PointLatLng(41.29561833, 2.095114167));
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


    }
}

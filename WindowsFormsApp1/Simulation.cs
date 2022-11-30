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
        //Timer
        

        List<marker> markers = new List<marker>();
        //SMR
        //static Bitmap smrA = (Bitmap)Image.FromFile("smrR.png");
        //GMarkerGoogle SMRmarker = new GMarkerGoogle(new PointLatLng(41.29561833, 2.095114167), smrA);
        GMapOverlay SMRlayer=new GMapOverlay("SMR");
       

        //MLAT
        //static Bitmap mlatA = (Bitmap)Image.FromFile("mlatR.png");
        //GMarkerGoogle MLATmarker = new GMarkerGoogle(new PointLatLng(41.29706278, 2.078447222),mlatA);
        GMapOverlay MLATlayer=new GMapOverlay("MLAT");

        //ADSB
        GMapOverlay ADSBlayer= new GMapOverlay("ADS-B");

        //Start simulation
        double ini;
        double slot=1;
        int index = 0;


        // Number of plane


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
            //CheckListBox Layer
            layerListBox.Items.Add("SMR",true);
            layerListBox.Items.Add("MLAT",true);
            layerListBox.Items.Add("ADS-B",true);
            layerListBox.CheckOnClick = true;


            // Map
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



            //SMRlayer.Markers.Add(SMRmarker);
            //SMRlayer.Markers.Add(MLATmarker);
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = String.Format("Estás aquí");

            // Add Overlays to map
            gMapControl1.Overlays.Add(SMRlayer);
            gMapControl1.Overlays.Add(MLATlayer);

            // Timer
            timer.Interval = 1000;

        }

        public void createListMark()
        {
            //marker(double t, string c, int i, int SIC, double pos1, double pos2)
            if (Main.main.myListCAT10.Count != 0)
            {
                for (int i = 0; i < Main.main.myListCAT10.Count; i++)
                {

                        markers.Add(marker.myMarker(Main.main.myListCAT10[i].TimeOfDay, "10", i, Main.main.myListCAT10[i].SIC, Main.main.myListCAT10[i].x, Main.main.myListCAT10[i].y, Main.main.myListCAT10[i].targetAddress));

                   
                }
            }

            if (Main.main.myListCAT21.Count!=0)
            {

                    for (int i = 0; i < Main.main.myListCAT21.Count; i++)
                    {
                        markers.Add(marker.myMarker(Main.main.myListCAT21[i].timeReportTrans, "21", i, Main.main.myListCAT21[i].SIC, Main.main.myListCAT21[i].latitude, Main.main.myListCAT21[i].longitude, Main.main.myListCAT21[i].targetIdentification));
                    }


            }


            markers = markers.OrderBy(mark => mark.time).ToList();
            this.ini = markers[0].time;
        }

        private void move(double slot) //0.01
        {


            while (markers[index].time<=ini+slot)
            {
                
                switch (markers[index].ins)
                {
                    case "SMR":
                        if (SMRlayer.Markers.Count > 20)
                        {
                            SMRlayer.Markers.RemoveAt(0);
                        }
                        if (Main.main.myListCAT10[markers[index].indexList].MessageType== "Target Report")
                        {
                            SMRlayer.Markers.Add(markers[index]);
                            gMapControl1.Overlays.Add(SMRlayer);
                        }

                       
                        break;
                    case "MLAT":


                        MLATlayer.Markers.Add(markers[index]);
                        gMapControl1.Overlays.Add(MLATlayer);

                        break;
                    case "ADSB":
                        //eliminatePreviusPos(1, markers[index]);
                        ADSBlayer.Markers.Add(markers[index]);
                        gMapControl1.Overlays.Add(ADSBlayer);
                        break;
                }
                index++;
            }
            ini = ini + slot;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            move(slot);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            move(slot);
        }

        private void startPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                timer.Stop();
            }
            else
            {
                timer.Enabled = true;
                timer.Start();
            }
        }

        private void previus_Click(object sender, EventArgs e)
        {
            stepBack();
        }

        private void stepBack()
        {
            
        }

        private void layerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SMRlayer.IsVisibile = layerListBox.GetItemChecked(0) == false ? false : true;
            MLATlayer.IsVisibile = layerListBox.GetItemChecked(1) == false ? false : true;
            ADSBlayer.IsVisibile = layerListBox.GetItemChecked(2) == false ? false : true;
        }



        private void gMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            int pos = markers.FindIndex(p => p.Position == item.Position);

            switch (markers[pos].CAT)
            {
                case "10":
                    TIlabel.Text = Main.main.myListCAT10[markers[pos].indexList].targetIdentification == null ? "Target Identification: N/A" : "Target Identification: "+Main.main.myListCAT10[markers[pos].indexList].targetIdentification;
                    TAlabel.Text = Main.main.myListCAT10[markers[pos].indexList].targetAddress == null ? "Target Address: N/A" : "Target Address: "+Main.main.myListCAT10[markers[pos].indexList].targetAddress;
                    SIClabel.Text = Convert.ToString(Main.main.myListCAT10[markers[pos].indexList].SIC) == null ? "SIC: N/A" : "SIC: " +Main.main.myListCAT10[markers[pos].indexList].SIC;
                    TIMElabel.Text = Convert.ToString(Main.main.myListCAT10[markers[pos].indexList].TimeOfDay) == null ? "Time: N/A" : "Time: "+TimeSpan.FromSeconds(Main.main.myListCAT10[markers[pos].indexList].TimeOfDay).ToString(@"hh\:mm\:ss");
                    FLlabel.Text = Main.main.myListCAT10[markers[pos].indexList].flightLevel == null ? "Flight Level: N/A" : "Flight Level: " + Main.main.myListCAT10[markers[pos].indexList].flightLevel+" FL";
                    LATlabel.Text = "Latitude: N/A";
                    LNGlabel.Text = "Longitude: N/A";
                    Hlabel.Text = Main.main.myListCAT10[markers[pos].indexList].height == -1 ? "Height: N/A" : "Height : " + Main.main.myListCAT10[markers[pos].indexList].height + " ft";
                    break;
                case "21":
                    TIlabel.Text = Main.main.myListCAT21[markers[pos].indexList].targetIdentification == null ? "Target Identification: N/A" : "Target Identification: " + Main.main.myListCAT21[markers[pos].indexList].targetIdentification;
                    TAlabel.Text = Main.main.myListCAT21[markers[pos].indexList].targetAddress == null ? "Target Address: N/A" : "Target Address: " + Main.main.myListCAT21[markers[pos].indexList].targetAddress;
                    SIClabel.Text = Convert.ToString(Main.main.myListCAT21[markers[pos].indexList].SIC) == null ? "SIC: N/A" : "SIC: " + Main.main.myListCAT21[markers[pos].indexList].SIC;
                    TIMElabel.Text = Convert.ToString(Main.main.myListCAT21[markers[pos].indexList].timeReportTrans) == null ? "Time: N/A" : "Time: " + TimeSpan.FromSeconds(Main.main.myListCAT21[markers[pos].indexList].timeReportTrans).ToString(@"hh\:mm\:ss");
                    FLlabel.Text = Main.main.myListCAT21[markers[pos].indexList].flightLevel == null ? "Flight Level: N/A" : "Flight Level: " + Main.main.myListCAT21[markers[pos].indexList].flightLevel + " FL";
                    LATlabel.Text = Main.main.myListCAT21[markers[pos].indexList].latitude == -1 ? "Latitude: N/A" : "Latitude: " + Math.Round(Main.main.myListCAT21[markers[pos].indexList].latitude, 4) + " º N";
                    LNGlabel.Text = Main.main.myListCAT21[markers[pos].indexList].latitude == -1 ? "Longitude: N/A" : "Longitude: " + Math.Round(Main.main.myListCAT21[markers[pos].indexList].longitude, 4) + " º N";
                    Hlabel.Text = Main.main.myListCAT21[markers[pos].indexList].geometricHeight == null ? "Height: N/A" : "Height : " + Main.main.myListCAT21[markers[pos].indexList].geometricHeight+" ft";
                    break;
            }



        }

        //private void eliminatePreviusPos(int f, marker m, int ind)
        //{
        //    if (m.targetAddress!=null)
        //    {
        //        switch (f)
        //        {
        //            case 0:

        //                    for (int i = 0; i < ind; i++)
        //                    {
        //                        if (markers[i].targetAddress == m.targetAddress)
        //                        {
        //                            MLATlayer.Markers.Remove(markers[i]);
        //                            break;
        //                        }
        //                    }

 
        //                break;
        //            case 1:
        //                for (int i = 0; i < ind; i++)
        //                {
        //                    if (markers[i].targetAddress == m.targetAddress)
        //                    {
        //                        MLATlayer.Markers.Remove(markers[i]);
        //                        break;
        //                    }
        //                }

        //                break;
        //        }
        //    }

        //}
    }
}

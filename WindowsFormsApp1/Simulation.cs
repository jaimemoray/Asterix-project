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
using System.IO;

using DECODEclass;


namespace WindowsFormsApp1
{
    public partial class Simulation : Form
    {
        
        //ROUTES
        GMapOverlay Route = new GMapOverlay("Routes");
       

        
       

        //MARKERS
        List<marker> currentSMR = new List<marker>();
        List<marker> currentMLAT = new List<marker>();
        List<marker> currentADSB = new List<marker>();

        public List<marker> markers = new List<marker>();
        //SMR
        //static Bitmap smrA = (Bitmap)Image.FromFile("smrR.png");
        //GMarkerGoogle SMRmarker = new GMarkerGoogle(new PointLatLng(41.29561833, 2.095114167), smrA);
        GMapOverlay SMRlayer = new GMapOverlay("SMR");


        //MLAT
        //static Bitmap mlatA = (Bitmap)Image.FromFile("mlatR.png");
        //GMarkerGoogle MLATmarker = new GMarkerGoogle(new PointLatLng(41.29706278, 2.078447222),mlatA);
        GMapOverlay MLATlayer = new GMapOverlay("MLAT");

        //ADSB
        GMapOverlay ADSBlayer = new GMapOverlay("ADS-B");

        //Start simulation
        int ini;
        int end;
        int slot = 1;
        int index = 0;




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
            InscCheckedListBox.Items.Add("SMR", true);
            InscCheckedListBox.Items.Add("MLAT", true);
            InscCheckedListBox.Items.Add("ADS-B", true);
            InscCheckedListBox.CheckOnClick = true;


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
            gMapControl1.Overlays.Add(ADSBlayer);
            gMapControl1.Overlays.Add(Route);

            // Timer
            timer.Interval = 1000;

            this.ini = Convert.ToInt32(markers[0].time);
            this.end = Convert.ToInt32(markers[markers.Count - 1].time);
            ClockLabel.Text = TimeSpan.FromSeconds(markers[0].time).ToString(@"hh\:mm\:ss");
            startlabel.Text = "Start Simulation: " + TimeSpan.FromSeconds(markers[0].time).ToString(@"hh\:mm\:ss");
            endlabel.Text = "End Simulation: " + TimeSpan.FromSeconds(markers[markers.Count - 1].time).ToString(@"hh\:mm\:ss");

        }

        public void createListMark()
        {
            //marker(double t, string c, int i, int SIC, double pos1, double pos2)
            if (Main.main.myListCAT10.Count != 0)
            {
                for (int i = 0; i < Main.main.myListCAT10.Count; i++)
                {
                    if (Main.main.myListCAT10[i].MessageType == "Target Report")
                    {
                        switch (Main.main.myListCAT10[i].SIC)
                        {
                            case 7:
                                markers.Add(marker.myMarker(Main.main.myListCAT10[i].TimeOfDay, "10", i, Main.main.myListCAT10[i].SIC, Main.main.myListCAT10[i].x, Main.main.myListCAT10[i].y, Convert.ToString(Main.main.myListCAT10[i].trackNumber)));
                                break;
                        case 107:
                                if (Main.main.myListCAT10[i].targetAddress!=string.Empty)
                                {
                                    markers.Add(marker.myMarker(Main.main.myListCAT10[i].TimeOfDay, "10", i, Main.main.myListCAT10[i].SIC, Main.main.myListCAT10[i].x, Main.main.myListCAT10[i].y, Main.main.myListCAT10[i].targetAddress));
                                }
                                
                                break;
                        }
                        
                    }



                }
            }

            if (Main.main.myListCAT21.Count != 0)
            {

                for (int i = 0; i < Main.main.myListCAT21.Count; i++)
                {
                    if (Main.main.myListCAT21[i].targetAddress!=string.Empty)
                    {
                        markers.Add(marker.myMarker(Main.main.myListCAT21[i].timeReportTrans, "21", i, Main.main.myListCAT21[i].SIC, Main.main.myListCAT21[i].latitude, Main.main.myListCAT21[i].longitude, Main.main.myListCAT21[i].targetAddress));
                    }
                    
                }


            }


            markers = markers.OrderBy(mark => mark.time).ToList();

        }

        private void move() //0.01
        {
            ini = ini + slot;

            while (markers[index].time <= ini)
            {

                switch (markers[index].ins)
                {
                    case "SMR":
                        //if (SMRlayer.Markers.Count > 20)
                        //{
                        //    SMRlayer.Markers.RemoveAt(0);
                        //}
                        if (Main.main.myListCAT10[markers[index].indexList].MessageType == "Target Report")
                        {
                            eliminatePrevious(0, markers[index]);

                            SMRlayer.Markers.Add(markers[index]);
                            currentSMR.Add(markers[index]);
                            //gMapControl1.Overlays.Add(SMRlayer);
                        }


                        break;
                    case "MLAT":

                        if (Main.main.myListCAT10[markers[index].indexList].MessageType == "Target Report")
                        {
                            eliminatePrevious(1, markers[index]);
                            MLATlayer.Markers.Add(markers[index]);
                            currentMLAT.Add(markers[index]);
                            //gMapControl1.Overlays.Add(MLATlayer);
                        }
                        break;
                    case "ADSB":
                        eliminatePrevious(2, markers[index]);
                        ADSBlayer.Markers.Add(markers[index]);
                        currentADSB.Add(markers[index]);
                        //gMapControl1.Overlays.Add(ADSBlayer);
                        break;
                }
                index++;
            }

        }

        private void eliminatePrevious(int f, marker m)
        {
            int ind;
            switch (f)
            {
                case 0:
                    ind = currentSMR.FindIndex(tn => tn.id == m.id);

                    if (ind >= 0)
                    {
                        SMRlayer.Markers.RemoveAt(ind);
                        currentSMR.RemoveAt(ind);
                    }
                    break;
                case 1:
                    ind = currentMLAT.FindIndex(tn => tn.id == m.id);

                    if (ind >= 0)
                    {
                        MLATlayer.Markers.RemoveAt(ind);
                        currentMLAT.RemoveAt(ind);
                    }
                    break;
                case 2:
                    ind = currentADSB.FindIndex(tn => tn.id == m.id);

                    if (ind >= 0)
                    {
                        ADSBlayer.Markers.RemoveAt(ind);
                        currentADSB.RemoveAt(ind);
                    }
                    break;
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {

            move();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ini < end)
            {
               
                ClockLabel.Text = TimeSpan.FromSeconds(ini).ToString(@"hh\:mm\:ss");
                move();
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
                MessageBox.Show("Finished Simulation");
            }



        }

        private void startPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {

                startPause.BackgroundImage = Image.FromFile("play.png");
                timer.Enabled = false;
                timer.Stop();
            }
            else
            {
                startPause.BackgroundImage = Image.FromFile("pause.png");
                timer.Enabled = true;
                timer.Start();
            }
        }









  

        private void Setbutton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                int setTime = Convert.ToInt32(HcomboBox.SelectedItem) * 3600 + Convert.ToInt32(McomboBox.SelectedItem) * 60 + Convert.ToInt32(ScomboBox.SelectedItem);

                if (setTime > ini && setTime < end)
                {
                    Route.Routes.Clear();
                    currentSMR.Clear();
                    currentADSB.Clear();
                    currentMLAT.Clear();
                    SMRlayer.Clear();
                    MLATlayer.Clear();
                    ADSBlayer.Clear();
                    ini = setTime;
                    ClockLabel.Text = TimeSpan.FromSeconds(ini).ToString(@"hh\:mm\:ss");
                    index = markers.FindIndex(p => Convert.ToInt32(p.time) >= ini);

                }
                else
                {
                    MessageBox.Show("Time does not belong to the simulation range");
                }

            }
            else
            {
                MessageBox.Show("Must be selected when the simulation is not run");
            }


        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            Speedlabel.Text = "Speed: x" + SpeedTrackBar.Value.ToString();
            timer.Interval = Convert.ToInt32(1000 / SpeedTrackBar.Value);
        }

        private void InscCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SMRlayer.IsVisibile = InscCheckedListBox.GetItemChecked(0) == false ? false : true;
            MLATlayer.IsVisibile = InscCheckedListBox.GetItemChecked(1) == false ? false : true;
            ADSBlayer.IsVisibile = InscCheckedListBox.GetItemChecked(2) == false ? false : true;
        }

        private void createRoutes(string tn,string ins,Color myColor)
        {
            Route.Routes.Clear();
            List<marker> aircraftsADSB = markers.FindAll(c=>c.id==tn && c.ins==ins);
            List<PointLatLng> wayPoints = new List<PointLatLng>();

            foreach(marker m in aircrafts)
            {
                wayPoints.Add(m.Position);
            }
            
            GMapRoute myRoute = new GMapRoute(wayPoints, tn);
            myRoute.Stroke = new Pen(myColor);
            myRoute.Stroke.Width = 3;
            Route.Routes.Add(myRoute);
        }

        private void RoutecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Route.IsVisibile = RoutecheckBox.Checked == true ? true : false;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            index = 0;
            startPause.BackgroundImage = Image.FromFile("play.png");
            timer.Enabled = false;
            timer.Stop();

            SMRlayer.Clear();
            MLATlayer.Clear();
            ADSBlayer.Clear();
            Route.Clear();

            currentSMR.Clear();
            currentMLAT.Clear();
            currentADSB.Clear();

            this.ini = Convert.ToInt32(markers[0].time);
            this.end = Convert.ToInt32(markers[markers.Count - 1].time);
            ClockLabel.Text = TimeSpan.FromSeconds(markers[0].time).ToString(@"hh\:mm\:ss");
            startlabel.Text = "Start Simulation: " + TimeSpan.FromSeconds(markers[0].time).ToString(@"hh\:mm\:ss");
            endlabel.Text = "End Simulation: " + TimeSpan.FromSeconds(markers[markers.Count - 1].time).ToString(@"hh\:mm\:ss");
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            int pos = markers.FindIndex(p => p.Position == item.Position);

            switch (markers[pos].CAT)
            {
                case "10":
                    TIlabel.Text = Main.main.myListCAT10[markers[pos].indexList].targetIdentification == null ? "Target Identification: N/A" : "Target Identification: " + Main.main.myListCAT10[markers[pos].indexList].targetIdentification;
                    TAlabel.Text = Main.main.myListCAT10[markers[pos].indexList].targetAddress == null ? "Target Address: N/A" : "Target Address: " + Main.main.myListCAT10[markers[pos].indexList].targetAddress;
                    SIClabel.Text = Convert.ToString(Main.main.myListCAT10[markers[pos].indexList].SIC) == null ? "SIC: N/A" : "SIC: " + Main.main.myListCAT10[markers[pos].indexList].SIC;
                    TIMElabel.Text = Convert.ToString(Main.main.myListCAT10[markers[pos].indexList].TimeOfDay) == null ? "Time: N/A" : "Time: " + TimeSpan.FromSeconds(Main.main.myListCAT10[markers[pos].indexList].TimeOfDay).ToString(@"hh\:mm\:ss");
                    FLlabel.Text = Main.main.myListCAT10[markers[pos].indexList].flightLevel == null ? "Flight Level: N/A" : "Flight Level: " + Main.main.myListCAT10[markers[pos].indexList].flightLevel + " FL";
                    LATlabel.Text = "Latitude: N/A";
                    LNGlabel.Text = "Longitude: N/A";
                    Hlabel.Text = Main.main.myListCAT10[markers[pos].indexList].height == -1 ? "Height: N/A" : "Height : " + Main.main.myListCAT10[markers[pos].indexList].height + " ft";
                    trackNumberlabel.Text = Main.main.myListCAT10[markers[pos].indexList].trackNumber == 0 ? "Track Number: N/A" : "Track Number:: " + Main.main.myListCAT10[markers[pos].indexList].trackNumber;
                    break;
                case "21":
                    TIlabel.Text = Main.main.myListCAT21[markers[pos].indexList].targetIdentification == null ? "Target Identification: N/A" : "Target Identification: " + Main.main.myListCAT21[markers[pos].indexList].targetIdentification;
                    TAlabel.Text = Main.main.myListCAT21[markers[pos].indexList].targetAddress == null ? "Target Address: N/A" : "Target Address: " + Main.main.myListCAT21[markers[pos].indexList].targetAddress;
                    SIClabel.Text = Convert.ToString(Main.main.myListCAT21[markers[pos].indexList].SIC) == null ? "SIC: N/A" : "SIC: " + Main.main.myListCAT21[markers[pos].indexList].SIC;
                    TIMElabel.Text = Convert.ToString(Main.main.myListCAT21[markers[pos].indexList].timeReportTrans) == null ? "Time: N/A" : "Time: " + TimeSpan.FromSeconds(Main.main.myListCAT21[markers[pos].indexList].timeReportTrans).ToString(@"hh\:mm\:ss");
                    FLlabel.Text = Main.main.myListCAT21[markers[pos].indexList].flightLevel == null ? "Flight Level: N/A" : "Flight Level: " + Main.main.myListCAT21[markers[pos].indexList].flightLevel + " FL";
                    LATlabel.Text = Main.main.myListCAT21[markers[pos].indexList].latitude == -1 ? "Latitude: N/A" : "Latitude: " + Math.Round(Main.main.myListCAT21[markers[pos].indexList].latitude, 4) + " º N";
                    LNGlabel.Text = Main.main.myListCAT21[markers[pos].indexList].latitude == -1 ? "Longitude: N/A" : "Longitude: " + Math.Round(Main.main.myListCAT21[markers[pos].indexList].longitude, 4) + " º N";
                    Hlabel.Text = Main.main.myListCAT21[markers[pos].indexList].geometricHeight == null ? "Height: N/A" : "Height : " + Main.main.myListCAT21[markers[pos].indexList].geometricHeight + " ft";
                    trackNumberlabel.Text = Main.main.myListCAT21[markers[pos].indexList].trackNumber == 0 ? "Track Number: N/A" : "Track Number:: " + Main.main.myListCAT21[markers[pos].indexList].trackNumber;



                    break;
            }
            if (RoutecheckBox.Checked == true)
            {

                createRoutes(markers[pos].id,markers[pos].ins, Color.Black);

            }
        }

        private void exportToKMLbutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "KML|*.kml" };
            StringBuilder kmlfile = new StringBuilder();

            if (sfd.ShowDialog() == DialogResult.OK)
            {

            
                kmlfile.AppendLine("<?xml version='1.0' encoding='UTF-8'?>");
                kmlfile.AppendLine("<kml xmlns='http://www.opengis.net/kml/2.2'>");
                kmlfile.AppendLine("<Document>");

                if (InscCheckedListBox.GetItemChecked(0) == true)
                {

                    List<marker> SMR = markers.FindAll(p => p.ins == "SMR" && p.Position.Lat!= 41.29561833 && p.Position.Lng!= 2.095114167);

                    while (SMR.Count != 0)
                    {
                        string id = SMR[0].id;

                        kmlfile.AppendLine("<Placemark>");
                        kmlfile.AppendLine("<Style id='yellowLineGreenPoly'>");
                        kmlfile.AppendLine("<LineStyle>");
                        kmlfile.AppendLine("<color>ff00ffff</color>"); // YELLOW
                        kmlfile.AppendLine("<width>3</width>");
                        kmlfile.AppendLine("</LineStyle>"); 
                        kmlfile.AppendLine("<PolyStyle>");
                        kmlfile.AppendLine("<color>ff00ffff</color>"); 
                        kmlfile.AppendLine("</PolyStyle>");
                        kmlfile.AppendLine("</Style>");
                        kmlfile.AppendLine("<name>" + "SMR" + "</name>");
                        kmlfile.AppendLine("<description>" + "Time: " + TimeSpan.FromSeconds(SMR[0].time).ToString(@"hh\:mm\:ss")+" Track Number: " + id +  "</description>");
                        kmlfile.AppendLine("<styleUrl>#yellowLineGreenPoly</styleUrl>");
                        kmlfile.AppendLine("<LineString>");
                        kmlfile.AppendLine("<coordinates>");

                        List<marker> allMyId = SMR.FindAll(p => p.id == id );

                        for (int i = 0; i < allMyId.Count; i++)
                        {

                                kmlfile.AppendLine(Convert.ToString(allMyId[i].Position.Lng).Replace(",", ".") + "," + Convert.ToString(allMyId[i].Position.Lat).Replace(",", "."));
                            
                            
                        }

                        kmlfile.AppendLine("</coordinates>");
                        kmlfile.AppendLine("</LineString>");
                        kmlfile.AppendLine("</Placemark>");

                        SMR.RemoveAll(p => p.id == id);
                    }


                }

                if (InscCheckedListBox.GetItemChecked(1) == true)
                {

                    List<marker> MLAT = markers.FindAll(p => p.ins == "MLAT");

                    while (MLAT.Count != 0)
                    {
                        string id = MLAT[0].id;
                        string trackNumber = Convert.ToString(Main.main.myListCAT10[MLAT[0].indexList].trackNumber);

                        kmlfile.AppendLine("<Placemark>");
                        kmlfile.AppendLine("<Style id='yellowLineGreenPoly'>");
                        kmlfile.AppendLine("<LineStyle>");
                        kmlfile.AppendLine("<color>ff0000ff</color>"); // RED
                        kmlfile.AppendLine("<width>3</width>");
                        kmlfile.AppendLine("</LineStyle>"); 
                        kmlfile.AppendLine("<PolyStyle>");
                        kmlfile.AppendLine("<color>ff0000ff</color>"); 
                        kmlfile.AppendLine("</PolyStyle>");
                        kmlfile.AppendLine("</Style>");
                        kmlfile.AppendLine("<name>" + "MLAT" + "</name>");
                        kmlfile.AppendLine("<description>" + "Time: " + TimeSpan.FromSeconds(MLAT[0].time).ToString(@"hh\:mm\:ss") + " Target Address: " + id + "</description>");
                        kmlfile.AppendLine("<styleUrl>#yellowLineGreenPoly</styleUrl>");
                        kmlfile.AppendLine("<LineString>");
                        kmlfile.AppendLine("<coordinates>");

                        List<marker> allMyId = MLAT.FindAll(p => p.id == id &&  Convert.ToString(Main.main.myListCAT10[p.indexList].trackNumber)== trackNumber);

                        for (int i = 0; i < allMyId.Count; i++)
                        {
                                kmlfile.AppendLine(Convert.ToString(allMyId[i].Position.Lng).Replace(",", ".") + "," + Convert.ToString(allMyId[i].Position.Lat).Replace(",", "."));
                            
                        }

                        kmlfile.AppendLine("</coordinates>");
                        kmlfile.AppendLine("</LineString>");
                        kmlfile.AppendLine("</Placemark>");

                        MLAT.RemoveAll(p => p.id == id && Convert.ToString(Main.main.myListCAT10[p.indexList].trackNumber) == trackNumber);
                    }
                }

                if (InscCheckedListBox.GetItemChecked(2) == true) 
                {
                    List<marker> ADSB = markers.FindAll(p => p.ins == "ADSB");

                    while (ADSB.Count != 0)
                    {

                        string id = ADSB[0].id;
                        string trackNumber = Convert.ToString(Main.main.myListCAT21[ADSB[0].indexList].trackNumber);


                        kmlfile.AppendLine("<Placemark>");
                        kmlfile.AppendLine("<Style id='yellowLineGreenPoly'>");
                        kmlfile.AppendLine("<LineStyle>");
                        kmlfile.AppendLine("<color>ff00ff00</color>"); // GREEN
                        kmlfile.AppendLine("<width>3</width>");
                        kmlfile.AppendLine("</LineStyle>");
                        kmlfile.AppendLine("<PolyStyle>");
                        kmlfile.AppendLine("<color>ff00ff00</color>");
                        kmlfile.AppendLine("</PolyStyle>");
                        kmlfile.AppendLine("</Style>");
                        kmlfile.AppendLine("<name>" + "ADSB" + "</name>");
                        kmlfile.AppendLine("<description>" + "Time: " + TimeSpan.FromSeconds(ADSB[0].time).ToString(@"hh\:mm\:ss") + " Target Address: " + id + "</description>");
                        kmlfile.AppendLine("<styleUrl>#yellowLineGreenPoly</styleUrl>");
                        kmlfile.AppendLine("<LineString>");
                        kmlfile.AppendLine("<coordinates>");

                        List<marker> allMyId = ADSB.FindAll(p => p.id == id && Convert.ToString(Main.main.myListCAT21[p.indexList].trackNumber) == trackNumber);

                        for (int i = 0; i < allMyId.Count; i++)
                        {
                           kmlfile.AppendLine(Convert.ToString(allMyId[i].Position.Lng).Replace(",", ".") + "," + Convert.ToString(allMyId[i].Position.Lat).Replace(",", "."));
                        }

                        kmlfile.AppendLine("</coordinates>");
                        kmlfile.AppendLine("</LineString>");
                        kmlfile.AppendLine("</Placemark>");

                        ADSB.RemoveAll(p => p.id == id && Convert.ToString(Main.main.myListCAT21[p.indexList].trackNumber) == trackNumber);
                    }
                }


                kmlfile.AppendLine("</Document>");
                kmlfile.AppendLine("</kml>");
                File.WriteAllText(sfd.FileName, kmlfile.ToString());
                MessageBox.Show(".kml created sucessfully!");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using System.Windows;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;
using DECODEclass;

namespace DECODEclass
{
    public class marker : GMapMarker //Uso de Herencia
    {

        public double time { get; set; }

        public string CAT { get; set; }
        public int indexList { get; set; }
        

        public string ins { get; set; }

        public PointLatLng point { get; set; }

        public static marker myMarker(double t, string c, int i, int SIC, double pos1, double pos2, string ta)
        {
            ///get point

            return new marker(point,t,c,i,SIC,pos1,pos2,ta);
        }


        private marker(PointLatLng point,double t, string c, int i,int SIC,double pos1,double pos2, string ta) : base(point)
        {
            this.time = t;
            this.CAT = c;
            this.indexList = i;
            
            switch (CAT)
            {
                case "10":
                    switch (SIC)
                    {
                        case 7: //SMR
                            
                            this.ins = "SMR"; //Coordinates Radar SMR
                            
                            point = Convert2LatLng(Convert.ToInt32(pos1), Convert.ToInt32(pos2), new CoordinatesWGS84(41.29561833 * Math.PI/180.0, 2.095114167 * Math.PI/180));
                            //this.mkr=new GMarkerGoogle(point, GMarkerGoogleType.yellow_dot);
                            break;
                        case 107:
                            this.ins = "MLAT"; //Coordinates Radar MLAT
                            point = Convert2LatLng(Convert.ToInt32(pos1), Convert.ToInt32(pos2), new CoordinatesWGS84(41.29706278*Math.PI/180.0, 2.078447222*Math.PI/180));
                            //this.mkr = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                           
                            //this.mkr.Tag = ta;
                            break;
                    }
                    
                    break;
                case "21":
                    this.ins = "ADSB";
                    point = new PointLatLng(pos1, pos2);
                    //this.mkr = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                    //this.mkr.Tag = ta;
                    break;
            }
        }

        PointLatLng Convert2LatLng(int x, int y, CoordinatesWGS84 posR)
        {
            CoordinatesXYZ xy = new CoordinatesXYZ(x, y, 0.0);
            GeoUtils f = new GeoUtils();
            CoordinatesXYZ geocentric = f.change_radar_cartesian2geocentric(posR, xy);
            CoordinatesWGS84 latlng = f.change_geocentric2geodesic(geocentric);
            PointLatLng pos = new PointLatLng(latlng.Lat * 180 / Math.PI, latlng.Lon * 180 / Math.PI);
            return pos;
        }

    }
}

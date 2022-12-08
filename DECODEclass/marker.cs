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
    public class marker : GMarkerGoogle //Uso de Herencia
    {
        
        public string id { get; set; }
       
        public double time { get; set; }

        public string CAT { get; set; }
        public int indexList { get; set; }
        

        public string ins { get; set; }

        public int SIC { get; set; }


        public static marker myMarker(double t, string c, int i, int SIC, double pos1, double pos2, string id)
        {
            GMarkerGoogleType type=new GMarkerGoogleType();
            PointLatLng point = new PointLatLng() ;
            switch (c)
            {
                case "10":
                    switch (SIC)
                    {
                        case 7: //SMR


                            type = GMarkerGoogleType.yellow_dot;
                            point = Convert2LatLng(Convert.ToInt32(pos1), Convert.ToInt32(pos2), new CoordinatesWGS84(41.29561833 * Math.PI / 180.0, 2.095114167 * Math.PI / 180));
                            //this.mkr=new GMarkerGoogle(point, GMarkerGoogleType.yellow_dot);
                            break;
                        case 107:
                            type = GMarkerGoogleType.red_dot;
                            point = Convert2LatLng(Convert.ToInt32(pos1), Convert.ToInt32(pos2), new CoordinatesWGS84(41.29706278 * Math.PI / 180.0, 2.078447222 * Math.PI / 180));
                            //this.mkr = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                            //this.mkr.Tag = ta;
                            break;
                    }

                    break;
                case "21":
                    type = GMarkerGoogleType.green_dot;
                    point = new PointLatLng(pos1, pos2);
                    //this.mkr = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                    //this.mkr.Tag = ta;
                    break;
            }

            return new marker(type,point,t,c,i,SIC,id);
        }



        private marker(GMarkerGoogleType type,PointLatLng point,double t, string c, int i,int sic, string id) : base(point,type)
        {
            this.time = t;
            this.CAT = c;
            this.indexList = i;
            this.SIC = sic;
            this.id = id;
            
            switch (CAT)
            {
                case "10":
                    switch (SIC)
                    {
                        case 7: //SMR
                            
                            this.ins = "SMR"; //Coordinates Radar SMR

                            
                            break;
                        case 107:
                            this.ins = "MLAT"; //Coordinates Radar MLAT
                           

                            break;
                    }
                    
                    break;
                case "21":
                    this.ins = "ADSB";
                    

                    break;
            }
        }

        static PointLatLng Convert2LatLng(int x, int y, CoordinatesWGS84 posR)
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

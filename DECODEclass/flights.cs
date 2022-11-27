using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;

namespace DECODEclass
{
    public class flights
    {
       public string CallSign { get; set; } 
       public string SIC { get; set; }
       public string targetIdentification { get; set; }
       public string FlightLevel { get; set; }
       public string Time { get; set; }

       public PointLatLng pos { get; set; }

       public Bitmap im;



        public flights(PointLatLng pos,string CS, string sic,string ti, string fl, string t)
        {
            this.CallSign = CS;
            this.SIC=sic;
            this.targetIdentification = ti;
            this.FlightLevel = fl;
            this.Time = t;
        }


    }
}

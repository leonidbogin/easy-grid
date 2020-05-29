using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public class Point
    {
        public double lat;
        public double lon;
        public string name;

        public Point(double lat, double lon)
        {
            this.lat = lat;
            this.lon = lon;
        }

        public Point(Point point)
        {
            this.lat = point.lat;
            this.lon = point.lon;
        }

        public Point()
        {
            
        }
    }
}

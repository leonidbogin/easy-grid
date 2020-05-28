using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public class Coordinates
    {
        private int zoom;
        private Point[] points;

        public Coordinates()
        {
            points = new Point[4];
            for (int i = 0; i < points.Length; i++)
                points[i] = new Point();
        }

        public int GetZoom()
        {
            return zoom;
        }

        public Point[] GetPoints()
        {
            return points;
        }

        public Point GetPoints(int index)
        {
            return points[index];
        }

        public bool SetZoom(string str)
        {
            return int.TryParse(str, out zoom);
        }

        public bool SetPointLat(string str, int index)
        {
            return double.TryParse(str, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out points[index].lat);
        }

        public bool SetPointLon(string str, int index)
        {
            return double.TryParse(str, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out points[index].lon);
        }

        public static bool Equals(Coordinates c1, Coordinates c2)
        {
            if (c1.zoom != c2.zoom) return false;
            for (int i = 0; i < c1.GetPoints().Length; i++)
                if (c1.GetPoints(i).Equals(c2.GetPoints(i)))
                    return false;
            return true;
        }
    }
}

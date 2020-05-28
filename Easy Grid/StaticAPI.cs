using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public static class StaticAPI
    {
        private static readonly System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.InvariantCulture;

        public static string GetURL(Coordinates coordinates)
        {   
            Point[] points = coordinates.GetPoints();
            Point center = coordinates.GetCenter();

            string line = points[0].lon.ToString(cultureInfo) + "," + points[0].lat.ToString(cultureInfo);
            for (int i = 1; i < coordinates.GetPoints().Length; i++) 
            { 
                line += "," + points[i].lon.ToString(cultureInfo) + "," + points[i].lat.ToString(cultureInfo);
            }
            line += "," + points[0].lon.ToString(cultureInfo) + "," + points[0].lat.ToString(cultureInfo);

            string url = "https://static-maps.yandex.ru/1.x/?ll={0},{1}&size=565,340&z={2}&l=sat,skl&lang=ru_RU&pl=c:ff0000FF,w:2,{3}";
            return String.Format(url, 
                center.lon.ToString(cultureInfo),
                center.lat.ToString(cultureInfo),
                (coordinates.GetZoom() - 2).ToString(),
                line);
        }
    }
}

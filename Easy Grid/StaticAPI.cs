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

        public static string GetURL(Coordinates coordinates, List<Point> line)
        {   
            Point[] points = coordinates.GetPoints();



            //string border = points[0].lon.ToString(cultureInfo) + "," + points[0].lat.ToString(cultureInfo);
            //for (int i = 1; i < coordinates.GetPoints().Length; i++) 
            //{ 
            //    border += "," + points[i].lon.ToString(cultureInfo) + "," + points[i].lat.ToString(cultureInfo);
            //}
            //border += "," + points[0].lon.ToString(cultureInfo) + "," + points[0].lat.ToString(cultureInfo);

            int vertex = 0;
            string lineStr = line[0].lon.ToString(cultureInfo) + "," + line[0].lat.ToString(cultureInfo);
            for (int i = 1; i < line.Count; i++)
            {
                vertex++;
                if (vertex > 100)
                {
                    vertex = 0;
                    lineStr += "&pl=c:ff0000FF,w:2,";
                }
                lineStr += "," + line[i].lon.ToString(cultureInfo) + "," + line[i].lat.ToString(cultureInfo);
            }
            


            string url = "https://static-maps.yandex.ru/1.x/?size=565,340&l=sat,skl&lang=ru_RU&pl=c:ff0000FF,w:2,{0}";
            return String.Format(url, lineStr);
        }
    }
}

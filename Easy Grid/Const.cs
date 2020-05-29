using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public static class CONST
    {
        public static class LastSelection
        {
            public static string FileName = "LastSelection.hlg";
            public static string Zoom = "Zoom=";
            public static string Lat_1 = "PointLat_1=";
            public static string Lon_1 = "PointLon_1=";
            public static string Lat_2 = "PointLat_2=";
            public static string Lon_2 = "PointLon_2=";
            public static string Lat_3 = "PointLat_3=";
            public static string Lon_3 = "PointLon_3=";
            public static string Lat_4 = "PointLat_4=";
            public static string Lon_4 = "PointLon_4=";
            public static string Lat_5 = "PointLat_5=";
            public static string Lon_5 = "PointLon_5=";
        }
        
        public static class Error
        {
            public static string LastSelection = "Возможно проблема в заключается в том,\nчто программа не расположена в директории SAS Planet.\nЕсли так, закройте программу и переместите её в папку с программой SAS Planet.";
            public static string LastSelectionHeader = "Ошибка копирования из файла LastSelection.hlg";
        }

        public static class Degress
        {
            public static double Rad = Math.PI / 180.0;
            public static double Down = 270.0 * Rad;
            public static double Right = 0;
        }

        public static class Planet
        {
            public static double Lat = 40035000;
            public static double Lon = 40075000;
        }
    }
}

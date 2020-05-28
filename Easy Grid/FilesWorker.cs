using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public static class FilesWorker
    {
        public static Coordinates GetCoordinates()
        {
            Coordinates coordinates = new Coordinates();
            if (File.Exists(CONST.LastSelection.FileName)) 
            {
                FileStream file = new FileStream(CONST.LastSelection.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                string buff;

                try
                {
                    while (!reader.EndOfStream)
                    {
                        buff = reader.ReadLine();
                        if (buff.IndexOf(CONST.LastSelection.Zoom) == 0)
                            coordinates.SetZoom(buff.Substring(CONST.LastSelection.Zoom.Length));
                        else if (buff.IndexOf(CONST.LastSelection.Lat_1) == 0)
                            coordinates.SetPointLat(buff.Substring(CONST.LastSelection.Lat_1.Length), 0);
                        else if (buff.IndexOf(CONST.LastSelection.Lat_2) == 0)
                            coordinates.SetPointLat(buff.Substring(CONST.LastSelection.Lat_2.Length), 1);
                        else if (buff.IndexOf(CONST.LastSelection.Lat_3) == 0)
                            coordinates.SetPointLat(buff.Substring(CONST.LastSelection.Lat_3.Length), 2);
                        else if (buff.IndexOf(CONST.LastSelection.Lat_4) == 0)
                            coordinates.SetPointLat(buff.Substring(CONST.LastSelection.Lat_4.Length), 3);
                        else if (buff.IndexOf(CONST.LastSelection.Lon_1) == 0)
                            coordinates.SetPointLon(buff.Substring(CONST.LastSelection.Lon_1.Length), 0);
                        else if (buff.IndexOf(CONST.LastSelection.Lon_2) == 0)
                            coordinates.SetPointLon(buff.Substring(CONST.LastSelection.Lon_2.Length), 1);
                        else if (buff.IndexOf(CONST.LastSelection.Lon_3) == 0)
                            coordinates.SetPointLon(buff.Substring(CONST.LastSelection.Lon_3.Length), 2);
                        else if (buff.IndexOf(CONST.LastSelection.Lon_4) == 0)
                            coordinates.SetPointLon(buff.Substring(CONST.LastSelection.Lon_4.Length), 3);
                    }
                }
                catch
                {
                    coordinates = null;
                }
                finally
                {
                    reader.Close();
                }

                return coordinates;
            } 
            else coordinates = null;

            return coordinates;
        }
    }
}

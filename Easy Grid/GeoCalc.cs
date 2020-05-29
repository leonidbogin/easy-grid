using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public static class GeoCalc
    {
        private static Point planetParam = new Point(CONST.Planet.Lat, CONST.Planet.Lon);

        public static Grid GetGrid(Coordinates coordinates, double stepSize)
        {
            Point cursor = new Point(coordinates.GetPoint(0));
            List<Point> line = new List<Point>();
            line.Add(cursor);
      
            Point step;
            List<Point> firstLineX = new List<Point>();
            do
            {
                firstLineX.Add(cursor);
                step = Step(cursor, stepSize, CONST.Degress.Right);
                cursor = new Point(cursor.lat + step.lat, cursor.lon + step.lon);
            } while (cursor.lon - (step.lon / 2) < coordinates.GetPoint(1).lon);

            line.Add(firstLineX.Last());
            cursor = new Point(coordinates.GetPoint(0));
            line.Add(coordinates.GetPoint(0));

            List<Point> firstLineY = new List<Point>();
            do
            {
                firstLineY.Add(cursor);
                step = Step(cursor, stepSize, CONST.Degress.Down);
                cursor = new Point(cursor.lat + step.lat, cursor.lon + step.lon);
            } while (cursor.lat - (step.lat / 2) > coordinates.GetPoint(3).lat);

            int stepX = firstLineX.Count;
            int stepY = firstLineY.Count;

            Grid grid = new Grid(new Point[stepX, stepY], stepX, stepY);

            for (int i = 0; i < stepX; i++)
                grid.points[i, 0] = firstLineX[i];

            for (int j = 1; j < stepY; j++)
                grid.points[0, j] = firstLineY[j];

            firstLineX.Clear();
            firstLineY.Clear();
            
            for (int j = 1; j < stepY; j++)
            {
                cursor = new Point(grid.points[0, j]);
                
                line.Add(grid.points[0, j]); 
                for (int i = 1; i < stepX; i++)
                {
                    step = Step(cursor, stepSize, CONST.Degress.Right);
                    cursor = new Point(cursor.lat + step.lat, cursor.lon + step.lon);
                    grid.points[i, j] = new Point(cursor);
                }
                line.Add(grid.points[stepX-1, j]);
                if (j < stepY - 1) line.Add(grid.points[0, j]);
            }

            line.Add(grid.points[stepX-1, 0]);
            line.Add(grid.points[stepX - 1, stepY - 1]);
            for (int i = stepX-2; i > 0; i--)
            {
                line.Add(grid.points[i, stepY - 1]);
                line.Add(grid.points[i, 0]);
                line.Add(grid.points[i, stepY - 1]);
            }

            grid.line = line;
            return grid;
        }

        public static Point Step(Point point, double stepSize, double angle)
        {
            double lat = (360.0 * Math.Sin(angle) * stepSize) / planetParam.lat;
            double lon = (360.0 * Math.Cos(angle) * stepSize) / (planetParam.lon * Math.Cos(point.lat * CONST.Degress.Rad));
            return new Point(lat, lon);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Grid
{
    public class Grid
    {
        public Point[,] points;
        public List<Point> line;
        public int stepX = 0;
        public int stepY = 0;

        public Grid(Point[,] points, int stepX, int stepY)
        {
            this.points = points;
            this.stepX = stepX;
            this.stepY = stepY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionCircles
{
    class Circle
    {
        public int radius { get; set; }
        public int centerX { get; set; }
        public int centerY { get; set; }

        public Circle()
        {

        }

        public Circle(int CenterX,int CenterY, int Radius)
        {
            this.centerX = CenterX;
            this.centerY = CenterY;
            this.radius = Radius;
        }
    }
}

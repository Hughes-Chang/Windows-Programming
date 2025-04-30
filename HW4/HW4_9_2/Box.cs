using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_9_2
{
    public class Box
    {
        public double Width;
        public double Height;
        public double Length;

        public Box(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public double Volume()
        {
            return Width * Height * Length;
        }

        public double Area()
        {
            return 2 * (Width * Height + Height * Length + Width * Length);
        }
    }
}

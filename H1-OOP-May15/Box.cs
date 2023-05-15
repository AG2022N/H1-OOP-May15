using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_May15
{
    public class Box
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        enum BoxType
        {
            smallBox,
            mediumBox,
            largeBox
        }
        public Box(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
    }
}
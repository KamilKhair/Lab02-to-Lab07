using System;

namespace ShapeLib
{
    public class Circle : Ellipse
    {
        public Circle(double radius) : base(radius, radius)
        {
            Radius = radius;
        }
        public Circle(double radius, ConsoleColor c) : base(radius, radius, c)
        {
            Radius = radius;
        }
        protected double Radius { get; }
    }
}

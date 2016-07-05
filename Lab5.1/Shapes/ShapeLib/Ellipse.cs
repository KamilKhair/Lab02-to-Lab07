using System;
using System.Globalization;

namespace ShapeLib
{
    public class Ellipse : Shape
    {
        public override double Area { get; }

        protected double Radius1 { get; }
        protected double Radius2 { get; }

        public Ellipse(double radius1, double radius2)
        {
            Radius1 = radius1;
            Radius2 = radius2;
            Area = Math.PI * Radius1 * Radius2;
        }

        public Ellipse(double radius1, double radius2, ConsoleColor c) : base(c)
        {
            Radius1 = radius1;
            Radius2 = radius2;
            Area = Math.PI * Radius1 * Radius2;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Radius1 = " + Radius1.ToString(CultureInfo.CurrentCulture) + " Radius2 = " + Radius2.ToString(CultureInfo.CurrentCulture));
        }
    }
}
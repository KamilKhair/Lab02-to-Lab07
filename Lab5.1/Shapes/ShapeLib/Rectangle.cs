using System;
using System.Globalization;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public override double Area { get; }

        public double Width { get; }
        public double Hieght { get; }

        public Rectangle(double width, double hieght)
        {
            Width = width;
            Hieght = hieght;
            Area = hieght * Width * 0.5;
        }

        public Rectangle(double width, double hieght, ConsoleColor c) : base(c)
        {
            Width = width;
            Hieght = hieght;
            Area = hieght * Width * 0.5;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Width = " + Width.ToString(CultureInfo.CurrentCulture) + " Hieght = " + Hieght.ToString(CultureInfo.CurrentCulture));
        }
    }
}
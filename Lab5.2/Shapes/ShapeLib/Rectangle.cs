using System;
using System.Globalization;
using System.Text;

namespace ShapeLib
{
    public class Rectangle : Shape, IPersist, IComparable
    {
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

        public override double Area { get; }

        public double Width { get; }
        public double Hieght { get; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Width = " + Width.ToString(CultureInfo.CurrentCulture) + " Hieght = " + Hieght.ToString(CultureInfo.CurrentCulture));
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine(Width.ToString(CultureInfo.CurrentCulture));
            sb.AppendLine(Hieght.ToString(CultureInfo.InvariantCulture));
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            var otherRectangle = obj as Rectangle;
            if (Width == otherRectangle.Width)
            {
                return Hieght.CompareTo(otherRectangle.Hieght);
            }
            else
            {
                return Width.CompareTo(otherRectangle.Width);
            }
        }
    }
}
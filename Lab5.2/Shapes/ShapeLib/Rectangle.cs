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
            Area = hieght * Width;
        }

        public Rectangle(double width, double hieght, ConsoleColor c) : base(c)
        {
            Width = width;
            Hieght = hieght;
            Area = hieght * Width;
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
            sb.AppendLine(Hieght.ToString(CultureInfo.CurrentCulture));
        }

        /**
         * Partially Buggy implementation of method
         * Consider the expected values according to interface documentation
         * https://msdn.microsoft.com/en-us/library/system.icomparable(v=vs.110).aspx
         */
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;//throw new ArgumentNullException(nameof(obj));
            }
            var otherRectangle = obj as Shape;
            if (otherRectangle != null)
                return Area.CompareTo(otherRectangle.Area);
            throw new ArgumentException("Object is not a Shape");//Very good!
        }
    }
}
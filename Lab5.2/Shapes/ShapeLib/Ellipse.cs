using System;
using System.Globalization;
using System.Text;

namespace ShapeLib
{
    public class Ellipse : Shape, IPersist, IComparable
    {
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

        public override double Area { get; }

        protected double Radius1 { get; }
        protected double Radius2 { get; }
        public void Write(StringBuilder sb)
        {
            sb.AppendLine(Radius1.ToString(CultureInfo.CurrentCulture));
            sb.AppendLine(Radius2.ToString(CultureInfo.InvariantCulture));
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            var otherEllipse = obj as Ellipse;
            if (Radius1 == otherEllipse.Radius1)
            {
                return Radius2.CompareTo(otherEllipse.Radius2);
            }
            else
            {
                return Radius1.CompareTo(otherEllipse.Radius1);
            }
        }
    }
}
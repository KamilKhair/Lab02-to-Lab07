using System;
using System.Globalization;

namespace ShapeLib
{
    public abstract class Shape
    {
        protected Shape()
        {
            Color = ConsoleColor.White;
        }
        protected Shape(ConsoleColor color)
        {
            Color = color;
        }

        private ConsoleColor Color { get; }

        public abstract double Area { get; }

        public virtual void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine("I'm a " + ToString());
        }
    }

    public class Rectangle : Shape
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
    }

    public class Ellipse : Shape
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
    }

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

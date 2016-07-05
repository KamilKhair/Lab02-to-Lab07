using System;

namespace ShapeLib
{
    public abstract class Shape
    {
        private ConsoleColor Color { get; }

        public abstract double Area { get; }

        protected Shape()
        {
            Color = ConsoleColor.White;
        }
        protected Shape(ConsoleColor color)
        {
            Color = color;
        }

        public virtual void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine("I'm a " + ToString());
        }
    }
}
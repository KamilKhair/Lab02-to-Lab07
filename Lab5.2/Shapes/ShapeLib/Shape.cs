using System;

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
}
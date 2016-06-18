using System;
using System.Collections.Generic;
using ShapeLib;

namespace ShapesApp
{
    internal class ShapeManager
    {
        public ShapeManager()
        {
            Shapes = new List<Shape>();
        }

        public List<Shape> Shapes { get; }

        public Shape this[int i] => Shapes[i];

        private int Count => Shapes.Count;

        public void Add(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void DisplayAll()
        {
            //foreach (var sh in Shapes)
            //{

            //    sh.Display();
            //    Console.WriteLine("The area is: " + sh.Area);
            //}

            for (int i = 0; i < Count; ++i)
            {
                Shapes[i].Display();
                Console.WriteLine("The area is: " + Shapes[i].Area);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            ShapeManager shm = new ShapeManager();
            shm.Add(new Rectangle(5, 4));
            shm.Add(new Ellipse(5, 10, ConsoleColor.Cyan));
            shm.Add(new Circle(5, ConsoleColor.Yellow));

            shm.DisplayAll();
        }
    }
}

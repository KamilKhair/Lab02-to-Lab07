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

            for (var i = 0; i < Count; ++i)
            {
                Shapes[i].Display();
                Console.WriteLine("The area is: " + Shapes[i].Area);
            }
        }
    }
}
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

        /**
         * You are breaking the encapsulation principle by making this property public
         * Technically, you were supposed to use ArrayList, but this is indeed better and is a common practice to use List<T>
         */
        public List<Shape> Shapes { get; }

        public Shape this[int i] => Shapes[i];

        private int Count => Shapes.Count;

        public void Add(Shape shape)//Input validation!
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
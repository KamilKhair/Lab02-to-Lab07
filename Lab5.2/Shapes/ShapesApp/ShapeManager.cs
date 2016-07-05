using System;
using System.Collections.Generic;
using System.Text;
using ShapeLib;

namespace ShapesApp
{
    public class ShapeManager
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

        public void Save(StringBuilder sb)
        {
            for (var i = 0; i < Count; ++i)
            {
                var persist = Shapes[i] as IPersist;

                persist?.Write(sb);

                //if (null != persist)
                //{
                //    persist.Write(sb);
                //}
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
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

    internal class Program
    {
        internal static void Main()
        {
            var shm = new ShapeManager();
            shm.Add(new Rectangle(8, 9));
            shm.Add(new Rectangle(5, 4));
            //shm.Add(new Ellipse(5, 10, ConsoleColor.Cyan));
            //shm.Add(new Circle(5, ConsoleColor.Yellow));

            shm.DisplayAll();

            Console.WriteLine();

            Console.WriteLine("Before sorting");

            var sb = new StringBuilder();
            shm.Save(sb);
            Console.WriteLine(sb.ToString());

            Console.WriteLine();


            shm.Shapes.Sort();

            Console.WriteLine("After sorting");

            var sb2 = new StringBuilder();
            shm.Save(sb2);
            Console.WriteLine(sb2.ToString());
        }
    }
}

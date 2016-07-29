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

        /**
       
            Very good!

            Consider this implementation:

           foreach (var persistable in Shapes.OfType<IPersist>())
           {
              persistable.Write(st);
           }

       OfType will select only members which are assignable to an IPersist reference and return such a collection
       https://msdn.microsoft.com/en-us/library/bb360913(v=vs.110).aspx

       */
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
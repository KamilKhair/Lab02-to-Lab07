using System;
using System.Text;
using ShapeLib;

namespace ShapesApp
{
    internal class Program
    {
        internal static void Main()
        {
            var shm = new ShapeManager();
            shm.Add(new Rectangle(8, 9, ConsoleColor.Blue));
            shm.Add(new Rectangle(5, 4));
            shm.Add(new Ellipse(8, 4, ConsoleColor.Yellow));
            shm.Add(new Circle(2, ConsoleColor.Magenta));

            shm.DisplayAll();

            Console.WriteLine();

            Console.WriteLine("Before sorting");

            var sb = new StringBuilder();
            shm.Save(sb);
            Console.WriteLine(sb.ToString());

            Console.WriteLine();

            try
            {
                shm.Shapes.Sort();
            }
            catch (Exception)
            {
                Console.WriteLine("ArgumentException: Object is not a Shape");
            }

            Console.WriteLine("After sorting");

            var sb2 = new StringBuilder();
            shm.Save(sb2);
            Console.WriteLine(sb2.ToString());
        }
    }
}

using System;
using ShapeLib;

namespace ShapesApp
{
    internal class Program
    {
        public static void Main()
        {
            var shm = new ShapeManager();
            shm.Add(new Rectangle(5, 4));
            shm.Add(new Ellipse(5, 10, ConsoleColor.Cyan));
            shm.Add(new Circle(5, ConsoleColor.Yellow));

            shm.DisplayAll();
        }
    }
}

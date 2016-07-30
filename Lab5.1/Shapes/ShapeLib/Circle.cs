using System;

namespace ShapeLib
{
    public class Circle : Ellipse
    {
        protected double Radius { get; }

        public Circle(double radius) : base(radius, radius)
        {
            Radius = radius;
        }
        public Circle(double radius, ConsoleColor c) : base(radius, radius, c)
        {
            Radius = radius;
        }

        /**
         * I think you missed the point by not implementing the Display method here
         * It presents a challenge which you noticed in advance (which is good) and solved by avoiding it altogether.
         * Which is one way to do face it
         * However, you will not always be so lucky..
         * Please implement Display in this class and think of a way to solve the problem it presents
         */
    }
}

using System;

namespace Lab1
{
    public class Blue
    {
        // Task1: Check if both numbers are positive
        public bool Task1(int a, int b)
        {
            return a > 0 && b > 0;
        }

        // Task2: Check if number is between 0 and 1 (exclusive)
        public bool Task2(double d)
        {
            return d > 0 && d < 1;
        }

        // Task3: Check if both numbers are odd
        public bool Task3(int a, int b)
        {
            return a % 2 != 0 && b % 2 != 0;
        }

        // Task4: Return the maximum of three numbers
        public double Task4(double d, double f, double g)
        {
            return Math.Max(d, Math.Max(f, g));
        }

        // Task5: Return |x| if x < 0, otherwise return x^2
        public double Task5(double x)
        {
            return x < 0 ? Math.Abs(x) : x * x;
        }

        // Task6: Check if a circle with area circleS can fit inside a square with area squareS
        public bool Task6(double circleS, double squareS)
        {
            // Circle radius
            double r = Math.Sqrt(circleS / Math.PI);
            // Square side
            double side = Math.Sqrt(squareS);

            // Circle fits inside square if diameter <= side
            return 2 * r <= side;
        }

        // Task7: Return the smaller of two numbers
        public double Task7(double d, double f)
        {
            return Math.Min(d, f);
        }

        // Task8: Check if triangle with sides a, b, c is valid
        public bool Task8(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}

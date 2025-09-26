using System;

namespace Lab1
{
    public class Blue
    {
        // 1. Check if both integers have the same sign
        public bool Task1(int a, int b)
        {
            return (a > 0 && b > 0) || (a < 0 && b < 0);
        }

        // 2. Check if a number has a fractional part
        public bool Task2(double d)
        {
            return d % 1 != 0;
        }

        // 3. Check if at least one of the numbers is divisible by 5
        public bool Task3(int a, int b)
        {
            return a % 5 == 0 || b % 5 == 0;
        }

        // 4. Return the number with the largest absolute value
        public double Task4(double d, double f, double g)
        {
            double max = d;
            if (Math.Abs(f) > Math.Abs(max)) max = f;
            if (Math.Abs(g) > Math.Abs(max)) max = g;
            return max;
        }

        // 5. Piecewise function:
        // y(x) = 0,   if x <= -1
        // y(x) = x+1, if -1 < x <= 0
        // y(x) = 1,   if x > 0
        public double Task5(double x)
        {
            if (x <= -1) return 0;
            else if (x <= 0) return x + 1;
            else return 1;
        }

        // 6. Check if a circle can fit inside a square by their areas
        public bool Task6(double circleS, double squareS)
        {
            double r = Math.Sqrt(circleS / Math.PI); // circle radius
            double side = Math.Sqrt(squareS);        // square side
            return 2 * r <= side;                    // circle fits if diameter <= side
        }

        // 7. Flowchart logic: return -1, 0 or 1
        public int Task7(double d, double f)
        {
            int answer = 0;

            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) answer = 1;
                else if (d < 0) answer = -1;
            }

            return answer;
        }

        // 8. King’s gold problem (simplified check):
        // Verify if gold coins can be divided evenly into 3 bags
        public bool Task8(int a, int b, int c)
        {
            int A = a / 2; // capacity of oldest son's bag
            int B = b / 2; // capacity of middle son's bag
            int C = c / 2; // capacity of youngest son's bag

            int total = A + B + C;
            return total % 3 == 0; // simple fairness check
        }
    }
}

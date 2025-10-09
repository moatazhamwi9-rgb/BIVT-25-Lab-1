using System;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a != 0 && b != 0)
            {
                if ((a > 0 && b > 0) || (a < 0 && b < 0))
                    answer = true;
            }
            // end

            return answer;
        }

        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d % 1) > 0.0001)
                answer = true;
            // end

            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
                answer = true;
            // end

            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double m = Math.Abs(d) >= Math.Abs(f) ? d : f;
            answer = Math.Abs(m) >= Math.Abs(g) ? m : g;
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if (x <= 0)
                answer = x + 1;
            else
                answer = 1;
            // end

            return answer;
        }

        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            if (2 * r <= a)
                answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) answer = -1;
            }
            else
            {
                if (f > 0) answer = 1;
            }
            // end

            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int s1 = a / 2;
            int s2 = b / 2;
            int s3 = c / 2;
            int total = s1 + s2 + s3;

            bool Check(int t)
            {
                if (t % 3 != 0) return false;
                int k = t / 3;
                if (k < 1) return false;
                if (k > a || k > b || k > c) return false;
                return true;
            }

            if (Check(total) || Check(total + 1))
                answer = true;
            // end

            return answer;
        }
    }
}

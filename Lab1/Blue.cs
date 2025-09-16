namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            if (b != 0 && a % b == 0)
                answer = true;

            return answer;
        }

        public bool Task2(double d)
        {
            bool answer = false;

            if (d > 1 || d < 0)
                answer = true;

            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (a == 0 || b == 0)
                answer = true;

            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer = Math.Max(d, Math.Max(f, g));
            return answer;
        }

        public double Task5(double x)
        {
            double answer = (x < 0) ? -x : 1;
            return answer;
        }

        public bool Task6(double circleS, double squareS)
        {
            bool answer = circleS <= squareS;
            return answer;
        }

        public double Task7(double d, double f)
        {
            if (d > f) return 1;
            else if (d < f) return -1;
            else return 0;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = (a + b > c) && (a + c > b) && (b + c > a);
            return answer;
        }
    }
 }

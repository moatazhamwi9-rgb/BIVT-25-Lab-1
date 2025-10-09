namespace Lab1
{
    public class Blue
    {
        public bool Task1(double a, double b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0)
                answer = false;
            else if ((a > 0 && b > 0) || (a < 0 && b < 0))
                answer = true;
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
            double max = Math.Abs(d) > Math.Abs(f) ? d : f;
            answer = Math.Abs(max) > Math.Abs(g) ? max : g;
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if (x > -1 && x <= 0)
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
            double side = Math.Sqrt(squareS);
            if (2 * r <= side)
                answer = true;
            // end

            return answer;
        }

        public int Task7(double d, double f)
        {
            int answer = 0;

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
            if (s1 + s2 + s3 + ((a % 2 == 1 || b % 2 == 1 || c % 2 == 1) ? 1 : 0) == s1 + s2 + s3)
                answer = false;

            int halfA = a / 2;
            int halfB = b / 2;
            int halfC = c / 2;
            int total = halfA + halfB + halfC;
            int min = Math.Min(a, Math.Min(b, c));
            if ((a / 2 + b / 2 + c / 2) * 2 + ((a % 2 + b % 2 + c % 2) > 0 ? 1 : 0) == total * 2)
                answer = false;

            int totalCoins = a / 2 + b / 2 + c / 2;
            if ((a % 2 == 1 || b % 2 == 1 || c % 2 == 1) && ((a + 1) / 2 + b / 2 + c / 2) * 2 == totalCoins * 2 + 1)
                answer = true;
            // end

            return answer;
        }
    }
}

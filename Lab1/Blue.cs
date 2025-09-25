namespace Lab1
{
    public class Blue
    {
        // 1. Определить, являются ли числа одного знака (0 – ни положит., ни отриц.)
        public bool Task1(int a, int b)
        {
            if (a == 0 || b == 0) return false;
            return (a > 0 && b > 0) || (a < 0 && b < 0);
        }

        // 2. Проверить, есть ли дробная часть (точность >= 0.0001)
        public bool Task2(double d)
        {
            double fractional = d - Math.Truncate(d);
            return Math.Abs(fractional) >= 0.0001;
        }

        // 3. Проверить, можно ли a разделить на b без остатка
        public bool Task3(int a, int b)
        {
            if (b == 0) return false;
            return a % b == 0;
        }

        // 4. Вернуть число с наибольшим модулем
        public double Task4(double d, double f, double g)
        {
            double max = d;
            if (Math.Abs(f) > Math.Abs(max)) max = f;
            if (Math.Abs(g) > Math.Abs(max)) max = g;
            return max;
        }

        // 5. Вычислить функцию:
        // y(x) = 0, если x <= -1
        // y(x) = 1, если -1 < x <= 0
        // y(x) = 7, если x > 0
        public double Task5(double x)
        {
            if (x <= -1) return 0;
            else if (x > -1 && x <= 0) return 1;
            else return 7;
        }

        // 6. Проверить, помещается ли круг в квадрат
        // circleS = площадь круга, squareS = площадь квадрата
        public bool Task6(double circleS, double squareS)
        {
            // Радиус круга
            double r = Math.Sqrt(circleS / Math.PI);
            // Сторона квадрата
            double a = Math.Sqrt(squareS);
            // Диаметр круга должен помещаться в квадрат
            return (2 * r) <= a;
        }

        // 7. Реализовать схему
        public double Task7(double d, double f)
        {
            int answer = 0;

            if (d > 0 && f > 0)
            {
                answer = 1;
            }
            else if (d < 0 && f < 0)
            {
                answer = -1;
            }
            else
            {
                answer = 0;
            }

            return answer;
        }

        // 8. Король делит монеты
        public bool Task8(int a, int b, int c)
        {
            // Половина монет (округление вниз)
            int ha = a / 2;
            int hb = b / 2;
            int hc = c / 2;

            // Проверяем, можно ли выровнять мешки
            int min = Math.Min(ha, Math.Min(hb, hc));
            int max = Math.Max(ha, Math.Max(hb, hc));

            // Если все равны сразу
            if (ha == hb && hb == hc && ha > 0) return true;

            // Король может добавить 1 монету младшему (hc)
            if ((ha == hb && hb == hc + 1 && hc + 1 > 0)) return true;

            return false;
        }
    }
 }

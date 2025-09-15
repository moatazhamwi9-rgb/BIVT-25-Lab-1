using System;

namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            return d > 0;
        }
        
        public bool Task2(int n)
        {
            return n % 2 == 0;
        }
        
        public int Task3(int a, int b)
        {
            return a > b ? a : b;
        }
        
        public double Task4(double d, double f)
        {
            return Math.Abs(d) < Math.Abs(f) ? d : f;
        }
        
        public double Task5(double x)
        {
            // Clamp x to [-1, 1] while keeping its sign
            return Math.Abs(x) > 1 ? Math.Sign(x) * 1 : x;
        }
        
        public bool Task6(double x, double y, double r)
        {
            // Check if point lies on the circle (within tolerance)
            return Math.Abs(x * x + y * y - r * r) <= 1e-6;
        }
        
        public bool Task7(int n)
        {
            return n > 3 && n % 2 == 0;
        }
        
        public bool Task8(double L, int T, int M)
        {
            return L <= 30 && T + M >= 5 && M % 2 == 0;
        }
    }
}
}


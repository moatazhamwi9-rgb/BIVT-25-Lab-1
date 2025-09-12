using System;

public class WhiteLeagueTasks
{
    // Task 1: Check if number is positive
    public static bool IsPositive(double d)
    {
        return d > 0;
    }

    // Task 2: Check if number is even
    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    // Task 3: Return the larger number
    public static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    // Task 4: Return the number with smaller absolute value
    public static double GetMinAbsolute(double d, double f)
    {
        double absD = Math.Abs(d);
        double absF = Math.Abs(f);
        
        return absD < absF ? d : f;
    }

    // Task 5: Calculate function y(x)
    public static double CalculateY(double x)
    {
        if (Math.Abs(x) > 1)
            return 1;
        else
            return x;
    }

    // Task 6: Check if point is on the circle
    public static bool IsOnCircle(double x, double y, double r)
    {
        double distanceSquared = x * x + y * y;
        double circleSquared = r * r;
        
        return Math.Abs(distanceSquared - circleSquared) <= 1e-6;
    }

    // Task 7: Implement the flowchart
    public static bool ProcessNumber(int n)
    {
        int s = n * n; // s = n²
        bool answer = false;

        if (s - n > Math.Pow(2, n)) // Check condition: s - n > 2^n
        {
            if (n % 2 == 0) // Check if n is even
            {
                answer = true;
            }
        }

        return answer;
    }

    // Task 8: Search for Captain Flint's treasure
    public static bool ShouldDock(double L, int T, int M)
    {
        // Calculate time to circle the island
        double timeToCircle = L / 10.0;
        
        // Check conditions
        bool timeCondition = timeToCircle <= 3;
        bool landmarksCondition = (T + M) >= 5;
        bool mountainsCondition = M % 2 == 0;
        
        return timeCondition && landmarksCondition && mountainsCondition;
    }

    // Main function to test all methods
    public static void Main(string[] args)
    {
        // Test Task 1
        Console.WriteLine($"Is 5.5 positive: {IsPositive(5.5)}");
        Console.WriteLine($"Is -2.3 positive: {IsPositive(-2.3)}");
        
        // Test Task 2
        Console.WriteLine($"Is 4 even: {IsEven(4)}");
        Console.WriteLine($"Is 7 even: {IsEven(7)}");
        
        // Test Task 3
        Console.WriteLine($"Max of 3 and 7: {GetMax(3, 7)}");
        Console.WriteLine($"Max of -2 and -5: {GetMax(-2, -5)}");
        
        // Test Task 4
        Console.WriteLine($"Min absolute of 3.5 and -2.1: {GetMinAbsolute(3.5, -2.1)}");
        Console.WriteLine($"Min absolute of -4.2 and 3.8: {GetMinAbsolute(-4.2, 3.8)}");
        
        // Test Task 5
        Console.WriteLine($"y(2.0) = {CalculateY(2.0)}");
        Console.WriteLine($"y(0.5) = {CalculateY(0.5)}");
        Console.WriteLine($"y(-0.8) = {CalculateY(-0.8)}");
        
        // Test Task 6
        Console.WriteLine($"Point (3,4) on circle r=5: {IsOnCircle(3, 4, 5)}");
        Console.WriteLine($"Point (1,1) on circle r=1.414214: {IsOnCircle(1, 1, 1.414214)}");
        
        // Test Task 7
        Console.WriteLine($"Process(2) = {ProcessNumber(2)}");
        Console.WriteLine($"Process(3) = {ProcessNumber(3)}");
        Console.WriteLine($"Process(4) = {ProcessNumber(4)}");
        
        // Test Task 8
        Console.WriteLine($"Should dock (L=30, T=3, M=2): {ShouldDock(30, 3, 2)}");
        Console.WriteLine($"Should dock (L=40, T=2, M=3): {ShouldDock(40, 2, 3)}");
        Console.WriteLine($"Should dock (L=25, T=1, M=4): {ShouldDock(25, 1, 4)}");
    }
}

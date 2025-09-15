public double Task5(double x)
{
    double answer = 0;

    // Clamp x to [-1, 1] while keeping its sign
    answer = Math.Abs(x) > 1 ? Math.Sign(x) * 1 : x;

    return answer;
}
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static bool IsPythagoreanTriplet(int a, int b, int c) => a*a + b*b == c*c;
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1; b < sum/2; b++)
            {
                int c = sum - a - b;
                if (IsPythagoreanTriplet(a, b, c))
                    yield return (a, b, c);
            }
        }
    }
}
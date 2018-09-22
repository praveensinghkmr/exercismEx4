using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(0, max).Where(f => multiples.Any(h => f % h == 0)).Sum();
    }
}
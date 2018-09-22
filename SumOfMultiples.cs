using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        for(int i = 1; i<max; i++)
        {
            foreach (int x in multiples)
            {
                if (i%x == 0)
                {
                    sum = sum + i;
                    break;
                }
            }
        }
        return sum;
    }
}
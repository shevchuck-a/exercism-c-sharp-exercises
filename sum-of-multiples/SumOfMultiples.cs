using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;

        foreach(int multiple in multiples)
        {
            for (int i = multiple; i < max && multiple % i == 0; i++)
            {
               sum += i;
            }
        }
        return sum;
    }
}
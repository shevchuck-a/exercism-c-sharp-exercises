using System;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number < 1)
            throw new ArgumentOutOfRangeException();
        int divSum = 0;
        for (int i = 1; i <= number/2; i++)
        {
            if (number % i == 0)
                divSum += i;
        }
        if (number == divSum)
            return Classification.Perfect;
        else if (number < divSum)
            return Classification.Abundant;
        else
            return Classification.Deficient;
    }
}

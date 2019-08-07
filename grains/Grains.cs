using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException("Value must be from 1 to 64");
        }
        else
        {
            ulong grainsInSquare = (ulong)Math.Pow(2, n - 1);
            return grainsInSquare;
        }
    }

    public static ulong Total()
    {
        ulong grainsTotal = ((ulong)Math.Pow(2, 64) - 1);
        return grainsTotal;
    }
}
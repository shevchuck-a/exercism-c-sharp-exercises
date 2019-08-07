using System;

public class SpaceAge
{
    public SpaceAge(int seconds)
    {
        OnEarth(seconds);
    }

    public double OnEarth(int sec)
    {
        double earthAge = (double)sec / 31557600;
        return earthAge;
    }

    public double OnMercury()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
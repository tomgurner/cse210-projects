using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {   // 1/1 fraction:
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {   // whole number fraction
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {   // user created fraction
        _top = top;
        _bottom = bottom;
    }


    public String GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // --> double is a floating point number <--
        return (double)_top / (double)_bottom;
    }
}
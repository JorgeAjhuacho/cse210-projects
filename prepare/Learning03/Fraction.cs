using System;
using System.IO;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int topnum)
    {
        _top = topnum;
        _bottom = 1;
    }
    public Fraction(int topnum, int dennum)
    {
        _top = topnum;
        _bottom = dennum;
    }

    public string GetFractionString()
    {
        string Value = $"{_top}/{_bottom}";
        return Value;
    }

    public double GetDecimalValue()
    {
        return ((double)_top / (double)_bottom);
    }
}
using System;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int Whole_Number)
    {
        top = Whole_Number;
        bottom = 1;
    }

    public Fraction(int top2, int bottom2)
    {
        top = top2;
        bottom = bottom2;
    }

    public string GetFractionString()
    {
        string text = $"{top}/{bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}
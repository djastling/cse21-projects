using System.Security.Cryptography;

class Fraction 
{
    private int _top;
    private int _bottom;

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionForm = $"{_top}/{_bottom}";
        return fractionForm;
    }
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}
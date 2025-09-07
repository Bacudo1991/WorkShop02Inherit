namespace WorkShop02Core;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string nameof, double a)
    {
        Name = nameof;        
        A = a;
    }

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    public override double GetArea() => A * A;

    public override double GetPerimeter() => 4 * A;

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The side: {a}, is not valid");
        }
        return a;
    }
}
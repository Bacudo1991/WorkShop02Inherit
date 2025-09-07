namespace WorkShop02Core;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public Triangle(string nameof, double a, double b, double c, double h) : base(nameof, a, b)
    {
        Name = nameof;
        A = a;
        B = b;
        C = c;
        H = h;
    }

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }



    public override double GetArea() => B * H / 2;

    public override double GetPerimeter() => A + B + C;


    private double ValidateC(double c)
    {
        if (c < 0)
        {
            throw new Exception($"The side: {c}, is not valid");
        }
        return c;
    }
    
        private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new Exception($"The height: {h}, is not valid");
        }
        return h;
    }
}
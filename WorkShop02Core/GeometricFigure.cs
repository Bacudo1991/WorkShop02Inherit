namespace WorkShop02Core;

public abstract class GeometricFigure
{
    public string Name { get; set; } = null!;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString() => $"{Name}\t\t => Area.....:\t{GetArea(),15:N5}   Perimeter:\t{GetPerimeter(),15:N5}";
}

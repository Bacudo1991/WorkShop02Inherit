using System.Reflection.Metadata.Ecma335;
using WorkShop02Core;

try
{

    var circle = new Circle(nameof(Circle), 5) ; 
    var square = new Square(nameof(Square), 10);

    var figures = new List<GeometricFigure>() { circle, square };
    foreach (var figure in figures)
    {
        Console.WriteLine(figure);
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


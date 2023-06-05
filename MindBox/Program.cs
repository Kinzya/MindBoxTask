// See https://aka.ms/new-console-template for more information
using MindBox.ShapeArea;

List<IShape> shapes = new List<IShape>
{
    new Triangle(7, 9, 6),
    new Triangle(35, 21, 28),
    new Triangle(9, 8, 3),
    new Triangle(45, 11, 42),
    new Circle(5),
    new Circle(5),
};

foreach(var shape in shapes)
{
    if (shape is Triangle tri)
    {
        Console.WriteLine($"Площадь тругольника: {tri.CalculateArea()}");
        Console.WriteLine($"Это прямоугольный треугольник: {tri.IsRightTriangle()}");
    }
    else
    {
        Console.WriteLine($"Площадь это фигуры: {shape.CalculateArea()}");
    }
}

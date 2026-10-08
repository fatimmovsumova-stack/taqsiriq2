using taqsiriq2;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>();

        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(5, 5));
        shapes.Add(new Triangle(3, 4, 5, 4));

        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Sahe: " + shape.CalculateArea());
            Console.WriteLine("Perimetr: " + shape.CalculatePerimeter());
            Console.WriteLine("--------------------");
        }

        ShapeHelper helper = new ShapeHelper();

        Console.WriteLine("Circle sahesi: " + helper.CalculateArea(5));
        Console.WriteLine("Rectangle sahesi: " + helper.CalculateArea(4, 6));
    }
}
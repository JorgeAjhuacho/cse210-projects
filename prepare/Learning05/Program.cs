using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square num1 = new Square("Red", 4);
        shapes.Add(num1);
        Rectangle num2 = new Rectangle("Red", 4, 5);
        shapes.Add(num2);
        Circle num3 = new Circle("Red", 7);
        shapes.Add(num3);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}
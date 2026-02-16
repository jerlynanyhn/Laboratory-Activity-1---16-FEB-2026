using System;

class Pentagon
{
    private double side;
    
    public Pentagon()
    {
        side = 0;
    }

    public Pentagon(double side)
    {
        this.side = side;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        double sqrt5 = Math.Sqrt(5);
        return (Math.Sqrt(5 * (5 + 2 * sqrt5)) * side * side) / 4;
    }
    public void Display()
    {
        Console.WriteLine($"Side Length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }
    static void Main(string[] args)
    {
        Pentagon pentagon1 = new Pentagon();
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        pentagon1.Display();
        Console.WriteLine();

        Pentagon pentagon2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-------------------------");
        pentagon2.Display();
    }
}
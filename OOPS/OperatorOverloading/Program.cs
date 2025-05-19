using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

   
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
s
  
    public void Display()
    {
        Console.WriteLine($"Point({X}, {Y})");
    }
}

class Program
{
s    static void Main(string[] args)
    {
        Point point1 = new Point(2, 3);
        Point point2 = new Point(4, 5);

        Point result = point1 + point2;  

        result.Display();
    }
}

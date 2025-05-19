using System;

public struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point p;
        p.X = 5;
        p.Y = 10;

        Console.WriteLine($"X = {p.X}, Y = {p.Y}");
    }
}

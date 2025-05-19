using System;

public static class MathHelper
{
    public static int Square(int number)
    {
        return number * number;
    }

    public static int Cube(int number)
    {
        return number * number * number;
    }
}

class Program
{
    static void Main()
    {
        int num = 3;

        Console.WriteLine($"Square of {num} is: {MathHelper.Square(num)}");
        Console.WriteLine($"Cube of {num} is: {MathHelper.Cube(num)}");
    }
}

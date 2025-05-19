using System;

public class Calculator
{
    public int val1;
    public int val2;
    public int val3;

    public int Add(int val1, int val2)
    {
        return val1 + val2;
    }

    public int Add(int val1, int val2, int val3)
    {
        return val1 + val2 + val3;
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        Calculator obj = new Calculator();

        Console.WriteLine("The addition of two numbers is: " + obj.Add(10, 10));
        Console.WriteLine("The addition of three numbers is: " + obj.Add(10, 10, 5));
    }
}

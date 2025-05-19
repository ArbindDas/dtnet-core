
using System;
public class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("i am base");
    }
}

class derivedClass : BaseClass
{
    public sealed override void Display()
    {
        Console.WriteLine("i am derived ");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        BaseClass b = new BaseClass();
        b.Display();
    }
    
}
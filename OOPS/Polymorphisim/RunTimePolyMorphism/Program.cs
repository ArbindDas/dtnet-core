using System;

class Parent
{


    public virtual void show()
    {
        Console.WriteLine("i am from parent ... and i am virtual method");
    }
   
}

class Child : Parent
{

    public override void show()
    {
        Console.WriteLine("i am from child ... and i am override method");
    }
}

class Program
{
    public static void Main(string[] args)
    {


        Child child = new Child();

        child.show();
    }
}

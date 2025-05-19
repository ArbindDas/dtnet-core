using System;

namespace MySimpleNamespace
{

    public class MyClass
    {

        public void print()
        {
            Console.WriteLine("namespace successfully worked.....");
        }
    }
}
public class MyClass
{

    public static void Main(string[] args)
    {

        MySimpleNamespace.MyClass obj = new MySimpleNamespace.MyClass();
        obj.print();
        Console.WriteLine();


    }

}
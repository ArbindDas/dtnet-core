using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor: Object created.");
    }

    ~MyClass()
    {
        Console.WriteLine("Destructor: Object destroyed.");
    }
}

class Program
{
    static void Main()
    {
        MyClass? obj = new MyClass(); // ? makes it nullable
        obj = null;

        // Force garbage collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of Main.");
    }
}

class MyClass
{
    public static string Message;

    // Static constructor
    static MyClass()
    {
        Message = "Hello from static constructor!";
        Console.WriteLine("Static constructor executed.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(MyClass.Message); // Triggers static constructor
    }
}

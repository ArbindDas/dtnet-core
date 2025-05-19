// File: Program.cs
using System;
using; // Using our custom namespace

namespace MyNamespace
{
    // A simple class inside a custom namespace
    public class MessagePrinter
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}

namespace MyOtherNamespace
{
    // Another namespace with a different class
    public class OtherPrinter
    {
        public void Show()
        {
            Console.WriteLine("Hello from MyOtherNamespace!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects from different namespaces
        MessagePrinter printer = new MessagePrinter();
        printer.PrintMessage();

        MyOtherNamespace.OtherPrinter other = new MyOtherNamespace.OtherPrinter();
        other.Show();

        Console.WriteLine("Namespace example complete!");
    }
}

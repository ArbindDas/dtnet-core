using System;

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class Greeter
        {
            public void SayHello()
            {
                Console.WriteLine("Hello from InnerNamespace inside OuterNamespace!");
            }
        }


        public class Smaller
        {
            
            public void SayHelloTwo()
            {
                Console.WriteLine("Hello from InnerNamespace inside OuterNamespace! class smaller");
            }
        }
    }
}

class Program
{
    static void Main()
    {

        // OuterNamespace.InnerNamespace.Greeter greeter = new OuterNamespace.InnerNamespace.Greeter();
        // greeter.SayHello();


        // Console.WriteLine();

        // OuterNamespace.InnerNamespace.Smaller smaller = new OuterNamespace.InnerNamespace.Smaller();
        // smaller.SayHelloTwo();

        

        var greeter = new OuterNamespace.InnerNamespace.Greeter();
        greeter.SayHello();

        Console.WriteLine();

        var smaller = new OuterNamespace.InnerNamespace.Smaller();
        smaller.SayHelloTwo();
    }
}


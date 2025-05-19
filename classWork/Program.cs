
class Assignmet
{
    public static void CheckWheatherFiveAndTen()
    {
        Console.WriteLine("Enter the number of n : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0 && num % 10 == 0)
        {
            Console.WriteLine("the number is divisible by  5 and 10 " + num);
        }
        else
        {
            Console.WriteLine("the number is neither divisible by  5 or 10 " + num);

        }
    }


    public static void isDivisibleByTenButNot13()
    {
        Console.WriteLine("Enter the number of n : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 7 == 0 && num % 13 != 0)
        {
            Console.WriteLine("the number is divisible by 7 but not 13");
        }
        else
        {
            Console.WriteLine("neither divisible by 7 ");
        }
    }

    public static void profitOrLoss()
    {
        Console.WriteLine("Enter the price of cp : ");
        int cp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price of  sp : ");
        int sp = Convert.ToInt32(Console.ReadLine());

        if (cp > sp)
        {
            int ans = cp - sp;
            Console.WriteLine("we are in loss amount : " + ans);
        }
        else if (sp > cp)
        {
            int ans = sp - cp;
            Console.WriteLine("we are in profit amount : " + ans);
        }
    }

    public static void multiplication()
    {
        for (int num = 1; num <= 10; num++)
        {
            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            Console.WriteLine();
        }
    }

    public static void fact()
    {
        Console.WriteLine("Enter the number of n : ");
        int num = Convert.ToInt32(Console.ReadLine());

        int ans = 1;
        for (int i = 1; i <= num; i++)
        {
            ans *= i;
        }

        Console.WriteLine("the factorial  of " + num + " is => " + ans);
    }




    
}
class Program
{
    public static void Main(string[] args)
    {

        // Assignmet.CheckWheatherFiveAndTen();
        // Assignmet.isDivisibleByTenButNot13();
        // Assignmet.profitOrLoss();


        // Assignmet.multiplication();


        // Assignmet.minAndMaxArray();
    }
}
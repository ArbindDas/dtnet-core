using System;
class Program {
    static void Main() {
        int n = 5, fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
        Console.WriteLine("Factorial: " + fact);
    }
}
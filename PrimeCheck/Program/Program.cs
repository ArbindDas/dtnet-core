using System;
class Program {
    static void Main() {
        int n = 7, count = 0;
        for (int i = 2; i < n; i++)
            if (n % i == 0) count++;
        Console.WriteLine(count == 0 ? "Prime" : "Not Prime");
    }
}
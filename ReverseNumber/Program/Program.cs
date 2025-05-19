using System;
class Program {
    static void Main() {
        int n = 123, rev = 0;
        while (n != 0) {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine("Reversed: " + rev);
    }
}
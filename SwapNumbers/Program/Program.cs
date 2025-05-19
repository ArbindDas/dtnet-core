using System;
class Program {
    static void Main() {
        int a = 5, b = 10, temp;
        temp = a; a = b; b = temp;
        Console.WriteLine($"a = {a}, b = {b}");
    }
}
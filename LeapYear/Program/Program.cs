using System;
class Program {
    static void Main() {
        int year = 2024;
        Console.WriteLine((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "Leap Year" : "Not Leap Year");
    }
}
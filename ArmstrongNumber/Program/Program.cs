using System;
class Program {
    static void Main() {
        int num = 153, temp = num, sum = 0;
        while (temp > 0) {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }
        Console.WriteLine(sum == num ? "Armstrong" : "Not Armstrong");
    }
}
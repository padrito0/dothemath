using System;

class Program
{
    static void Main()
    {
        try
        {
            byte a = 25;
            short b = 32000;
            int c = 1000000;
            byte x = 5;
            byte y = 10;
            // byte z = 2;
            float myFloat = 1.5f;

            Console.WriteLine("x + y = " + (x + y));
            Console.WriteLine("myFloat + myFloat = " + (myFloat + myFloat));
            Console.WriteLine("myFloat + a = " + (myFloat + a));
            Console.WriteLine("c - b = " + (c - b));
            Console.WriteLine("x * a = " + (x * a));
            Console.WriteLine("y * b = " + (y * b));
            Console.WriteLine("c / b = " + (c / b));
            Console.WriteLine("a / x = " + (a / x));
            Console.WriteLine("a % x = " + (a % x));
            Console.WriteLine("c % y = " + (c % y));
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

using System;

public class Prime
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{is_divisible(10, 2)}"); 
        Console.WriteLine($"{is_divisible(10, 3)}");
        Console.WriteLine($"{is_divisible(15, 5)}");
        Console.WriteLine($"{is_divisible(17, 4)}");
    }

    public static bool is_divisible(int a, int b)
    {
        return a % b == 0;
    }
}


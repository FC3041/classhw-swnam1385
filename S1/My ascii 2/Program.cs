using System;

public class MyAsciiArg
{
    public static void Main(string[] args)
    {
        for (int size = 1; size <= 9; size += 2)
        {
            Console.WriteLine($"Cone of size {size}:");
            print_cone(size);
            Console.WriteLine();
        }
    }

    public static void print_cone(int baseSize)
    {
        if (baseSize % 2 == 0)
        {
            Console.WriteLine("The size must be odd.");
        }
    }
}
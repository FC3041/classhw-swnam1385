using System;

public class MyAsciiArg
{
    public static void Main(string[] args)
    {
        print_cone(7);
    }

    public static void print_cone(int baseSize)
    {
        for (int i = 1; i <= baseSize; i += 2)  
        {
            int spaces = (baseSize - i) / 2; 
            string stars = new string('*', i); 
            Console.WriteLine(new string(' ', spaces) + stars);
        }
    }
}

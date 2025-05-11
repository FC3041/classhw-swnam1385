using System;

public class Pythagorean
{
    public static void Main(string[] args)
    {
        for (int A = 1; A < 100; A++)
        {
            for (int B = A + 1; B < 100; B++) 
            {
                for (int C = B + 1; C < 100; C++) 
                {
                    if (A * A + B * B == C * C)
                    {
                        Console.WriteLine($"({A}, {B}, {C})");
                    }
                }
            }
        }
    }
}

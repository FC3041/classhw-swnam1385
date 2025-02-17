﻿using System;

public class Absolute
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{absolute_value(-100)}");
        Console.WriteLine($"{absolute_value(-1)}");
        Console.WriteLine($"{absolute_value(0)}");
        Console.WriteLine($"{absolute_value(1)}");
        Console.WriteLine($"{absolute_value(1000)}");
    }

    public static int absolute_value(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }
}


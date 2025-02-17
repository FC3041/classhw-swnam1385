using System;

class Leap_year
{

    public static void Main(string[] args)
    {
        Console.WriteLine(Leap(2024));
        //1792 1800 1804 1900 1904 2000 2004
        Console.WriteLine(Leap(1800));
        Console.WriteLine(Leap(1804));
        Console.WriteLine(Leap(1900));
        Console.WriteLine(Leap(1904));
        Console.WriteLine(Leap(2000));
        Console.WriteLine(Leap(2004));
    }
    public static bool Leap(int year)
    {
         if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}
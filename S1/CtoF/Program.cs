using System;

class CtoF
{
    static void Main()
    {
        Console.WriteLine("enter a number in Celcius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double farenhite = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Celsius : {celsius:F2} , Farenhite: {farenhite:F2}");
    }
}
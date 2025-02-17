using System;

class FToC
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5.0 / 9.0;

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}, Celsius: {celsius:F2}");
    }
}



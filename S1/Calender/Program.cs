using System;

public class Calendar
{
    public static void  onth(int monthNumber)
    {

        string[] months = new string[]
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        if (monthNumber >= 1 && monthNumber <= 12)
        {
            // Print month number followed by its name
            Console.WriteLine($"{monthNumber, -13} | {months[monthNumber - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid month number.");
        }
    }
}

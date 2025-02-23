using System;

class Average_fo_squares
{
    static int Average(int n)
    {
        int sum = 0;
        for (int i=1;i <= n; i++)
            sum += (i*i);
        return sum / n; 
    }
    static public void Main(string[] args)
{
    {
        int n = 5;
        Console.WriteLine(Average(n));
    }
}
}
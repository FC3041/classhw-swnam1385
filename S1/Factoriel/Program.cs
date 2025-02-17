using System;

class Test 
{
    static int factorial(int n)
    {
        int start = 1;

        for (int i = 2; i <= n; i++)
            start *= i;
        return start;
    }
    public static void Main()
    {
        int num = 10;
        Console.WriteLine("Factorial of " + num + " is " + factorial(10));
                          
    }
}

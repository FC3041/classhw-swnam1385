using System;

class Sum_factoriel
{
    static int Factoriel(int a)
    {
        a = 20;
        int start = 1;
        for (int i=2; i <= 20;i++)
            start *= i;
        return start;
    }

    static long Factsum(int a)
    {
        long sum = 0;
        for (int i=0; i <= 20 ;i++)
            sum += Factoriel(i);
        return sum;
    }
    static void Main(string[] args)
    {
        int a = 20;
        Console.WriteLine(Factsum(a));
    }
}


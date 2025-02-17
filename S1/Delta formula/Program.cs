using System;

class Quadratic 
{
    void findRoots(int a, int b, int c)
    {
     
        int d = b * b - 4 * a * c;
        double sqrt_val = Math.Abs(d);

        if (d > 0) {
            Console.Write(
                "Roots are real and different \n");

            Console.Write(
                (double)(-b + sqrt_val) / (2 * a) + "\n"
                + (double)(-b - sqrt_val) / (2 * a));
        }

        else 
        {
            Console.Write("Roots are complex \n");

            Console.Write(-(double)b / (2 * a) + " + i"
                          + sqrt_val / (2 * a) + "\n"
                          + -(double)b / (2 * a) + " - i"
                          + sqrt_val / (2 * a));
        }
    }

    public static void Main()
    {
        Quadratic obj = new Quadratic();
        int a = 1, b = 8, c = 12;
        obj.findRoots(a, b, c);
    }
}


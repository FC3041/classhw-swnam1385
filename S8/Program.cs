using System;
namespace S8;

public static void Main()
{
    string text = "This is the end";
    Console.WriteLine(Reverse(text));
}
public string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse ="";
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}
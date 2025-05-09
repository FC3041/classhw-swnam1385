using System;
public class ReverseWords 
{
	public static void Main()
	{
		string[] s;
        s = "in string ro bargardun".Split(' ');
		string rev = "";
		for (int i = s.Length - 1;i >= 0; i--) 
		{
			rev += s[i] + " ";
		}
		Console.Write(rev.Substring(0,rev.Length - 1));
	}
}


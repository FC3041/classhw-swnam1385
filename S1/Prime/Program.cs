using System;

class Prime 
{ static bool isPrime(int n)
{ 
  if (n <= 1) 
  {     
    return false;
  }


  for (int i = 2; i < n; i ++) 
  {
    if (n % i == 0) 
    {
      return false;
    }
  }
  return true;
}


static int Main()
{
  int n;
  if (isPrime(n)) 
  {
    Console.WriteLine("True");
  } 
  else 
  {
    Console.WriteLine("False");
  }

  return 0;
}
}
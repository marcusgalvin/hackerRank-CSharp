using System;

namespace ConditionalStatements
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      int N = Convert.ToInt32(Console.ReadLine());

      if (N < 0)
      {
        Console.WriteLine("Weird");

      }
      else if (N > 20)
      {
        Console.WriteLine("Not Weird");
      }


      if (N < 2 || N > 5)
      {
        Console.WriteLine("Not Weird");
      }
    }
  }
}
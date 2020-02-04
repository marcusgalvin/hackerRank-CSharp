using System;

namespace hackerRankLoops
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //Console.WriteLine("Please enter a number in which you would like to see its first 10 multiples);
      int n = Convert.ToInt32(Console.ReadLine());

      for (var i = 1; i < 11; i++)
      {
        var result = n * i;
        Console.WriteLine(result);
      }
    }
  }
}

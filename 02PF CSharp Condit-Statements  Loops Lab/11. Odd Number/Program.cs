using System;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var n = Math.Abs(int.Parse(Console.ReadLine()));
                    if (n % 2 == 1)
                    {
                        Console.WriteLine($"The number is: {n}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please write an odd number.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Please write an odd number.");
                }
            }
                   
        }
    }
}

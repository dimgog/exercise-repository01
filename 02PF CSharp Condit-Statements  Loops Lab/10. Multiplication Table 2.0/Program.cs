using System;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplyer01 = int.Parse(Console.ReadLine());
            var multiplyer02 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{multiplyer01} X {multiplyer02} = {multiplyer02 * multiplyer01}");
                multiplyer02++;
            } while (multiplyer02<=10);
        }
    }
}

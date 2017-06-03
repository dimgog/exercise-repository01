using System;


namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }

            if (minutes <10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }

        }
    }
}

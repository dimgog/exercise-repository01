using System;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine().ToLower();
            var ageOfPerson = int.Parse(Console.ReadLine());
            var price = 0;


            if ((0 <= ageOfPerson && ageOfPerson <= 18) || (64 < ageOfPerson && ageOfPerson <= 122))
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "holiday")
                {
                    if (0 <= ageOfPerson && ageOfPerson <= 18)
                    {
                        price = 5;
                    }
                    else
                    {
                        price = 10;
                    }
                }
                else
                {
                    price = 0;
                }
            }
            else if (18 < ageOfPerson && ageOfPerson <= 64)
            {
                if (typeOfDay == "weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 20;
                }
                else if (typeOfDay == "holiday")
                {
                    price = 12;
                }
                else
                {
                    price = 0;
                }
            }
            else
            {

                price = 0;
            }
            if (price == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("{0}$", price);
            }
            
        }
    }
}

using System;

namespace firstBrief
{
    public class Tva
    {
        public static void Tvaa()
        {
            //Ask for name
            Console.Write("Insert product name : ");
            string product = Console.ReadLine();

            //Get Price
            Console.Write("Insert Price :");
            double price = Convert.ToDouble(Console.ReadLine());

            //Show Message
            Console.WriteLine($"Your Product : { product} \n " +
                              $"Product Price : { price }");

            //Logic
            double tva = price * 19 / 100;
            double ttc = tva + price;

            //Result
            Console.WriteLine($"The price TTC of { product } ,is { ttc }DH");
        }

    }
}
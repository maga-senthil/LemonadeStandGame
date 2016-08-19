using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Price
    {
        
        public double pricePerCup;
        public double lemonPrice;
        public double sugarPrice;
        public double icePrice;
        public double cupPrice;

        public Price ()
        {
            lemonPrice = 0.25;
            sugarPrice = 0.50;
            icePrice = 0.10;
            cupPrice = 0.05;
        }

        public void PrintPrice()
        {
            Console.WriteLine("Cost for Each Item:");
            Console.WriteLine("\tLemon  :{0:0.00}", lemonPrice);
            Console.WriteLine("\tSugar  :{0:0.00}", sugarPrice);
            Console.WriteLine("\tIce    :{0:0.00}", icePrice);
            Console.WriteLine("\tCup    :{0:0.00}", cupPrice);
        }

        public void CalculatePrice()
        {
            Console.Write("Now its time to think selling price for your lemonade :$");
            string price = Console.ReadLine();
            if (!System.Text.RegularExpressions.Regex.IsMatch(price, "^[0-9]"))
            {
                Console.WriteLine("Enter the proper value(Accept only Numbers ");
                CalculatePrice();
            }
            else
            {

                pricePerCup = Convert.ToDouble(price);
            }
            Console.WriteLine("Selling Price per Cup  :${0:0.00}",pricePerCup );


        }

    }
}


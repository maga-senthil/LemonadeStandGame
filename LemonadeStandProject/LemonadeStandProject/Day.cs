using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
   class Day
    {
        
        
        public int numberOfCustomers;
        List<Customer> customerList;
        string displaytext;
        public int lemonadeCupsSold;
        public Weather weather;

        public Day ()
        {
            weather= new Weather();
            numberOfCustomers = 0;
            lemonadeCupsSold  = 0;
            customerList = new List<Customer> ();
            
        }

       
        public int Demand(Weather weather)
        {
            if (weather.perception == "Sunny" || weather.actualTemperature > 90)
            {
                Console.WriteLine("      Hi! Its a perfect day, we can sell more lemonade!!!!");
                Console.WriteLine("      Invest more money and buy more items.");
                numberOfCustomers = 100;
                Console.WriteLine("---------------------------Expected customers :{0}----------------------------", numberOfCustomers);
            }
            else if (weather.perception == "Cloudy" || weather.actualTemperature < 90)
            {
                Console.WriteLine("Its not too bad at all.");
                Console.WriteLine("Still we can sell Lemonade");
                numberOfCustomers = 75;
                Console.WriteLine("--------------------------Expected customers :{0}-----------------------------", numberOfCustomers);
                
            }
            else if (weather.perception == "rainy")
            {
                Console.WriteLine("Opps!!! I don,t think we can sell lemonade.");
                Console.WriteLine("Be Carefull with your investment.");
                numberOfCustomers = 30;
                Console.WriteLine("--------------------------Expected customers :{0}----------------------------", numberOfCustomers);
                
            }


            return numberOfCustomers;
        }


        public List<Customer> GetCustomer(int numberOfCustomers,Stand stand)
        {
            
            Random random = new Random();
            
            for (int i =0; i < numberOfCustomers;i++)
            {
                int rnd = random.Next(1, 5);
                if (rnd == 1 || rnd == 3)
                {
                    displaytext = "passes by didn't buy lemonade.";
                }
                else
                {
                    displaytext = "bought lemonade. ";
                    lemonadeCupsSold += 1;
                }

                Customer customer = new Customer("customer"+ " "+ i + " "+ displaytext  );

                if (stand.numberOfCups  > lemonadeCupsSold)
                {
                    customerList.Add(customer);

                }
                else
                {
                    break;
                 
                }
              
            }
            return customerList ;
        }
         
        public void DisplayCustomers()
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine( customer .name );
            }
            Console.WriteLine("{0} customers bought lemonade", lemonadeCupsSold );
        }


    }
}

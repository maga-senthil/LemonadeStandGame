using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Stand : IRecipe
    {

        public int amountOfLemon;
        public int amountOfSugar;
        public int amountOfIce;
        public int numberOfCups;
        public int cupOfLemonade;
        int lemonPerCup;
        int sugarPerCup;
        int icePerCup;
        public CashBox cashBox;
        int minimumCups;
        public int actualNumberOfCups;



        public Stand()
        {
            cashBox = new CashBox();
            numberOfCups = 0;
            cupOfLemonade = 0;
        }
        public void PlayerPickLemon(Inventory inventory)
        {
            Console.Write("How many lemons you want :");
            string amountOfLemonReq = Console.ReadLine();


            if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfLemonReq, "^[0-9]"))
            {
                Console.WriteLine("Enter proper value(Accept only numbers):");
                PlayerPickLemon(inventory);

            }
            else
            {
                amountOfLemon = Convert.ToInt32(amountOfLemonReq);
                lemonPerCup = inventory.lemonInStock / amountOfLemon;
            }

        }


        public void PlayerPickSugar(Inventory inventory)
        {
            Console.Write("How many suger packs you want :");
            string amountOfSugarReq = Console.ReadLine();


            if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfSugarReq, "^[0-9]"))
            {
                Console.WriteLine("Enter proper value(Accept only numbers):");
                PlayerPickSugar(inventory);

            }
            else
            {
                amountOfSugar = Convert.ToInt32(amountOfSugarReq);
                sugarPerCup = inventory.sugarInStock / amountOfSugar;
            }
           
            
         }



        public void PlayerPickIce(Inventory inventory)
        { 

            Console.Write("How many ice cubes you want :");
            string amountOfIceReq = Console.ReadLine();


            if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfIceReq, "^[0-9]"))
            {
                Console.WriteLine("Enter proper value(Accept only numbers):");
                PlayerPickIce(inventory);

            }
            else
            {
                amountOfIce = Convert.ToInt32(amountOfIceReq);
                icePerCup = inventory.iceInStock / amountOfIce;
            }

        }

       
        public int GetRecipe()
        {
            cupOfLemonade = amountOfLemon + amountOfSugar + amountOfIce;
            numberOfCups = numberOfCups * cupOfLemonade;
            return numberOfCups;
        }


        public void DisplayRecipe()
        {
            Console.WriteLine("Lemon per cup  : {0}",amountOfLemon);
            Console.WriteLine("Sugar per cup  : {0}",amountOfSugar);
            Console.WriteLine("Ice per cup    : {0}",amountOfIce);
            Console.WriteLine("Lemonade Cups  : {0}", numberOfCups);
        }

        public int CaluculateCupsCanprepare(Inventory inventory)
        {

            int[] stock = new[] { lemonPerCup, sugarPerCup, icePerCup, inventory.cupsInStock };
             minimumCups = stock.Min();

            Console.WriteLine("Maximum cups of Lemonade you can make is {0}", minimumCups);
            return minimumCups;
        }


      

        public void CupsCanPrepare(Inventory inventory)
        {

            Console.Write("How many cups do you want to prepare?");
            string numberOfCupsReq = Console.ReadLine();

            if (!System.Text.RegularExpressions.Regex.IsMatch(numberOfCupsReq , "^[0-9]"))
            {
                Console.WriteLine("Enter proper value(Accept only numbers):");
                CupsCanPrepare(inventory);
            }
            else
            {
                numberOfCups =Convert.ToInt16 ( numberOfCupsReq);
            }
           
            if (numberOfCups > minimumCups)
            {
                Console.WriteLine("Maximum cups you can prepare is {0}", minimumCups);
                CupsCanPrepare(inventory);
            }
            else
            {
                actualNumberOfCups = minimumCups;
            }


        }
    }


}

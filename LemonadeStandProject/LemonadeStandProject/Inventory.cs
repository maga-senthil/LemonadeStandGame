using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Inventory
    {
       
        public int lemon;
        public int sugar;
        public int ice;
        public int cup;
       
        public int lemonInStock;
        public int sugarInStock;
        public int iceInStock;
        public int cupsInStock;

        public Inventory ()
        {
            
            lemonInStock = 0;
            sugarInStock = 0;
            iceInStock = 0;
            cupsInStock = 0;
        }
       
        public int GetLemon(Player player,Price price,Day day)
        {
            
            Console.Write("\tLemon  :");
            string item1 = Console.ReadLine();
           
            if (!System.Text.RegularExpressions.Regex.IsMatch(item1 , "^[0-9]"))
            {
                Console.WriteLine("Enter proper quantity(Accept only numbers):");
                GetLemon(player,price,day);
            }
            else
            {
                lemon = Convert.ToInt32 (item1);
               
                player.cashToInvest -= price.lemonPrice * lemon;
                Console.WriteLine("Cash remaining  : {0}", player.cashToInvest );
                if (player.cashToInvest  <= 0)
                {
                    Console.WriteLine("Opps you are running out of money.");
                    Console.WriteLine("Buy proper amount of ingrediants.");
                    player.StartAmountOfGame(day, player);
                    GetLemon(player,price,day);
                }

            }
            return lemon;


        }

        public int GetSugar(Player player,Price price,Day day)
        {

            Console.Write("\tSugar  :");
            string item1 = Console.ReadLine();

            if (!System.Text.RegularExpressions.Regex.IsMatch(item1, "^[0-9]"))
            {
                Console.WriteLine("Enter proper quantity(Accept only numbers):");
                GetSugar(player,price,day);
            }
            else
            {
                sugar = Convert.ToInt32(item1);
               
                player.cashToInvest -= price.sugarPrice * sugar; 
               
                Console.WriteLine("Cash remaining  : {0}", player.cashToInvest );
                if (player.cashToInvest  <= 0)
                {
                    Console.WriteLine("Opps you are running out of money.");
                    Console.WriteLine("Buy proper amount of ingrediants.");
                    player.StartAmountOfGame(day, player);
                    GetLemon(player, price,day);
                    GetSugar(player, price, day);
                }
            }

            return sugar;

        }

        public int GetIce(Player player,Price price,Day day)
        {

            Console.Write("\tIce    :");
            string item1 = Console.ReadLine();

            if (!System.Text.RegularExpressions.Regex.IsMatch(item1, "^[0-9]"))
            {
                Console.WriteLine("Enter proper quantity(Accept only numbers):");
                GetIce(player,price,day);
            }
            else
            {
                ice = Convert.ToInt32(item1);
                
                
                player.cashToInvest  -= price.icePrice * ice; 
                Console.WriteLine("Cash remaining  : {0}", player.cashToInvest );
                if (player.cashToInvest  <= 0)
                {
                    Console.WriteLine("Opps you are running out of money.");
                    Console.WriteLine("Buy proper amount of ingrediants.");
                    player.StartAmountOfGame(day, player);
                    GetLemon(player, price,day);
                    GetSugar(player, price, day);
                    GetIce(player, price, day);
                }
            }

            return ice;
        }


        public int GetCup(Player player,Price price,Day day)
        {

            Console.Write("\tCup    :");
            string item1 = Console.ReadLine();

            if (!System.Text.RegularExpressions.Regex.IsMatch(item1, "^[0-9]"))
            {
                Console.WriteLine("Enter proper quantity(Accept only numbers):");
                GetCup(player,price,day);
            }
            else
            {
                
                cup  = Convert.ToInt32(item1);
                
                player.cashToInvest -= price.cupPrice * cup;
                Console.WriteLine("Cash remaining  : {0}", player.cashToInvest );
                if (player.cashToInvest  <= 0)
                {
                    Console.WriteLine("Opps you are running out of money.");
                    Console.WriteLine("Buy proper amount of ingrediants.");
                    player.StartAmountOfGame(day, player);
                    GetLemon(player, price,day);
                    GetSugar(player, price, day);
                    GetIce(player, price, day);
                    GetCup(player, price, day);
                }
            }
            

            return cup;
        }


        public void AddQuantity()
        {
            
            lemonInStock += lemon ;
            sugarInStock += sugar ;
            iceInStock  += ice;
            cupsInStock += cup;
           
        }

        public void CurrentInventory()
        {
            Console.WriteLine("Lemon   : {0}",lemonInStock);
            Console.WriteLine("Sugar   : {0}",sugarInStock);
            Console.WriteLine("Ice     : {0}",iceInStock);
            Console.WriteLine("Cup     : {0}",cupsInStock);
        }
        public  void UpdateQuantity(Stand stand)
        {
            lemonInStock -= stand.numberOfCups  * stand.amountOfLemon;
            sugarInStock -= stand.numberOfCups * stand.amountOfSugar;
            iceInStock -= stand.numberOfCups * stand.amountOfIce;
            cupsInStock -= stand.numberOfCups ;
        }

        public void LessQuantity()
        {
            lemonInStock -= lemonInStock;
            sugarInStock -= sugarInStock;
            iceInStock -= iceInStock;
            cupsInStock -= cupsInStock;

        }

      

    }


}

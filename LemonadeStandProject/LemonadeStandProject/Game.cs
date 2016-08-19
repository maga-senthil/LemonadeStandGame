using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Game
    {
        Day day;
        Player player;
        Price price;
        Inventory inventory;
        Stand stand;
        Report report;
        public int startDay;
        int daysWantToPlay;
        //AboutGame aboutGame;

        public Game()
        {
            startDay = 0;
            player = new Player();
            price = new Price();
            inventory  = new Inventory();
            stand =new Stand();
            report = new Report();
            //aboutGame = new AboutGame();
            
            
        }

        public void ChooseDays()
        {

            Console.Write("Days to play: 7 or 14 or 21 : ");
            string toPlay = Console.ReadLine();
            int daysWantToPlayNow = Convert.ToInt32(toPlay);
            if (daysWantToPlayNow  == 7 || daysWantToPlayNow  == 14  || daysWantToPlayNow  == 21)
            {

                daysWantToPlay = daysWantToPlayNow;
            }
            else
            {

                Console.WriteLine("Choose proper value:");
                ChooseDays();
            }
        }
        public int AddDay()
        {

            startDay  += 1;
            return startDay ;
        }

        public void RunGame()
        {

            Console.WriteLine("**********************************LEMENADE STAND********************************");
            AboutGame.DisplayAboutGame();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadKey();
            player.CheckPlayerName();
            ChooseDays();
            Console.WriteLine("********************************************************************************");


            while (startDay  < daysWantToPlay)
            {
                day = new Day();
                player.cashSpentThisTurn = 0;
                AddDay();
                Console.Write("Day : {0}    ", startDay);
                Console.WriteLine(DateTime .Today);
                Console.WriteLine("-------------------------------------Weather------------------------------------");
                Console.WriteLine("prediction:\n \t temperature   :{0}\n \t perception    :{1}",day.weather.Temperature(day.weather.predictedTemperature), day.weather.Perception(day.weather.predictedPerception));
                Console.WriteLine("Actual:\n \t temperature   :{0}\n \t perception    :{1}", day.weather.Temperature(day.weather.actualTemperature), day.weather.Perception(day.weather.actualPerception));
                Console.WriteLine();
                day.Demand(day.weather);

                Console.WriteLine("================================================================================");
                    
                price.PrintPrice();

                Console.WriteLine("--------------------------------------------------------------------------------");
                player.StartAmountOfGame(day,player);
                Console.WriteLine("{0}, you are going to start the business with ${1:00.00}.", player.playerName, player .cashToInvest);


                Console.WriteLine("================================================================================");

                Console.WriteLine("Your Current Inventory:");
                inventory.CurrentInventory();
                Console.WriteLine("================================================================================");
                Console.WriteLine("Buy your ingredients: ");

                inventory.GetLemon(player,price,day);
                inventory.GetSugar(player,price,day);
                inventory.GetIce(player,price,day);
                inventory.GetCup(player,price,day);
                inventory.AddQuantity();
                
                

                Console.WriteLine("--------------------------------------------------------------------------------");
               
                Console.WriteLine("Now you are ready to make lemonade:");
                Console.WriteLine("Create your own lemonade Recipe:");
                stand.PlayerPickLemon(inventory);
                stand.PlayerPickSugar(inventory);
                stand.PlayerPickIce(inventory);
                
                stand.CaluculateCupsCanprepare(inventory);
                
                stand.CupsCanPrepare(inventory);
                Console.WriteLine("--------------------------------------------------------------------------------");
                price.CalculatePrice();
                Console.WriteLine("--------------------------------------------------------------------------------");
                inventory.UpdateQuantity(stand);
                stand.DisplayRecipe();
                Console.WriteLine("--------------------------------------------------------------------------------");
                day.GetCustomer(day.numberOfCustomers,stand);
                day.DisplayCustomers();
                if (stand.numberOfCups == day.lemonadeCupsSold)
                {
                    Console.WriteLine("SOLD OUT");
                }
                    
                stand.cashBox.profitForTheDay(day,price);
                stand.cashBox.CalculateToRemainCash(player);
                
                Console.WriteLine("********************************************************************************");
                report.DisplayReport(player,day,stand,stand.cashBox,startDay);
                report.GetReport(player, day,stand,stand.cashBox,startDay);

                Console.WriteLine("********************************************************************************");
                Console.WriteLine("Press any key Goto next day");
                Console.ReadKey();
            }
           startDay ++;
           
            Console.WriteLine("Weekly report:");
            report.ReadReport();
        }


         

    }
}

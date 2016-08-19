using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Player
    {
        string player;
        public string playerName;
        public int numberOfPlayers;
        public double cashToInvest;
        public double cashSpentThisTurn;
        public double initialCashBalance;

        public Player ()
        {
            numberOfPlayers = 0;
            cashToInvest = 0;
            cashSpentThisTurn = 0;
        }
       

        public void GetPlayerName()
        {

            CheckPlayerName();
            Console.WriteLine("Player name is {0}", playerName);
            

        }
        public void CheckPlayerName()
        {
            Console.Write("Enter the Player name  : ");
            player  = Console.ReadLine();
            if (!System.Text.RegularExpressions.Regex.IsMatch(player, "^[a-zA-Z]"))
            {
                Console.WriteLine("Enter your name properly(Accept only alphabets):");
                CheckPlayerName();
                               
            }
            else
            {
                playerName = player;
            }
           
            
        }

      
      

        public double StartAmountOfGame(Day day,Player player)
        {
            if(day.numberOfCustomers ==100)
            {
                cashToInvest = 100;
            }
            else if(day.numberOfCustomers ==75)
            {
                cashToInvest = 75;
            }
            else
            {
                cashToInvest = 30;
            }

           

            initialCashBalance = cashToInvest;
            return cashToInvest;
        }



    }
}

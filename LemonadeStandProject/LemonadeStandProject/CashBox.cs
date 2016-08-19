using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class CashBox
    {
        public double cashEarned;
        public double expense;
        double amountToLemSold;
       

        public double  profitForTheDay(Day day,Price price)
        {
            amountToLemSold  = day.lemonadeCupsSold * price.pricePerCup;

            return amountToLemSold;
        }

        public double CalculateToRemainCash(Player player)
        {
            expense = player.initialCashBalance - player.cashToInvest;
            cashEarned = amountToLemSold -expense;
            
            return cashEarned;
        }
    }
}

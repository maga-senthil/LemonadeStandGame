using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandProject
{
    class Report
    {
        string[] storeTextInRepot = new string[4];
        double[] storeNumberInReport = new double[4];
        string lemProRepFile;
       

        public Report ()
        {
            
        }
        public void DisplayReport(Player player, Day day, Stand stand, CashBox cashBox ,int daycount)
        {
            Console.WriteLine("             *****LEMONADE SALES REPOT FOR THE DAY***** ");
            Console.Write("Day : {0}     ", daycount);
            Console.WriteLine("Date : {0}",DateTime .Today);
            Console.WriteLine("Number of lemonade cups made  :{0}", stand.numberOfCups);
            Console.WriteLine("Number of lemonade cups sold  :{0}", day.lemonadeCupsSold);

            Console.WriteLine("Expenses  :{0}", cashBox.expense);
            Console.WriteLine("Profit    :{0}", cashBox.cashEarned);
        }

        public void GetReport(Player player, Day day, Stand stand, CashBox cashBox, int dayCount)
        {
            storeTextInRepot[0] = "Number of lemonade cups made  :";
            storeTextInRepot[1] = "Number of lemonade cups sold  :";
            storeTextInRepot[2] = "Expense  :";
            storeTextInRepot[3] = "profit   :";

            storeNumberInReport[0] = stand.numberOfCups;
            storeNumberInReport[1] = day.lemonadeCupsSold;
            storeNumberInReport[2] = cashBox.expense;
            storeNumberInReport[3] = cashBox.cashEarned;
             
            lemProRepFile = @"c:\codecamp\LemonadeprojectReport\GameReport.txt";
            Console.WriteLine(File.Exists(lemProRepFile) );

            if (File.Exists(lemProRepFile))
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(lemProRepFile , true))

                {

                    file.WriteLine("Day: " + dayCount + " " + "Date : " + DateTime.Today);

                    for (int i = 0; i < storeTextInRepot.Length; i++)
                    {

                        file.WriteLine(storeTextInRepot[i] + storeNumberInReport[i]);

                    }

                    file.Close();
                }

            }

            else
            {
                using (StreamWriter file = File.CreateText(lemProRepFile))
                {

                    file.WriteLine("Day: " + dayCount + " " + "Date : "+ DateTime.Today);
                   
                    for (int i = 0; i < storeTextInRepot.Length; i++)
                    {

                        file.WriteLine(storeTextInRepot[i] + storeNumberInReport[i]);

                    }

                    file.Close();
                }
            }

          
            
        }

        public void ReadReport()
        {
            using (StreamReader readFile = File.OpenText(lemProRepFile))
            {
                string line = "";
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}

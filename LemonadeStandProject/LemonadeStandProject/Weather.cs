using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Weather
    {
        public double predictedTemperature;
        public double actualTemperature;
        public int predictedPerception;
        public int actualPerception;
        public string perception;


        public Weather ()
        {
            Random rnd1 = new Random();
            predictedTemperature = rnd1.Next(70, 110);

            actualTemperature = rnd1.Next(70, 110);

            predictedPerception = rnd1.Next(1, 3);

            actualPerception = rnd1.Next(1, 3);

        }

        public double Temperature(double temperature)
        {
            return temperature;
        }

     
       

        public string Perception(int weatherPerception)
        {
           
            if (weatherPerception == 1)
            {
                perception ="Sunny";
            }
            else if (weatherPerception  == 2)
            {
                perception ="Cloudy";
            }
            else
            {
                perception ="Rainy";
            }

            return perception;

        }
       
    }
}

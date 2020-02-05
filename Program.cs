using System;

namespace livecodingfinal
{
    class Program
    {
        static double avgVisitor = 250;
        static double avgTemp;
        static double avgWeather;


        static double Temp(string temp)
        {
            if (temp == "40s")
            {
                avgTemp = avgVisitor * -.05;
            }
            else if (temp == "50s")
            {
                return avgTemp;
            }
            else if (temp == "60s")
            {
                avgTemp = avgVisitor * .05;
            }
            else if (temp == "70s")
            {
                avgTemp = avgVisitor * .2;
            }

            return avgTemp;
        }

        static double Weather(string weather)
        {
            // first determine the kind of weather
            //if "Clear" - 10% more
            //if "Cloudy" -  0%
            //if "Raining" - 25% less
            //if "Full Moon" - 25% more
            if (weather == "Clear")
            {
                avgWeather = avgVisitor *.10;
            }

            else if (weather == "Cloudy")
            {
                return avgWeather;
            }

            else if (weather == "Raining")
            {
                avgWeather = avgVisitor * -.25;
            }

            else if (weather == "Full Moon")
            {
                avgWeather = avgVisitor * .25;
            }

            return avgWeather;
        }

        static double Candy(string weather, string temp)
        {
            // 3 candy per kid
            double avgCandy = (Weather(weather) + Temp(temp) + avgVisitor) * 3;
            return avgCandy;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Candy("Clear", "50s"));
            Console.WriteLine(Candy("Full Moon","40s"));
            Console.WriteLine(Candy("Raining", "70s"));
        }


    }
}

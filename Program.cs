using System;

namespace livecodingfinal
{
    class Program
    {
        public static double Candy(string weather, int temp)
        {
            double avgVisitor = 250.0;

            // first determine the kind of weather
            //if "Clear" - 10% more
            //if "Cloudy" -  0%
            //if "Raining" - 25% less
            //if "Full Moon" - 25% more
            if (weather == "Clear")
            {
                avgVisitor = (avgVisitor *.10) + avgVisitor;
            }

            else if (weather == "Cloudy")
            {
                avgVisitor = avgVisitor;
            }

            else if (weather == "Raining")
            {
                avgVisitor = avgVisitor - (avgVisitor * .45);
            }
            // then the temperature

            return avgVisitor * 3;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Candy("Clear", 50));
            Console.WriteLine(Candy("Full Moon", 40));
            Console.WriteLine(Candy("Raining", 70));
        }


    }
}

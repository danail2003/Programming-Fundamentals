using System;

namespace Cooking_Factory
{
    class Program
    {
        static void Main()
        {          
            string command = Console.ReadLine();
            
            double highestQuality = 0;
            double maxValue = int.MinValue;
            int maxElements = int.MinValue;
            double maxAverage = int.MinValue;
            string[] numbers = new string[10];

            while (command != "Bake It!")
            {
                string[] convert = command.Split("#");

                for (int i = 0; i < convert.Length; i++)
                {
                    int number = int.Parse(convert[i]);
                    highestQuality += number;                   
                }

                double averageQuality = highestQuality / convert.Length;

                if (highestQuality > maxValue)
                {
                    maxValue = highestQuality;
                    numbers = convert;
                }

                if (averageQuality > maxAverage)
                {
                    if (maxValue == highestQuality)
                    {
                        maxAverage = averageQuality;
                        numbers = convert;
                    }
                }

                if (maxValue == highestQuality && averageQuality == maxAverage && convert.Length > maxElements && convert.Length > 0)
                {
                    maxElements = convert.Length;
                    numbers = convert;
                }

                highestQuality = 0;
                command = Console.ReadLine();
            }

            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                total += number;
            }

            Console.WriteLine($"Best Batch quality: {total}");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

using System;
using System.Linq;

namespace Hello__France
{
    class Program
    {
        static void Main()
        {
            string[] items = Console.ReadLine().Split("|").ToArray();
            double budget = double.Parse(Console.ReadLine());
            
            double diff = 0;
            double[] boughtItems = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                string[] token = items[i].Split("->");

                if (token[0] == "Clothes")
                {
                    if (double.Parse(token[1]) <= 50.00 && budget >= double.Parse(token[1]))
                    {
                        budget -= double.Parse(token[1]);
                        boughtItems[i] += double.Parse(token[1]) + (double.Parse(token[1]) * 0.40);
                        diff += (double.Parse(token[1]) * 0.40);
                    }
                }
                else if (token[0] == "Shoes")
                {
                    if (double.Parse(token[1]) <= 35.00 && budget >= double.Parse(token[1]))
                    {
                        budget -= double.Parse(token[1]);
                        boughtItems[i] += double.Parse(token[1]) + (double.Parse(token[1]) * 0.40);
                        diff += (double.Parse(token[1]) * 0.40);
                    }
                }
                else if (token[0] == "Accessories")
                {
                    if (double.Parse(token[1]) <= 20.50 && budget >= double.Parse(token[1]))
                    {
                        budget -= double.Parse(token[1]);
                        boughtItems[i] += double.Parse(token[1]) + (double.Parse(token[1]) * 0.40);
                        diff += (double.Parse(token[1]) * 0.40);
                    } 
                }
            }

            for (int i = 0; i < boughtItems.Length; i++)
            {
                if (boughtItems[i] > 0)
                {
                    Console.Write($"{boughtItems[i]:f2} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Profit: {diff:f2}");

            double total = budget + boughtItems.Sum();

            if (total >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}

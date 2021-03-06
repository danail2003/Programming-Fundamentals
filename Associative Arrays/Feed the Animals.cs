using System;
using System.Linq;
using System.Collections.Generic;

namespace Feed_the_Animals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> foodLimit = new Dictionary<string, int>();
            Dictionary<string, int> area = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "Last Info")
            {
                string[] token = command.Split(":");

                if (token[0] == "Add")
                {
                    int food = int.Parse(token[2]);

                    if (!area.ContainsKey(token[3]))
                    {
                        area[token[3]] = 0;
                    }

                    if (!foodLimit.ContainsKey(token[1]))
                    {
                        foodLimit[token[1]] = 0;
                        area[token[3]]++;
                    }

                    foodLimit[token[1]] += food;
                }
                else if (token[0] == "Feed")
                {
                    int food = int.Parse(token[2]);

                    if (foodLimit.ContainsKey(token[1]))
                    {
                        foodLimit[token[1]] -= food;

                        if(foodLimit[token[1]] <= 0)
                        {
                            foodLimit.Remove(token[1]);
                            area[token[3]] -= 1;
                            Console.WriteLine($"{token[1]} was successfully fed");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Animals:");

            foreach (var animal in foodLimit.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var areas in area.OrderByDescending(x=>x.Value))
            {
                if (areas.Value > 0)
                {
                    Console.WriteLine($"{areas.Key} : {areas.Value}");
                }
            }
        }
    }
}

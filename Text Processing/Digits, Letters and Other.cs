using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            string symbols = Console.ReadLine();
            
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < symbols.Length; i++)
            {
                char symbol = symbols[i];

                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                {
                    others.Append(symbol);
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{others}");
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Deciphering
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] substrings = Console.ReadLine().Split();
            
            Regex regex = new Regex(@"^[d-z|#{}]+$");
            StringBuilder decipher = new StringBuilder();

            Match match = regex.Match(text);

            if (match.Success)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int element = text[i] - 3;
                    char symbol = (char)element;
                    decipher.Append(symbol);
                }

                decipher.Replace(substrings[0], substrings[1]);

                Console.WriteLine(decipher);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}

using System;

namespace Calculations
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            if (command == "add")
            {
                AddOperation(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                MultiplyOperation(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                SubtractOperation(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                DivideOperation(firstNumber, secondNumber);
            }
        }

        static void AddOperation(int firstNumber, int secondNumber)
        {
            int add = firstNumber + secondNumber;
            Console.WriteLine(add);
        }

        static void MultiplyOperation(int firstNumber, int secondNumber)
        {
            int multiply = firstNumber * secondNumber;
            Console.WriteLine(multiply);
        }

        static void SubtractOperation(int firstNumber, int secondNumber)
        {
            int subtract = firstNumber - secondNumber;
            Console.WriteLine(subtract);
        }

        static void DivideOperation(int firstNumber, int secondNumber)
        {
            int divide = firstNumber / secondNumber;
            Console.WriteLine(divide);
        }
    }
}

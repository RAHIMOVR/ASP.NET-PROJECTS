using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------");
            Console.WriteLine("Calculator");
            Console.WriteLine("----------");
            Console.WriteLine(" ");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation: ");
            String op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine("Answer is: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Answer is: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Answer is: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Answer is: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("There is no operation such as " + op + ", please try again.");
                    break;
            }

            Console.ReadKey();
        }
    }
}

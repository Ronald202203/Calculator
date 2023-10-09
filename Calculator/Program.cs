using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;

            float result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator progam!");

            Console.WriteLine("Please entre your first number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What typ of operation would you like to do ?");
            Console.WriteLine("Please entre a fo addition, s for subtraction, m for mutiplication or any other key for division.");

            answer = Console.ReadLine().ToLower();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s") 
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num2 == 0? float.NaN : num1 / num2;
            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by 0!");
            }
            else
            {
                Console.WriteLine("The result is: " + result);
            }

            
            Console.WriteLine("Thank ou for using the calculator program!");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorReference.CalculatorServiceClient client = new CalculatorReference.CalculatorServiceClient();
            string choice = "0";
            while (!choice.Equals("5"))
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first number: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double n2 = double.Parse(Console.ReadLine());

                        double n3 = client.Add(n1, n2);
                        Console.WriteLine("The sum is: " + n3);
                        Console.ReadLine();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}

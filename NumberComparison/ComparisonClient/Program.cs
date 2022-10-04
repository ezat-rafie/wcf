using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ComparisonServiceClient service = new ServiceReference1.ComparisonServiceClient();

            Console.Write("Enter first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine());

            double n3 = service.Compare(n1, n2);
            Console.WriteLine("The bigger number is: " + n3);
            Console.ReadLine();
        }
    }
}

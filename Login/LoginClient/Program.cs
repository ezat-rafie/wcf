using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.LoginClient login = new ServiceReference1.LoginClient();

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            string res = login.Login(username, password);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}

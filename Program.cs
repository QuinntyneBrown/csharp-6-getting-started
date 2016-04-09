using Chloe.Server.Models;
using System;

namespace Chloe
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            Console.WriteLine(customer.Id);

            Console.ReadLine();
        }
    }
    
}

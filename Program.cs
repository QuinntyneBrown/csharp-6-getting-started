using Chloe.Server.Models;
using static System.Console;

namespace Chloe
{    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = Create();
            
            WriteLine($"CustomerId: {customer.Id}");

            ReadLine();
        }

        static Customer Create() => new Customer();
    }
    
}

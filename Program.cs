using Chloe.Server.Models;
using static System.Console;

namespace Chloe
{    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = Create();

            WriteEntity(customer);

            ReadLine();
        }

        static void WriteEntity(dynamic entity)
        {
            WriteLine($"{ entity.GetType().Name } { nameof(entity.Id) }: {entity.Id}");
        }
        static Customer Create() => new Customer();
    }
    
}

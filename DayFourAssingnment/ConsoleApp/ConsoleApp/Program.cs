using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          Person.Builder builder = new Person.Builder()
          {
              Name = "Sudrshan",
              Address = new Address.Builder { City = "Dhule", Street = "Gondur Road, Dhule" }.Build()
          };
          
          Person person = new Person(builder);

          Console.WriteLine("Person Details Name : {0}, Address - City {1}, Street {2}", person.Name, person.Address.City, person.Address.Street);

          Console.ReadKey();
        }
    }
}

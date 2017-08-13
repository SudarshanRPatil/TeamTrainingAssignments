using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public sealed class Person
    {
        public string Name { get; }
        public Address Address { get; }
        //public ImutableList<PhoneNumber> Phones { get; }

        public Person(Builder builder)
        {
            Name = builder.Name;
            Address = builder.Address;
            //Phones = Phones.ToImmutableList();
        }

        public sealed class Builder
        {
            public string Name { get; set; }
            public Address Address { get; set; }
            public List<PhoneNumber> Phones { get; } = new List<PhoneNumber>();

            public Person Build()
            {
                return new Person(this);
            }
        }
    }
}

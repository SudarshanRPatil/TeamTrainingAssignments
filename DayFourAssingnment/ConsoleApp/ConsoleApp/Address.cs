using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public sealed class Address
    {
        public string Street { get; }
        public string City { get; }

        private Address(Builder builder)
        {
            Street = builder.Street;
            City = builder.City;
        }

        public sealed class Builder
        {
            public string Street { get; set; }
            public string City { get; set; }

            public Address Build()
            {
                return new Address(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public sealed class PhoneNumber
    {
        public string Number { get; }
        public PhoneNumberType PhoneNumberType { get; }

        private PhoneNumber(Builder builder)
        {
            Number = builder.Number;
            PhoneNumberType = builder.PhoneNumberType;
        }

        public sealed class Builder
        {
            public string Number { get; set; }
            public PhoneNumberType PhoneNumberType { get; set; }

            public PhoneNumber Build()
            {
                return new PhoneNumber(this);
            }
        }
    }
}

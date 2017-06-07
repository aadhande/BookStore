using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Hateoas
{
    public class ValueWrappers
    {
        public object Value { get; }

        public ValueWrappers(object value)
        {
            Value = value;
        }
    }
}


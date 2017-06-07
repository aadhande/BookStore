using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Hateoas
{
    public class LinkWrappers
    {
        public class LinkWrapper
        {
            public object Value { get; }
            public ICollection<LinkValue> Links { get; }

            public LinkWrapper(object value)
            {
                Value = value;
            }
        }
    }
}

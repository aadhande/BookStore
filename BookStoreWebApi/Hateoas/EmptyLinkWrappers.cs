using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Hateoas
{
    public class EmptyLinkWrappers
    {
        public ICollection<LinkValue> Links { get; }

        public EmptyLinkWrappers()
        {
            Links = new List<LinkValue>();
        }
    }
}
    


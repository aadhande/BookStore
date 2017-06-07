using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Hateoas
{
    public class LinkContainers
    {

        public abstract class LinkContainer
        {
            public ICollection<LinkValue> Links { get; }

            public LinkContainer()
            {
                Links = new List<LinkValue>();
            }
        }
    }
}

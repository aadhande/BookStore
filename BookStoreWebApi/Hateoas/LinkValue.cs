using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Hateoas
{
    public class LinkValue
    {

        public string Rel { get; }
        public string Href { get; }

        public LinkValue(string rel, string href)
        {
            Rel = rel;
            Href = href;
        }
    }
}

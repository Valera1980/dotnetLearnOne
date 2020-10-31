using System.Linq;
using System.Collections.Generic;
using Education;

namespace LinqEducation
{
    public class FilterLinq
    {
        IEnumerable<User> collection;
        public FilterLinq( IEnumerable<User> c)
        {
            this.collection = c;
        }
    }
}

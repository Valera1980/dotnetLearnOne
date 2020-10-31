using System.Collections.Generic;
using System.Linq;
using Education;

namespace LinqEducation
{
    public class LinqOne
    {
        public IEnumerable<User> getUserQuerySyntax(IEnumerable<User> users)
        {
            var res = from u in users
                      where u.name == "111"
                      select u;
            return res;
        }
        public User getUserMethodSyntax(IEnumerable<User> list)
        {
           var res = list
           .Where(u =>  u.name == "111")
           .DefaultIfEmpty(new User())
           .FirstOrDefault<User>();
           return res;
        }
    }
}
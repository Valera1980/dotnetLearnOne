using System;
using Xunit;
using Education;

namespace User.Tets
{
    public class UnitTestUser
    {
        [Fact]
        public void TestOne()
        {
           Education.User u = new Education.User("nnn", "7897",23);
           Assert.Equal(u.name, "nnn0" );
        }
    }
}

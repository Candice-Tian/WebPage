using System;
using MVCPage.BLL;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest1
    {
        AddMethod add = new AddMethod();

        [Fact]
        public void Test1()
        {
            Assert.Equal(add.Add(34, 34), 34 + 34);
        }
    }
}

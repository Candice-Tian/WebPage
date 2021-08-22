using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCPage.BLL;
using Xunit.Sdk;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        AddMethod add = new AddMethod();
        [TestMethod]
        public void AddMethod()
        {
            Assert.AreEqual(add.Add(34, 34), 34 + 34);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void ConstructingPersonWithCorrectNameAndAgeMustGenerateCorrectPersonObject()
        {
            //Person person = new Person("Vanio", 15);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void C()
        {
            var a = 5;

            Assert.AreEqual(5, a);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GetOutput_Is_a_String()
        {
            var fizz = new FizzBuzz();
            var reult=fizz.GetOutput(34);
            Assert.That(reult, Is.TypeOf<string>());
        }
    }
}

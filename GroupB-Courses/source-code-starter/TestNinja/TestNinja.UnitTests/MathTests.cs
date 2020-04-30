using NUnit.Framework;
using System;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var number = math.Add(1, 2);
            Assert.That(number, Is.EqualTo(3));


        }
    }
}

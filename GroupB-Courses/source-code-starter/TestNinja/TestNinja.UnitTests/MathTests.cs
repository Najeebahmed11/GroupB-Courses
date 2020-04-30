using NUnit.Framework;
using System;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var number = math.Add(1, 2);
            Assert.That(number, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgumnet()
        {
            var math = new Math();
            var result=math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgumnet()
        {
            var math = new Math();
            var result = math.Max(1,2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgumnet()
        {
            var math = new Math();
            var result = math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}

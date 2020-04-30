using NUnit.Framework;
using System;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
        //setup
        //teardown
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var number = _math.Add(1, 2);
            Assert.That(number, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgumnet()
        {
            var result=_math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgumnet()
        {
            var result = _math.Max(1,2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgumnet()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}

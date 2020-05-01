using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemerritPointCalculatorTest
    {

        [Test]
        public void DemerritPountCalculator_On_Speed_Zero()
        {
            var log = new DemeritPointsCalculator();
            Assert.That(()=>log.CalculateDemeritPoints(-1),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}

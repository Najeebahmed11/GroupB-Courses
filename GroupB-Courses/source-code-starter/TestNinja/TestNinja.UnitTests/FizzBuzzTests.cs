using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_OutPUt_Is_A_string()
        {
            var re=FizzBuzz.GetOutput(3);
            Assert.That(re, Is.EqualTo("FizzBuzz"));
        }
    }
}

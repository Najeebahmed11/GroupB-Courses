﻿using NUnit.Framework;
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
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArgumnet(int a,int b,int expectedResult)
        {
            var result=_math.Max(a,b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

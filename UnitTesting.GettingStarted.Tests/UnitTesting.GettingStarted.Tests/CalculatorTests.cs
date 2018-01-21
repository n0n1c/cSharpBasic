using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 1)]
        public void Add_Always_ReturnsExpectedResults(int lhs, int rhs)
        {
            var systemUnderTest = new Calculator();
            var expected = lhs + rhs;
            Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expected));
        }
    }
}

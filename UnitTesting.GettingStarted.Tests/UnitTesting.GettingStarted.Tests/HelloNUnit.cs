﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class HelloNUnit
    {
        [Test]
        public void TestHelloNUnit()
        {
            Assert.That(true, Is.True);
        }
    }
}

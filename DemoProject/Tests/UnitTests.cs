﻿using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class UnitTests
    {
        [Test]
        [CategoryAttribute("OnBuild")]
        public void SomeUnitTest()
        {
            var expectedValue = "VALUE";
            var actualValue = "VALUE_FAIL!";

            actualValue
                .Should()
                .BeEquivalentTo(expectedValue);
        }
    }
}

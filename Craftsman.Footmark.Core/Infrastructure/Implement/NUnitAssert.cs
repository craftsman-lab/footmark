using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    class NUnitAssert : IAssert
    {
        public void Equal<T>(T expected, T actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public void Equal(double expected, double actual, int precision)
        {
            Assert.AreEqual(expected, actual, precision);
        }

        public void Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
        {
             // Assert.AreEqual(expected, actual);
        }

        public void Equal(decimal expected, decimal actual, int precision)
        {
            //Assert.AreEqual(expected, actual, precision);
        }

        public void Equal(DateTime expected, DateTime actual, TimeSpan precision)
        {
            ///Assert.AreEqual(expected, actual, precision);
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
        {
            throw new NotImplementedException();
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            throw new NotImplementedException();
        }

        public void Equal(string expected, string actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false)
        {
            throw new NotImplementedException();
        }

        public void Equal(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public void True(bool condition)
        {
            throw new NotImplementedException();
        }

        public void True(bool condition, string userMessage)
        {
            throw new NotImplementedException();
        }
    }
}

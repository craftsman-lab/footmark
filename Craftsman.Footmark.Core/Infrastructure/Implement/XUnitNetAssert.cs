using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    class XUnitNetAssert : IAssert
    {
        //public string Id => Guid.NewGuid().ToString();
        //public string Id { get { return Guid.NewGuid().ToString(); } }

        public string Id = Guid.NewGuid().ToString();

        public void Equal<T>(T expected, T actual)
        {
            Assert.Equal(expected, actual);
            //Assert.AreEqual(expected, actual);
        }

        public void Equal(double expected, double actual, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }

        public void Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
        {
            Assert.Equal(expected, actual, comparer);
        }

        public void Equal(decimal expected, decimal actual, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }

        public void Equal(DateTime expected, DateTime actual, TimeSpan precision)
        {
            Assert.Equal(expected, actual, precision);
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
        {
            Assert.Equal(expected, actual, comparer);
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Assert.Equal(expected, actual);
        }

        public void Equal(string expected, string actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false)
        {
            Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
        }

        public void Equal(string expected, string actual)
        {
            Assert.Equal(expected, actual);
        }

        public void True(bool condition)
        {
            Assert.True(condition);
        }

        public void True(bool condition, string userMessage)
        {
            Assert.True(condition, userMessage);
        }
    }
}

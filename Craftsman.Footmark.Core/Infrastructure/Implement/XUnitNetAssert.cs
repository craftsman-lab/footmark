using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    class XUnitNetAssert : IAssert
    {         
        public string Id = Guid.NewGuid().ToString();
        
        private readonly ILogger _logger;
        public XUnitNetAssert(
            ILogger logger
        )
        {
            _logger = logger;
        }
        public void Equal<T>(T expected, T actual)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual);
        }

        public void Equal(double expected, double actual, int precision)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, precision);
        }

        public void Equal<T>(T expected, T actual, IEqualityComparer<T> comparer)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, comparer);
        }

        public void Equal(decimal expected, decimal actual, int precision)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, precision);
        }

        public void Equal(DateTime expected, DateTime actual, TimeSpan precision)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, precision);
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, comparer);
        }

        public void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual);
        }

        public void Equal(string expected, string actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
        }

        public void Equal(string expected, string actual)
        {
            _logger.LogTrace("XUnitNetAssert.Equal 调用");
            Assert.Equal(expected, actual);
        }

        public void True(bool condition)
        {
            _logger.LogTrace("XUnitNetAssert.True 调用");
            Assert.True(condition);
        }

        public void True(bool condition, string userMessage)
        {
            _logger.LogTrace("XUnitNetAssert.True 调用");
            Assert.True(condition, userMessage);
        }
    }
}

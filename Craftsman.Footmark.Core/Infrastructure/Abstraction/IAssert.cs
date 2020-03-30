using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Abstraction
{
    public interface IAssert
    {
        void True(bool condition);
        void True(bool condition, string userMessage);

        void Equal<T>(T expected, T actual);
        void Equal(double expected, double actual, int precision);
        void Equal<T>(T expected, T actual, IEqualityComparer<T> comparer);
        void Equal(decimal expected, decimal actual, int precision);
        void Equal(DateTime expected, DateTime actual, TimeSpan precision);
        void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer);
        void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual);
        void Equal(string expected, string actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false);
        void Equal(string expected, string actual);
    }
}

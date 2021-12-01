using System;
using System.Collections.Generic;
using Xunit;

namespace BooLooToo.Tests
{
    public static class ArgumentEmptyTests
    {
        [Fact]
        public static void ThrowsArgumentExceptionWhenCollectionIsEmpty()
        {
            const string paramName = "aList";

            var ex = Assert.Throws<ArgumentException>(() => ThrowIf.ArgumentEmpty(new List<string>(), paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void ThrowsArgumentNullExceptionWhenCollectionIsNull()
        {
            const string paramName = "aList";

            var ex = Assert.Throws<ArgumentNullException>(() => ThrowIf.ArgumentEmpty((List<string>)null, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowExceptionWhenCollectionIsValid()
        {
            ThrowIf.ArgumentEmpty(new List<string>() { "Testing" }, "aString");
        }

        [Fact]
        public static void ThrowsArgumentExceptionWhenStringIsEmpty()
        {
            const string paramName = "aString";

            var ex = Assert.Throws<ArgumentException>(() => ThrowIf.ArgumentEmpty("", paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void ThrowsArgumentNullExceptionWhenStringIsNull()
        {
            const string paramName = "aString";

            var ex = Assert.Throws<ArgumentNullException>(() => ThrowIf.ArgumentEmpty((string)null, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowExceptionWhenStringIsValid()
        {
            ThrowIf.ArgumentEmpty("Not Empty", "aString");
        }
    }
}

using System;
using Xunit;

namespace Boolootoo.Tests
{
    public static class ArgumentBlankTests
    {
        [Fact]
        public static void ThrowsArgumentExceptionWhenStringIsBlank()
        {
            const string paramName = "aString";

            var ex = Assert.Throws<ArgumentException>(() => ThrowIf.ArgumentBlank(" \t", paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void ThrowsArgumentNullExceptionWhenStringIsNull()
        {
            const string paramName = "aString";

            var ex = Assert.Throws<ArgumentNullException>(() => ThrowIf.ArgumentBlank(null, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowExceptionWhenStringIsValid()
        {
            ThrowIf.ArgumentBlank("Not Empty", "aString");
        }
    }
}

using System;
using Xunit;

namespace BooLooTwo.Tests
{
    public static class ArgumentNullTests
    {
        [Fact]
        public static void ThrowsArgumentNullExceptionWhenArgumentIsNull()
        {
            const string paramName = "anObject";

            var ex = Assert.Throws<ArgumentNullException>(() => ThrowIf.ArgumentNull(null, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentNullExceptionWhenArgumentIsNotNull()
        {
            ThrowIf.ArgumentNull("I Am Not Null", "aString");
        }
    }
}
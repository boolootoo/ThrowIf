using System;
using Xunit;

namespace BooLooToo.Tests
{
    public static class ArgumentNotDefinedTests
    {
        enum TestEnum {
            Two = 2
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenValueIsNotDefinedEnum()
        {
            const string paramName = "anEnum";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNotDefined((TestEnum)9, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void EnsureIsDefinedEnumDoesNotThrowWhenValueIsDefinedEnum()
        {
            ThrowIf.ArgumentNotDefined(TestEnum.Two, "anEnum");
        }
    }
}
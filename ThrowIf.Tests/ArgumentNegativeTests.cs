using System;
using Xunit;

namespace Boolootoo.Tests
{
    public static class ArgumentNegativeTests
    {
        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenTimeSpanIsNegative()
        {
            const string paramName = "aTimeSpan";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(new TimeSpan(-1, 0, 0), paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenTimeSpanIsValid()
        {
            ThrowIf.ArgumentNegative(TimeSpan.Zero, "aTimeSpan");
            ThrowIf.ArgumentNegative(new TimeSpan(1, 2, 3), "aTimeSpan");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenIntegerIsNegative()
        {
            const string paramName = "anInteger";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(-1, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenIntegerIsValid()
        {
            ThrowIf.ArgumentNegative(0, "anInteger");
            ThrowIf.ArgumentNegative(1, "anInteger");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenLongIsNegative()
        {
            const string paramName = "aLong";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(-1L, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenLongIsValid()
        {
            ThrowIf.ArgumentNegative(0L, "aLong");
            ThrowIf.ArgumentNegative(1L, "aLong");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenShortIsNegative()
        {
            const string paramName = "aShort";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative((short)-1, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenShortIsValid()
        {
            ThrowIf.ArgumentNegative((short)0, "aShort");
            ThrowIf.ArgumentNegative((short)1, "aShort");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenDecimalIsNegative()
        {
            const string paramName = "aDecimal";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(-1m, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenDecimalIsValid()
        {
            ThrowIf.ArgumentNegative(0m, "aDecimal");
            ThrowIf.ArgumentNegative(1m, "aDecimal");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenFloatIsNegative()
        {
            const string paramName = "aFloat";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(-1f, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenFloatIsValid()
        {
            ThrowIf.ArgumentNegative(0f, "aFloat");
            ThrowIf.ArgumentNegative(1f, "aFloat");
        }

        [Fact]
        public static void ThrowsArgumentOutOfRangeExceptionWhenDoubleIsNegative()
        {
            const string paramName = "aDouble";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => ThrowIf.ArgumentNegative(-1d, paramName));

            Assert.Contains(paramName, ex.ParamName);
        }

        [Fact]
        public static void DoesNotThrowArgumentOutOfRangeExceptionWhenDoubleIsValid()
        {
            ThrowIf.ArgumentNegative(0d, "aDouble");
            ThrowIf.ArgumentNegative(1d, "aDouble");
        }
    }
}
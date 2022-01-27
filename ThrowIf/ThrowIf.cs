using System;
using System.Collections;

namespace Boolootoo
{
    /// <summary>
    /// Static helper class to enforce argument correctness by throwing when an argument is not suitable for a method.
    /// </summary>
    public static class ThrowIf
    {
        /// <summary>
        /// Throw an <see cref="ArgumentNullException"/> if the <see cref="Object"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="Object"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentNullException">If the <paramref name="argument"/> is null.</exception>
        public static void ArgumentNull(object argument, string nameOfArgument)
        {
            if (argument == null)
                throw new ArgumentNullException(nameOfArgument);
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="TimeSpan"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="TimeSpan"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(TimeSpan argument, string nameOfArgument)
        {
            if (argument < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameOfArgument, "TimeSpan must not be less than TimeSpan.Zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="int"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="int"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(int argument, string nameOfArgument)
        {
            if (argument < 0)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Integer must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="long"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="long"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(long argument, string nameOfArgument)
        {
            if (argument < 0L)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Long must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="short"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="short"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(short argument, string nameOfArgument)
        {
            if (argument < 0)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Short must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="decimal"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="decimal"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(decimal argument, string nameOfArgument)
        {
            if (argument < 0m)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Decimal must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="float"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="float"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(float argument, string nameOfArgument)
        {
            if (argument < 0f)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Float must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="double"/> is null.
        /// </summary>
        /// <param name="argument">The <see cref="double"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="argument"/> is negative.</exception>
        public static void ArgumentNegative(double argument, string nameOfArgument)
        {
            if (argument < 0)
                throw new ArgumentOutOfRangeException(nameOfArgument, "Double must not be less than zero.");
        }

        /// <summary>
        /// Throw an <see cref="ArgumentException"/> if the <see cref="String"/> is whitespace or <see cref="ArgumentNullException"/> if it is null.
        /// </summary>
        /// <param name="argument">The <see cref="String"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentException">If the <paramref name="argument"/> is whitespace or <see cref="ArgumentNullException"/> if it is null.</exception>
        public static void ArgumentBlank(string argument, string nameOfArgument)
        {
            ThrowIf.ArgumentNull(argument, nameOfArgument);

            if (String.IsNullOrWhiteSpace(argument))
                throw new ArgumentException("String must not be whitespace.", nameOfArgument);
        }

        /// <summary>
        /// Throw an <see cref="ArgumentException"/> if the <see cref="String"/> is empty or <see cref="ArgumentNullException"/> if it is null.
        /// </summary>
        /// <param name="argument">The <see cref="String"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentException">If the <paramref name="argument"/> is empty or <see cref="ArgumentNullException"/> if it is null.</exception>
        public static void ArgumentEmpty(string argument, string nameOfArgument)
        {
            ThrowIf.ArgumentNull(argument, nameOfArgument);

            if (argument == String.Empty)
                throw new ArgumentException("String must not be empty.", nameOfArgument);
        }

        /// <summary>
        /// Throw an <see cref="ArgumentException"/> if the <see cref="ICollection"/> is empty or <see cref="ArgumentNullException"/> if it is null.
        /// </summary>
        /// <param name="argument">The <see cref="ICollection"/> being checked.</param>
        /// <param name="nameOfArgument">Name of the argument being passed.</param>
        /// <exception cref="ArgumentException">If the <paramref name="argument"/> is empty or <see cref="ArgumentNullException"/> if it is null.</exception>
        public static void ArgumentEmpty(ICollection argument, string nameOfArgument)
        {
            ThrowIf.ArgumentNull(argument, nameOfArgument);

            if (argument.Count == 0)
                throw new ArgumentException("Collection must not be empty.", nameOfArgument);
        }

        /// <summary>
        /// Throw an <see cref="ArgumentOutOfRangeException"/> if the <see cref="Enum"/> is not defined.
        /// </summary>
        /// <param name="value">Enum to be checked.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <typeparam name="TEnum">Type of the enum being checked.</typeparam>
        /// <exception cref="ArgumentOutOfRangeException">If the <paramref name="value"/> is not defined.</exception>
        public static void ArgumentNotDefined<TEnum>(TEnum value, string nameOfArgument) where TEnum : struct
        {
            if (!Enum.IsDefined(typeof(TEnum), value))
                throw new ArgumentOutOfRangeException(nameOfArgument, $"Must be a defined {typeof(TEnum)} enum value.");
        }
    }
}
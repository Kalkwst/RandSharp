namespace RandSharp
{
    internal sealed class Validator
    {
        /// <summary>
        /// Validate the stream size.
        /// </summary>
        /// <param name="size">The stream size</param>
        /// <exception cref="ArgumentOutOfRangeException">if <see cref="size"/> is negative.</exception>
        static void ValidateStreamSize(long size)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(size);
        }

        /// <summary>
        /// Validate the upper bound.
        /// </summary>
        /// <param name="bound">The exlusive upper bound on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <see cref="bound"/> is negative.</exception>
        static void ValidateUpperBound(int bound)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(bound);
        }

        /// <summary>
        /// Validate the upper bound.
        /// </summary>
        /// <param name="bound">The exlusive upper bound on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <see cref="bound"/> is negative.</exception>
        static void ValidateUpperBound(long bound)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(bound);
        }

        /// <summary>
        /// Validate the upper bound.
        /// </summary>
        /// <param name="bound">The exlusive upper bound on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <see cref="bound"/> is negative or greater than <see cref="float.MaxValue"/>.</exception>
        static void ValidateUpperBound(float bound)
        {
            if (!(bound > 0.0f && bound <= float.MaxValue))
                throw new ArgumentOutOfRangeException(nameof(bound));
        }

        /// <summary>
        /// Validate the upper bound.
        /// </summary>
        /// <param name="bound">The exlusive upper bound on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <see cref="bound"/> is negative or greater than <see cref="double.MaxValue"/>.</exception>
        static void ValidateUpperBound(double bound)
        {
            if (!(bound > 0.0 && bound <= double.MaxValue))
                throw new ArgumentOutOfRangeException(nameof(bound));
        }

        /// <summary>
        /// Validate the range between the specified <paramref name="origin"/> (inclusive) and the specified <paramref name="bound"/> (exclusive).
        /// </summary>
        /// <param name="origin">The lower bound on the random number to be returned.</param>
        /// <param name="bound">The upper bound (exclusive) on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="origin"/> is greater than or equal to <paramref name="bound"/>.</exception>
        static void ValidateRange(int origin, int bound)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(origin, bound);
        }

        /// <summary>
        /// Validate the range between the specified <paramref name="origin"/> (inclusive) and the specified <paramref name="bound"/> (exclusive).
        /// </summary>
        /// <param name="origin">The lower bound on the random number to be returned.</param>
        /// <param name="bound">The upper bound (exclusive) on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="origin"/> is greater than or equal to <paramref name="bound"/>.</exception>
        static void ValidateRange(uint origin, uint bound)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(origin, bound);
        }


        /// <summary>
        /// Validate the range between the specified <paramref name="origin"/> (inclusive) and the specified <paramref name="bound"/> (exclusive).
        /// </summary>
        /// <param name="origin">The lower bound on the random number to be returned.</param>
        /// <param name="bound">The upper bound (exclusive) on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="origin"/> is greater than or equal to <paramref name="bound"/>.</exception>
        static void ValidateRange(long origin, long bound)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(origin, bound);
        }

        /// <summary>
        /// Validate the range between the specified <paramref name="origin"/> (inclusive) and the specified <paramref name="bound"/> (exclusive).
        /// </summary>
        /// <param name="origin">The lower bound on the random number to be returned.</param>
        /// <param name="bound">The upper bound (exclusive) on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="origin"/> is greater than or equal to <paramref name="bound"/>.</exception>
        static void ValidateRange(ulong origin, ulong bound)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(origin, bound);
        }

        /// <summary>
        /// Validate the range between the specified <paramref name="origin"/> (inclusive) and the specified <paramref name="bound"/> (exclusive).
        /// </summary>
        /// <param name="origin">The lower bound on the random number to be returned.</param>
        /// <param name="bound">The upper bound (exclusive) on the random number to be returned.</param>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="origin"/> is greater than or equal to <paramref name="bound"/>, <paramref name="origin"/> is not finite, or <paramref name="bound"/> is not finite.</exception>
        static void ValidateRange(double origin, double bound)
        {
            if (origin >= bound || double.IsFinite(origin) || double.IsFinite(bound))
            {
                throw new ArgumentOutOfRangeException(nameof(origin));
            }
        }

        /// <summary>
        /// Checks if the sub-range from <paramref name="fromIndex"/> (include) to <paramref name="fromIndex"/> + <paramref name="size"/> (exclusive) is
        /// within the bounds of range from 0 (inclusive) to <paramref name="length"/> (exclusive).
        /// </summary>
        /// <param name="fromIndex">The lower-bound (inclusive) of the sub-interval.</param>
        /// <param name="size">The size of the sub-range.</param>
        /// <param name="length">The upper-bound (exclusive) of the range.</param>
        /// <exception cref="ArgumentOutOfRangeException">If the subrange is out of bounds.</exception>
        static void ValidateFromIndexSize(int fromIndex, int size, int length)
        {
            if((fromIndex | size) < 0 || size > length - fromIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(size), $"Range [{fromIndex}, {fromIndex + size}) out of bounds for length {length}");
            }
        }
    }
}

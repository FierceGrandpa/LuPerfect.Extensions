namespace LuPerfect
{
    using System;

    public static partial class StringManipulationExtensions
    {
        public static string Truncate(this string input, int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be >= 0");

            var maxLength = Math.Min(input.Length, length);

            return input[..maxLength];
        }
    }
}
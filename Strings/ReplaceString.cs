namespace LuPerfect
{
    using System;
    using System.Text.RegularExpressions;

    public static partial class StringManipulationExtensions
    {
        public static string ReplaceString(this string text, string oldString, string newString, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count can not be negative");

            var regex = new Regex(Regex.Escape(oldString));

            return regex.Replace(text, newString, count);
        }
    }
}
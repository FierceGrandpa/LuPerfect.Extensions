namespace LuPerfect
{
    using System;

    public static partial class StringManipulationExtensions
    {
        public static string Reverse(this string input)
        {
            if (string.IsNullOrEmpty(input)) 
                return string.Empty;
            if (input.Length == 1) 
                return input;

            var result = input.Length > 1024 ? input.ToCharArray() : stackalloc char[input.Length];
            if (input.Length <= 1024)
                input.AsSpan().CopyTo(result);

            result.Reverse();

            return result.ToString();
        }
    }
}
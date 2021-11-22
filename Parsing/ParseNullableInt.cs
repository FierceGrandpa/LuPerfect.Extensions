namespace LuPerfect
{
    public static partial class ParsingExtensions
    {
        public static int? ParseNullableInt(this string input) => int.TryParse(input, out var result) ? result : null;
    }
}
namespace LuPerfect
{
    public static partial class StringManipulationExtensions
    {
        public static string Right(this string input, int length)
        {
            return input.Length <= length ? input : input[^length..];
        }
    }
}
namespace LuPerfect
{
    public static partial class StringManipulationExtensions
    {
        public static string ReplaceWithEmpty(this string input, string subStringToRemove)
        {
            return input.Replace(subStringToRemove, string.Empty);
        }
    }
}
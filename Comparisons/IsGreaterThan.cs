namespace LuPerfect
{
    public static partial class ComparableExtensions
    {
        public static bool IsGreaterThan<T>(this T a, T b) where T : IComparable => a.CompareTo(b) > 0;
    }
}
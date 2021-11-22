namespace LuPerfect
{
    public static partial class ComparableExtensions
    {
        public static bool IsLessThan<T>(this T a, T b) where T : IComparable => a.CompareTo(b) < 0;
    }
}
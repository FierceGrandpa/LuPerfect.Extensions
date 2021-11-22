namespace System.Collections.Generic
{
    public static partial class LinqExtensions
    {
        public static TU[] ToArray<T, TU>(this IEnumerable<T> source, Func<T, TU> selector)
            => source.Select(selector).ToArray();
    }
}
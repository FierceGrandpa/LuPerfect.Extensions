namespace System.Collections.Generic
{
    public static partial class LinqExtensions
    {
        public static IEnumerable<T> Perform<T>(this IEnumerable<T> input, Func<T, T> func)
        {
            foreach (var item in input)
            {
                yield return func(item);
            }
        }
    }
}
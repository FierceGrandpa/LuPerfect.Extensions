namespace System.Collections.Generic
{
    public static partial class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> input, Action<T> action)
        {
            foreach (var item in input)
            {
                action(item);
            }
        }
    }
}
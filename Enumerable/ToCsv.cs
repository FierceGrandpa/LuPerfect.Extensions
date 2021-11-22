using System.Text;

namespace System.Collections.Generic
{
    public static partial class EnumerableExtensions
    {
        public static string ToCsv<T>(this IEnumerable<T> input)
        {
            var csvBuilder = new StringBuilder();

            input.ForEach(i => csvBuilder.Append($"{i},"));

            return csvBuilder.ToString(0, csvBuilder.Length - 1);
        }
    }
}
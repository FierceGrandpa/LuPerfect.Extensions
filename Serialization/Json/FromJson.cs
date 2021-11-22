namespace System.Text.Json
{
    public static partial class JsonExtensions
    {
        public static T? FromJson<T>(this string t)
        {
            var value = JsonSerializer.Deserialize<T>(t);

            return (T?)Convert.ChangeType(value, typeof(T));
        }
    }
}
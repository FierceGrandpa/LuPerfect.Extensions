namespace System.Text.Json
{
    public static partial class JsonExtensions
    {
        public static string ToJson<T>(this T t) => JsonSerializer.Serialize(t);
    }
}
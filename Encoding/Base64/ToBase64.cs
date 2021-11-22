namespace System
{
    using Text;

    public static partial class Base64Extensions
    {
        public static string ToBase64(this string @string, Encoding? encoding = null)
        {
            var stringBytes = (encoding ?? Encoding.Default).GetBytes(@string);

            return Convert.ToBase64String(stringBytes);
        }
    }
}
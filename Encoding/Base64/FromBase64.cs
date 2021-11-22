using System.Text.RegularExpressions;

namespace System
{
    using Text;

    public static partial class Base64Extensions
    { 
        public static string FromBase64(this string encodedString, Encoding? encoding = null)
        {
            encodedString = encodedString.Trim();

            var isValidBase64 = encodedString.Length % 4 == 0 &&
                                Regex.IsMatch(encodedString, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

            if (!isValidBase64)
                throw new ArgumentException($"{encodedString} is not valid base64");

            var data = Convert.FromBase64String(encodedString);

            return (encoding ?? Encoding.Default).GetString(data);
        }
    }
}
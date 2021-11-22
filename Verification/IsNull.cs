namespace LuPerfect
{
    public static partial class VerificationExtensions
    {
        public static bool IsNull(this object value) => value is null;
        public static bool IsNull<T>(this T value) => value is null;
    }
}
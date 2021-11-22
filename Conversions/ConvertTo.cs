namespace LuPerfect
{
    public static partial class ConvertibleExtensions
    {
        public static TOut ConvertTo<TIn, TOut>(this TIn value) where TIn : struct, IConvertible
        {
            return (TOut)Convert.ChangeType(value, typeof(TOut));
        }
    }
}
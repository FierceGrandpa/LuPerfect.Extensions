namespace LuPerfect
{
    public static partial class MathExtensions
    {
        public static int MultiplyBy(this short multiplicand, short multiplier) => multiplicand * multiplier;
        public static int MultiplyBy(this short multiplicand, int multiplier) => multiplicand * multiplier;
        public static long MultiplyBy(this short multiplicand, long multiplier) => multiplicand * multiplier;

        public static int MultiplyBy(this int multiplicand, short multiplier) => multiplicand * multiplier;
        public static int MultiplyBy(this int multiplicand, int multiplier) => multiplicand * multiplier;
        public static long MultiplyBy(this int multiplicand, long multiplier) => multiplicand * multiplier;

        public static long MultiplyBy(this long multiplicand, short multiplier) => multiplicand * multiplier;
        public static long MultiplyBy(this long multiplicand, int multiplier) => multiplicand * multiplier;
        public static long MultiplyBy(this long multiplicand, long multiplier) => multiplicand * multiplier;
    }
}
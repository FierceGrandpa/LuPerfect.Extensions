namespace LuPerfect
{
    public static partial class MathExtensions
    {
        public static int Minus(this short minuend, short subtrahend) => minuend - subtrahend;
        public static int Minus(this short minuend, int subtrahend) => minuend - subtrahend;
        public static int Minus(this int minuend, short subtrahend) => minuend - subtrahend;
        public static int Minus(this int minuend, int subtrahend) => minuend - subtrahend;

        public static long Minus(this int minuend, long subtrahend) => minuend - subtrahend;
        public static long Minus(this short minuend, long subtrahend) => minuend - subtrahend;
        public static long Minus(this long minuend, short subtrahend) => minuend - subtrahend;
        public static long Minus(this long minuend, int subtrahend) => minuend - subtrahend;
        public static long Minus(this long minuend, long subtrahend) => minuend - subtrahend;
    }
}
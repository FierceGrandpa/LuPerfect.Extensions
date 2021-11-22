namespace LuPerfect
{
    public static partial class MathExtensions
    {
        public static int Add(this short augend, short addend) => augend + addend;
        public static int Add(this short augend, int addend) => augend + addend;
        public static long Add(this short augend, long addend) => augend + addend;

        public static int Add(this int augend, short addend) => augend + addend;
        public static int Add(this int augend, int addend) => augend + addend;
        public static long Add(this int augend, long addend) => augend + addend;

        public static long Add(this long augend, short addend) => augend + addend;
        public static long Add(this long augend, int addend) => augend + addend;
        public static long Add(this long augend, long addend) => augend + addend;
    }
}
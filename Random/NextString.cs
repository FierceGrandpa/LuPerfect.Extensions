namespace System
{
    public static partial class RandomExtensions
    {
        public static string NextString(this Random random, int length)
        {
            var chars = Enumerable
                .Range(0, length)
                .Select(_ => (char)random.Next(0, 128));

            return string.Concat(chars);
        }
    }
}
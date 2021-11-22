using System.Text;

namespace LuPerfect
{
    public static partial class StringManipulationExtensions
    {
        public static string Capitalize(this string str)
        {
            return new StringBuilder(str)
                .Remove(0, 1)
                .Insert(0, str[0].ToString().ToUpper())
                .ToString();
        }
    }
}
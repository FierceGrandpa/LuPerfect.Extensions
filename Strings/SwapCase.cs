namespace LuPerfect
{
    using System.Text;

    public static partial class StringManipulationExtensions
    {
        public static string SwapCase(this string text)
        {
            var result = new StringBuilder();

            foreach (var ch in text)
            {
                if (char.IsUpper(ch))
                {
                    result.Append(char.ToLower(ch));
                }
                else if (char.IsLower(ch))
                {
                    result.Append(char.ToUpper(ch));
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
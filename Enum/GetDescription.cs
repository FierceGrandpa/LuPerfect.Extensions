using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
    public static partial class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var attr = value
                .GetType()
                .GetField(value.ToString())?
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attr is {Length: > 0})
                return ((DescriptionAttribute)attr[0]).Description;

            var result = value.ToString();
            result = Regex.Replace(result, "([a-z])([A-Z])", "$1 $2");
            result = Regex.Replace(result, "([A-Za-z])([0-9])", "$1 $2");
            result = Regex.Replace(result, "([0-9])([A-Za-z])", "$1 $2");
            result = Regex.Replace(result, "(?<!^)(?<! )([A-Z][a-z])", " $1");
            
            return result;
        }

        public static List<string> GetDescriptionList(this Enum value) => value.GetDescription().Split(',').ToList();
    }
}
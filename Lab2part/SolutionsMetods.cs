using System.Linq;

namespace Lab2part
{
    public static class Extensions
    {
        public static string AddCommas(this string input)
        {
            return string.Join(", ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        public static Set<T> RemoveDuplicates<T>(this Set<T> set)
        {
            return new Set<T>(set.elements.Distinct());  
        }
    }
}
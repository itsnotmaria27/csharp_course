using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math1
{
    public class CodewarsTask
    {
        //1
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            var qualifiedLanguages = new List<string>();

            foreach (var kvp in results)
            {
                if (kvp.Value >= 60)
                {
                    qualifiedLanguages.Add(kvp.Key);
                }
            }

            qualifiedLanguages.Sort((a, b) => results[b].CompareTo(results[a]));

            return qualifiedLanguages;
        }
        //2
        public static bool Solution(string str, string ending)
        {
            if (ending.Length > str.Length)
                return false;
            if (ending.Length == 0)
                return true;
            for (int i = 0; i < ending.Length; i++)
            {
                if (str[str.Length - ending.Length + i] != ending[i])
                    return false;
            }
            return true;
        }
        //3
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    result.Add((int)item);
                }
            }
            return result;
        }
        //4
        public static int? ToCents(this string price)
        {
            if (string.IsNullOrEmpty(price) || !price.StartsWith("$"))
            {
                return null;
            }

            string[] parts = price.Substring(1).Split('.');
            if (parts.Length != 2 || parts[1].Length != 2)
                return null;

            if (int.TryParse(parts[0] + parts[1], out int totalCents))
                return totalCents;

            return null;
        }
        //5
        public static bool Vowel(this string s)
        {
            if (s.Length == 1 && "aeiouAEIOU".Contains(s))
                return true;

            return false;
        }
    }
}

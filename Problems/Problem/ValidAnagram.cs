using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length == t.Length)
            {
                // normal think O(n log(n))
                //var sortedS = s.ToCharArray();
                //var sortedT = t.ToCharArray();
                //Array.Sort(sortedS);
                //Array.Sort(sortedT);
                //var flag = true;
                //for (int i = 0; i < sortedS.Length; i++)
                //    if (sortedS[i] != sortedT[i])
                //        flag = false;
                //return flag;

                // better think O(n)
                Dictionary<char, int> counts = new Dictionary<char, int>();
                foreach (char c in s)
                    counts[c] = counts.GetValueOrDefault(c, 0) + 1;

                foreach (char c in t)
                {
                    if (!counts.ContainsKey(c) || counts[c] == 0) return false;
                    counts[c]--;
                }
                return true;
            }
            return false;
        }
    }
}

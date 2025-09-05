using Microsoft.VisualBasic;
using Problems.Problem;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "racecar";
            string t = "carrace";
            Console.WriteLine(ValidAnagram.IsAnagram(s, t));
        }
    }
}

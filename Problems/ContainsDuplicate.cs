using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ContainsDuplicate
    {
        public static bool HasDuplicate(int[] nums)
        {
            // normal think O(n^2)
            //bool flag = false;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int k = i; k < nums.Length - 1; k++)
            //    {
            //        if (nums[i] == nums[k + 1])
            //        {
            //            flag = true;
            //            break;
            //        }
            //    }
            //}
            //return flag;

            // better Solve O(n log n)
            //Array.Sort(nums);
            //bool flag = false;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1])
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //return flag;

            // best Solve O(n)
            return new HashSet<int>(nums).Count == nums.Length ? false : true;
        }
    }
}

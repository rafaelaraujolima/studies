using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies
{
    internal static class SolutionTwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Hashtable complements = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (complements.ContainsKey(target - nums[i]))
                    return [(int)complements[target - nums[i]], i];
                else if (!complements.ContainsKey(nums[i]))
                    complements.Add(nums[i], i);
            }
            return null;
        }
    }
}

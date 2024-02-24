//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

//Note that you must do this in-place without making a copy of the array.

//Example 1:

//Input: nums = [0, 1, 0, 3, 12]
//Output: [1,3,12,0,0]
//Example 2:

//Input: nums = [0]
//Output: [0]
 

//Constraints:

//1 <= nums.length <= 104
//- 231 <= nums[i] <= 231 - 1

//Follow up: Could you minimize the total number of operations done?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies
{
    internal static class SolutionMoveZeroes
    {
        public static int[] MoveZeroes(int[] nums)
        {
            int a = 0;
            int b = 1;

            while (b < nums.Length)
            {
                if (nums[a] == 0 && nums[b] != 0)
                {
                    nums[a] = nums[b];
                    nums[b] = 0;
                    a++;
                    b++;
                }
                else if (nums[a] == 0 && nums[b] == 0)
                    b++;
                else
                {
                    a++;
                    b++;
                }
            }

            return nums;
        }
    }
}

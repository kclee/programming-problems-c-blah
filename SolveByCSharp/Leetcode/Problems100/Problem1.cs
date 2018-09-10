using System.Collections.Generic;

namespace SolveByCSharp.Leetcode.Problems100
{
    public static class Problem1
    {
        public static void Run()
        {
            var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            System.Collections.Generic.Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dict[target - nums[i]] };
                }

                if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
            }
            return new int[] { 0, 0 };
        }
    }
}

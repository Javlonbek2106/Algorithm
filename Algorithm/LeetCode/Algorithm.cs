﻿namespace Algorithm.LeetCode
{
    public class Algorithm
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    result.Add(nums[i]);
                }
            }
            return false;
        }
    }
}

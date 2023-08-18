using System.Collections;

namespace Algorithm.LeetCode
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
        public static int MajorityElement(int[] nums)
        {
            int candidate = 0;
            int count = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                    count = 1;
                }
                else if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}

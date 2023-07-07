namespace Algorithm.Sort
{
    public class BubbleSort
    {
        public static int[] SortArray(int[] nums)
        {
            int length = nums.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        nums[j] = nums[j] + nums[j + 1];
                        nums[j + 1] = nums[j] - nums[j + 1];
                        nums[j] = nums[j] - nums[j + 1];
                    }
                }
            }
            return nums;
        }
    }
}


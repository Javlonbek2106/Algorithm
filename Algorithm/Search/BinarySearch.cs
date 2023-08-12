namespace Algorithm.Search
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int num)
        {
            int left = 0, right = nums.Length-1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == num)
                {
                    return mid;
                }
                else if (nums[mid] < num)
                {
                    left = mid + 1;
                }
                else { right = mid + 1; }
            }
            return -1;
        }
    }
}


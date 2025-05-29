using System.Diagnostics;

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

        public static int TotalMoney(int n)
        {
            int sum = 0;
            if (n == 0)
                return sum;
            for (int i = 1; i <= n / 7; i++)
            {
                for (int j = i; j < i + 7; j++)
                {
                    sum += j;
                }
            }
            if (n % 7 != 0)
            {
                for (int i = 0; i < n % 7; i++)
                {
                    sum += n / 7 + 1 + i;
                }
            }
            return sum;
        }

        public static string MergeAlternately(string word1, string word2)
        {
            string result = string.Empty;

            int minLength = word1.Length >= word2.Length ? word2.Length : word1.Length;

            for (int i = 0; i < minLength; i++)
            {
                result += word1[i];
                result += word2[i];
            }

            result += (minLength == word1.Length) ? word2.Substring(minLength) : word1.Substring(minLength);

            return result;
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            string result = string.Empty;
            int minLength = str1.Length >= str2.Length ? str2.Length : str1.Length;
            int maxLength = str1.Length >= str2.Length ? str1.Length : str2.Length;
            if (str1[0] != str2[0]) return result;
            else if (str1.Substring(0, minLength) == str2.Substring(0, minLength))
            {
                if (maxLength % minLength == 0)
                {
                    return result;
                }
                return result;
            }
            else
            {
                return result;
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ints = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ints[0] = i;
                        ints[1] = j;
                        return ints;
                    }
                }
            }
            return ints;
        }

        public static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int total = 0;
            var romanToInt = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && romanToInt[s[i]] < romanToInt[s[i + 1]])
                {
                    total -= romanToInt[s[i]];
                }
                else
                {
                    total += romanToInt[s[i]];
                }
            }
            return total;
        }

        public static (int maxArea, TimeSpan duration) MaxArea(int[] height)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int minHeight = Math.Min(height[i], height[j]);
                    int width = j - i;
                    result = Math.Max(result, minHeight * width);
                }
            }

            stopwatch.Stop();
            return (result, stopwatch.Elapsed);
        }
    }
}
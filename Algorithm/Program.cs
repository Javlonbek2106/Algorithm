using Algorithm.LeetCode;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int arg in BubbleSort.SortArray(new int[] {4,1,2,3,8,4,7,3,0,7,9 }))
            //{
            //    Console.Write(" "+ arg);
            //}
            //Console.WriteLine(BinarySearch.Search(nums,7));
            //Console.WriteLine(Algorithm.LeetCode.Algorithm.MajorityElement(new int[] { 1,2,3,4,5,6,7,1,1,1,1,7,7,7,5,5,5,5,5 }));
            string n = LeetCode.Algorithm.GcdOfStrings("ABCABC", "ABC");
            Console.WriteLine(n);
        }
    }
}
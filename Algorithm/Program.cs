using Algorithm.Sort;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int arg in BubbleSort.SortArray(new int[] {12,1,3,56,25,45,1,2,5,8,9,78 }))
            {
                Console.Write(" "+ arg);
            }
        }
    }
}
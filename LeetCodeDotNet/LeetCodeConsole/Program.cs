using System.Xml.Serialization;

namespace LeetCodeConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MergeSortedArray();
        }

        public static void MergeSortedArray()
        {
            int[] nums1 = {-1,0,0,3,3,3,0,0,0}; 
            int[] nums2 = {1, 2, 2}; 
            int m = 6, n = 3;
            // [-1,0,0,1,2,2,3,3,3]
            // int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            // int[] nums2 = { 2, 5, 6 };
            // int m = 3, n = 3;


            var lib = new LeetCodeLibrary.Easy.MergeSortedArray();
            lib.Merge(nums1, m, nums2, n);
            var foo = "[" + string.Join(",", nums1) + "]";
            Console.Write(foo);
        }
    }
}

using System;

namespace LeetCode1Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ArrayPairSum(new int[]{1,2,4,3,5,6}));
        }

		public static int ArrayPairSum(int[] nums)
		{
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sum += nums[i]; 
                }
            }
            return sum;
		} 
    }
}

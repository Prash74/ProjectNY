using System;

namespace LeetCode1Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(ArrayPairSum(new int[]{1,2,4,3,5,6}));
            //Console.WriteLine(MatrixReshape(new int[,] { { 1, 2 }, { 3, 4 } }, 1, 4));
            Console.WriteLine(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));
        }

        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int row = nums.GetLength(0);
            int column = nums.GetLength(1);

            if(row*column != r*c)
            {
                return nums;
            }

            int[] newLinearMatrix = new int[row * column];

            int k = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    newLinearMatrix[k++] = nums[i,j];
                }
            }

            k = 0;
            int[,] newMatrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    newMatrix[i, j] = newLinearMatrix[k++];
                }
            }

            return newMatrix;
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

		public static int FindMaxConsecutiveOnes(int[] nums)
		{
			int max = 0, current = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 0)
				{
					current = 0;
				}
				else
				{
					current += 1;
				}
				if (current > max)
				{
					max = current;
				}
			}
            return max;
		}
    }
}

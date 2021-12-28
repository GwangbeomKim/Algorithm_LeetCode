using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class MoveZeroes
    {
        public void MoveZeroToEnd()
        {
            try
            {   //Argument variable
                int[] arr = { 6, 0, 4, 8, 5, 0, 3, 7, 12 };

                //Implement Algorithm
                RunMoveZeroes(arr);

                //Print int array
                foreach(var item in arr)
                {
                    Console.Write(item.ToString() + " ");
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
        }

        public int[] RunMoveZeroes(int[] nums)
        {
            try
            {
                int end = nums.Length;
                if (nums == null || nums.Length == 0)
                    return nums;

                for (int i = 0; i < end; i++)
                {
                    if (nums[i] == 0)
                    {
                        for (int j = i; j < end - 1; j++)
                        { nums[j] = nums[j + 1]; }

                        nums[end - 1] = 0;
                        end--;
                        i--;
                    }
                }
                return nums;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

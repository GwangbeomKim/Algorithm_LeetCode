using System;
using System.Collections.Generic;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class MoveZeroes
    {   /// <summary>
        /* Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        Note that you must do this in-place without making a copy of the array. */
        /// </summary>
        public void A_MoveZeroToEnd()
        {
            try
            {   //Argument variable
                int[] arr = { 6, 0, 4, 8, 5, 0, 3, 7, 12 };

                //Implement Algorithm
                RunAlgorithm(arr);

                //Print int array
                foreach(var item in arr)
                {
                    Console.Write(item.ToString() + " ");
                }
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

        private int[] RunAlgorithm(int[] nums)
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
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

    }
}

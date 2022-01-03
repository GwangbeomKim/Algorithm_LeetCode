using System;
using System.Collections.Generic;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    /// <summary>
    /* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order. */
    /// </summary>
    class TowSum
    {
        public void A_TowSum()
        {
            try
            {   //Argument variable
                int[] arr = { 2, 5, 7, 11, 15 };
                int target = 18;

                //Implement Algorithm
                int[] result = RunAlgorithm(arr, target);

                //Print int array
                foreach (var item in result)
                {
                    Console.Write(arr[item].ToString() + ",");
                }
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

        private int[] RunAlgorithm(int[] numbers, int target)
        {
            try
            {
                int first = 0, second = numbers.Length - 1, sum;
                while (true)
                {
                    sum = numbers[first] + numbers[second];
                    if (sum == target)
                        break;
                    else if (sum < target)
                        first += 1;
                    else
                        second -= 1;
                }
                return new int[2] { first, second };
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

    }
}

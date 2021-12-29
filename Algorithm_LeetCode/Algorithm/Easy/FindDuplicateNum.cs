using System;
using System.Collections.Generic;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class FindDuplicateNum
    {
        public void FindDuplicate()
        {
            try
            {   //Argument variable
                int[] arr = { 1, 2, 4, 12, 5, 6, 2, 7, 12 };
                
                //Implement Algorithm
                RunAlgorithm(arr);
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }
        private int RunAlgorithm(int[] numRay)
        {
            try
            {
                for (int i = 0; i < numRay.Length; i++)
                {
                    numRay[numRay[i] % numRay.Length]
                        = numRay[numRay[i] % numRay.Length]
                        + numRay.Length;
                }

                Console.WriteLine("The repeating elements are : ");
                for (int i = 0; i < numRay.Length; i++)
                {
                    if (numRay[i] >= numRay.Length * 2)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class FirstBadVersion
    {
        /// <summary>
        /*You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.
          Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad. */
        /// </summary>
        public void FindFirstBadVersion()
        {
            try
            {   //Argument variable
                int startNum = 10;

                //Implement Algorithm
                int Badversion = RunFirstBadVersion(startNum);
                Console.WriteLine(Badversion);
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

        private int RunFirstBadVersion(int n)
        {
            try
            {
                int low = 0;
                int high = n;

                while (low < high)
                {
                    int mid = low + (high - low) / 2;
                    if (isBadNumCheck(mid))
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                return low;
            }
            catch (Exception ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }
        private bool isBadNumCheck(int num)
        {
            try
            {   // Randomly assign badversion number
                Random r = new Random();
                int rndNum = r.Next(1, 10);

                if (num <= rndNum)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class FirstBadVersion
    {
        public void FindFirstBadVersion()
        {
            try
            {   //Argument variable
                int startNum = 10;

                //Implement Algorithm
                int Badversion = RunFirstBadVersion(startNum);
                Console.WriteLine(Badversion);
            }
            catch (ArgumentException e)
            {
                throw e;
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
            catch (Exception e)
            {
                throw e;
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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

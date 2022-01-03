using System;
using System.Collections.Generic;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Medium
{
    class ReverseInteger
    {
        public void A_ReverseInteger()
        {
            try
            {   //Argument variable
                int num = 369;

                //Implement Algorithm
                RunAlgorithm(num);

            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }
        private int RunAlgorithm(int num)
        {
            try
            {   // Check Negative
                bool isNegative = num < 0;
                
                if (isNegative)
                { num *= -1; }

                int temp = 0;
                int preVal = 0;
                while (num != 0)
                {
                    preVal = temp;
                    temp *= 10;
                    temp += num % 10;
                    if ((temp - (num % 10)) / 10 != preVal)
                        return 0;
                    num /= 10;
                }

                return isNegative ? temp * -1 : temp;
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

    }
}

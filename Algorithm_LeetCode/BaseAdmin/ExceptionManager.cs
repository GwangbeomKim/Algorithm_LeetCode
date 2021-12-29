using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_LeetCode.BaseAdmin
{
    class ExceptionManager
    {
        /// <summary>
        /// Log Error
        /// </summary>
        /// <param name="now">DateTime</param>
        /// <param name="algorithm">Algorithm Name</param>
        /// <param name="msg">MSG</param>
        public static void LogErr(DateTime now, string algorithm, string msg)
        {
            string strLogText = "[{0}] {1} | ErrMsg:{2}";
            strLogText = string.Format(strLogText, now.ToString(), algorithm, msg);

            Console.WriteLine(strLogText);
        }




    }
}

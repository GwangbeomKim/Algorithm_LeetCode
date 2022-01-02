using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm_LeetCode.BaseAdmin;

namespace Algorithm_LeetCode.Algorithm.Easy
{
    class LengthOfLastWord
    {
        /// <summary>
        /*Given a string s consisting of some words separated by some number of spaces, return the length of the last word in the string.
        A word is a maximal substring consisting of non-space characters only. */
        /// </summary>
        public void A_LengthOfLastWord()
        {
            try
            {   //Argument variable
                string sentence = "Welcome to my algorithm solution answer";

                //Implement Algorithm
                RunAlgorithm(sentence);
            }
            catch (ArgumentException ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

        private void RunAlgorithm(string sentence)
        {
            try
            {   // Using LINQ operator
                string lastWord = sentence.Split(' ').Last();

                int count = lastWord.Length;

                Console.WriteLine(count.ToString());

            }
            catch (Exception ex)
            {
                ExceptionManager.LogErr(DateTime.Now, this.GetType().Name.ToString(), ex.ToString());
                throw ex;
            }
        }

    }
}

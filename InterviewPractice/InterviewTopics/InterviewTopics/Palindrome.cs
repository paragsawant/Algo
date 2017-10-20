using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    /// <summary>
    /// 
    /// </summary>
    public class Palindrome
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool isPalindrome(string input)
        {
            int inputLength = input.Length;
            for (int i = 0; i < inputLength / 2; i++)
            {
                if (input[i] != input[inputLength - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool isPalindrome(int input)
        {
            int reversed = 0, n = input;

            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n = n / 10;
            }

            return input == reversed;
        }
    }
}

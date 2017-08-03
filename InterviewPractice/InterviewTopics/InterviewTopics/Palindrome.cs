using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class Palindrome
    {
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

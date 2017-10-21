using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class Anagram
    {
        public bool isAnagram(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) && string.IsNullOrEmpty(input2))
            {
                return true;
            }

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || input1.Length != input2.Length)
            {
                return false;
            }

            Array array1 = input1.ToCharArray();
            Array.Sort(array1);
            Array array2 = input2.ToCharArray();
            Array.Sort(array2);
            bool result = string.Compare(array1.ToString(), array2.ToString(), StringComparison.Ordinal)==0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (array1.ToString()[i] != array2.ToString()[i])
                {
                    return false;
                }
            }

            return true;
            //return array1.ToString().Equals(array2.ToString(),StringComparison.Ordinal);
            //return Array.Equals(array1,array2);
        }
    }
}

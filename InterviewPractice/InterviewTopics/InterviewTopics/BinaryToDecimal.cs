using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public static class BinaryToDecimal
    {
        public static int Convert(string s)
        {
            if (s == "")
                throw new ArgumentNullException("No input");

            int OnOff = 0;
            int result = 0;

            //Loop through each character in the passed string
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    //Parse each char of the passed string
                    OnOff = Int32.Parse(s[i].ToString());

                    //If the char is a 1, add 2^(the position it's in) to the result
                    if (OnOff == 1)
                        result += (int)Math.Pow(2, s.Length - 1 - i);

                    else if (OnOff > 1)
                        throw new Exception("Invalid input");
                }
                catch
                {
                    throw new Exception("Invalid input");
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics.DP
{
    public class LongestCommonSubsequence
    {

        public int LCS(string input1, string input2)
        {
            int inputLength1 = input1.Length;
            int inputLength2 = input2.Length;

            int[,] result = new int[inputLength1 + 1, inputLength2 + 1];

            for (int i = 0; i <= inputLength1; i++)
            {
                for (int j = 0; j <= inputLength2; j++)
                {
                    if (i == 0)
                    {
                        result[i, j] = i;
                    }
                    else if (j == 0)
                    {
                        result[i, j] = j;
                    }
                    else if (input1[i - 1] == input2[j - 1])
                    {
                        result[i, j] = result[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        result[i, j] = Helper.maxValue(result[i - 1, j], result[i, j - 1]);
                    }
                }
            }

            return result[inputLength1, inputLength2];
        }
    }
}

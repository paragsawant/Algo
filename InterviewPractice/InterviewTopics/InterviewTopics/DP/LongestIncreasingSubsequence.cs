using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics.DP
{
    public class LongestIncreasingSubsequence
    {
        public int LIS(int[] inputs)
        {
            int inputLength = inputs.Length;
            int returnValue = 0;
            if (inputLength == 1)
            {
                return 1;
            }

            int[] lis = new int[inputLength];
            for (int x = 0; x < inputLength; x++)
            {
                lis[x] = 1;
            }
            for (int i = 1; i < inputLength; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (inputs[i] > inputs[j] && lis[j] + 1 > lis[i])
                    {
                        lis[i] = lis[j] + 1;
                        returnValue = returnValue > lis[i] ? returnValue : lis[i];
                    }
                }
            }

            return returnValue;
        }
    }
}

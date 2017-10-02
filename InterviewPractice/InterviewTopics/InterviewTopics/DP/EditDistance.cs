using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics.DP
{
    public class EditDistance
    {
        public int ED(string input, string output, int inputLength, int outputLength)
        {
            int[,] resultTable = new int[inputLength + 1, outputLength + 1];

            for (int i = 0; i <= inputLength; i++)
            {
                for (int j = 0; j <= outputLength; j++)
                {
                    if (i == 0)
                    {
                        resultTable[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        resultTable[i, j] = i;
                    }
                    else if (input[i - 1] == output[j - 1])//equal
                    {
                        resultTable[i, j] = resultTable[i - 1, j - 1];
                    }
                    else//not equal
                    {
                        resultTable[i, j] = 1 + Helper.minValue(resultTable[i, j - 1], resultTable[i - 1, j - 1], resultTable[i - 1, j]);
                    }

                }
            }

            return resultTable[inputLength, outputLength];
        }
    }
}

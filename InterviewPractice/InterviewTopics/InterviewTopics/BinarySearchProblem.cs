using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class BinarySearchProblem
    {
        public int FindElementAppearsOnceintheArray(int element, int[] arr)
        {
            return 0;
        }

        public int SearchToFindUnique(int[] inputs)
        {
            int low = 0;
            int high = inputs.Length - 1;

            if (low > high)
            {
                return -1;
            }

            if (low == high)
            {
                return inputs[low];
            }

            while (low <= high)
            {
                if (low == high)
                {
                    return inputs[low];

                }

                int mid = (low + high) / 2;

                if (mid % 2 == 0)
                {
                    if (inputs[mid] == inputs[mid - 1])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 2;
                    }
                }
                else
                {
                    if (inputs[mid] == inputs[mid + 1])
                    {
                        low = mid - 2;
                    }
                    else
                    {
                        high = mid + 1;
                    }
                }
            }

            return -1;
        }

        public int BinarySearch(int element, int[] inputs)
        {
            int low = 0;
            int high = inputs.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (inputs[mid] == element)
                {
                    return mid;
                }
                else if (inputs[mid] < element)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}

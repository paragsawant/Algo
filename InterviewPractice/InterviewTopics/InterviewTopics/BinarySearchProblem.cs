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
        Stack<int> stack = new Stack<int>();
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

        public int FindElementInRoatedArray(int low, int high, int element, int[] inputs)
        {

            int mid = (low + high) / 2;
            if (inputs[mid] == element)
            {
                return mid;
            }

            if (inputs[low] <= inputs[mid])
            {
                if (element >= inputs[low] && element < inputs[mid])
                {
                    return FindElementInRoatedArray(low, mid - 1, element, inputs);
                }

                return FindElementInRoatedArray(mid + 1, high, element, inputs);
            }
            else if (element >= inputs[mid] && element < inputs[high])
            {
                return FindElementInRoatedArray(mid + 1, high, element, inputs);
            }

            return FindElementInRoatedArray(low, mid - 1, element, inputs);
        }

        public int SearchElementInRoatedArray(int[] inputs, int element)
        {

            int low = 0;
            int high = inputs.Length - 1;

            if (low > high)
            {
                return -1;
            }
            if (inputs[low] == element)
            {
                return 0;
            }

            if (inputs[high] == element)
            {
                return high;
            }

            return FindElementInRoatedArray(low, high, element, inputs);
        }
    }
}

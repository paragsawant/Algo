using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class ArrayProblems
    {
        #region 5

        /*
        Search an element in an array where difference between adjacent elements is 1.
        For example: arr[] = {8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3}
        Search for 3 and Output: Found at index 7
        */
        //Solution 1:
        public int SearchElement1(int[] inputs, int item)
        {
            for (int i = 0; i < inputs.Length - 1; i++)
            {
                if (inputs[i] == item)
                {
                    if (i == 0 || i == inputs.Length - 1)
                    {
                        return -1;
                    }

                    if (Math.Abs(inputs[i - 1] - item) == 1 && Math.Abs(inputs[i + 1] - item) == 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
        //Solution 2: 
        public int SearchElement2(int[] inputs, int item)
        {
            int length = inputs.Length - 1;
            int count = 0;
            while (count < length)
            {
                if (item == inputs[count])
                {
                    return count;
                }

                count = count + Math.Abs(inputs[count] - item);
            }

            return -1;
        }

        #endregion 5

        #region 2

        /* A magic index in an array A[0…n - 1] is defined to be an index such that A[i] = i.
         * Given a sorted array of distinct integers, 
         * write a method to find a magic index if one exists, in an array A.
         * FOLLOW UP: What if the values are not distinct?
         * 
         * Solution : 1) I have decide to use Binary Search instead of Liner Search here. O(logn)
             */
        public int MagicIndex(int[] inputs)
        {
            int low = 0;
            int high = inputs.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (inputs[mid] == mid)
                {
                    return mid;
                }
                else if (inputs[mid] < mid)
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


        public int MagicIndexForNonDistinct(int[] inputs)
        {
            int low = 0;
            int high = inputs.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (inputs[mid] == mid)
                {
                    return mid;
                }
                else if (inputs[mid] < mid)
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

        public int MagicIndexRec(int[] inputs, int low, int high)
        {
            int mid = (low + high) / 2;
            if (inputs[mid] == mid)
            {
                return mid;
            }

            int index;

            int lindex = Math.Min(mid - 1, inputs[mid]);
            index = MagicIndexRec(inputs, low, lindex);
            if (index>=0)
            {
                return index;
            }

            int rindex = Math.Max(mid + 1, inputs[mid]);
            return MagicIndexRec(inputs, rindex, high);
        }

        #endregion 2

    }
}

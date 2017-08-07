[TestClass]
    public class ArrayProblemTest
    {
        [TestMethod]
        public void TestMagicIndex()
        {
            ArrayProblems arr = new ArrayProblems();
            var result = arr.MagicIndex(new int[] { -1, 0, 1, 2, 3, 5, 8, 10, 12, 13, 14, 15 });
            Assert.AreEqual(5, result);
        }
    }

    /* A magic index in an array A[0…n - 1] is defined to be an index such that A[i] = i.
         * Given a sorted array of distinct integers, 
         * write a method to find a magic index if one exists, in an array A.
         * FOLLOW UP: What if the values are not distinct?
         * 
         * Solution : 1) I have decide to use Binary Search instead of Liner Search here. O(logn)
             */
         public int MagicIndex(int [] inputs)
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
[TestClass]
    public class ArrayProblemTest
    {
        [TestMethod]
        public void TestSearchElement()
        {
            ArrayProblems arr = new ArrayProblems();
            var result = arr.SearchElement1(new int[] { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 }, 3);
            Assert.AreEqual(7, result);

            result = arr.SearchElement1(new int[] { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 }, 2);
            Assert.AreEqual(8, result);
        }
    }


// Solution 1 : 
// 1) i am going to iterate to all the elements in the array . O(n)
// 2) If i found the element i am checking for the condition , whether it element before this element and after this element is lesser than one.
// 3) i am returing the first poistion of this element
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

                    if(Math.Abs(inputs[i-1] - item)==1 && Math.Abs(inputs[i + 1] - item) == 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApplication.BST;

namespace TestConsoleApplication
{
    public class Program4
    {
        static void Main(string[] args)
        {
            FindDuplicateCharacters("parag");
            Dictionary<int, string> input = new Dictionary<int, string>();
            input.Add(1, "A"); input.Add(2, "B"); input.Add(3, "C"); input.Add(4, "D"); input.Add(5, "E");
            Dictionary<int, string> input1 = new Dictionary<int, string>();
            input1.Add(4, "A1"); input1.Add(2, "BC"); input1.Add(5, "CD"); input1.Add(40, "D1"); input1.Add(6, "E1");
            CompareData(input, input1);
            var resultString = isPalindrome("ParagTgaraP");
            var resultint = isPalindrome(1235321);
            var resultfib = countLength(0123);
            var noOfK = numberOfKsBetween0AndN(2, 20);
            ReverseString("garap");
            Console.WriteLine(noOfK);
            pyramidNumber(10);
            FibSeq(10);
            int[] arr = { 10, 58, 14, 24, 74, 54, 36, 5, 3, 15,2,1 };
            int[] arr1 = { 10, 58, 14, 24, 74, 54, 36, 5, 3, 15, 2, 1 };
            Intersection(arr, arr1);
            QuickSort(arr, 0,arr.Length - 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            GetMedian(arr1);
            List list = new List();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");

            list.ListNodes();
            Console.WriteLine("Position 5: " + list.Retrieve(5).NodeContent);
            Console.WriteLine();

            Console.ReadLine();
            /// vsr test = countLength1();
            Tree BST = new Tree();
            BST.Insert(30);
            BST.Insert(35);
            BST.Insert(57);
            BST.Insert(15);
            BST.Insert(63);
            BST.Insert(49);
            BST.Insert(89);
            BST.Insert(77);
            BST.Insert(67);
            BST.Insert(98);
            BST.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            BST.InOrder(BST.ReturnNode());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            BST.PreOrder(BST.ReturnNode());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            BST.PostOrder(BST.ReturnNode());
            Console.WriteLine(" ");
            Console.ReadLine();



            
        }

        public static bool isPalindrome(string input)
        {
            int inputLength = input.Length;
            for (int i = 0; i < inputLength / 2; i++)
            {
                if (input[i] != input[inputLength - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isPalindrome(int input)
        {
            int reversed = 0, n = input;

            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n =n/ 10;
            }

            return input == reversed;
        }

        public static int  countLength(int n)
        {
           return (int)Math.Floor(Math.Log10(n)) + 1;
        }


        public int countLength1(int n)
        {
            return (int)Math.Floor(Math.Log10(n)) + 1;
        }

        public static int numberOfKsBetween0AndN(int n, int k)
        {

            int result = 0; // initialize result

            // One by one compute sum of digits in every number from
            // 1 to n
            for (int x = 1; x <= n; x++)
            {
                var result1 = has4(x,k) ? 1 : 0;
                result += result1;
            }

            return result;
        }

        public static bool has4(int x, int k)
        {
            while (x != 0)
            {
                if (x % 10 == k)
                    return true;
                x = x / 10;
            }

            return false;
        }


        //int countNumbersWith4(int n)
        //{
        //    // Base case
        //    if (n < 4)
        //        return 0;

        //    // d = number of digits minus one in n. For 328, d is 2
        //    double d = Math.Log10(n);

        //    // computing count of numbers from 1 to 10^d-1,
        //    // d=0 a[0] = 0;
        //    // d=1 a[1] = count of numbers from 0 to 9 = 1
        //    // d=2 a[2] = count of numbers from 0 to 99 = a[1]*9 + 10 = 19
        //    // d=3 a[3] = count of numbers from 0 to 999 = a[2]*19 + 100 = 171
        //    double a = new int[d + 1];
        //    a[0] = 0, a[1] = 1;
        //    for (int i = 2; i <= d; i++)
        //        a[i] = a[i - 1] * 9 + ceil(pow(10, i - 1));

        //    // Computing 10^d
        //    int p = ceil(pow(10, d));

        //    // Most significant digit (msd) of n,
        //    // For 328, msd is 3 which can be obtained using 328/100
        //    int msd = n / p;

        //    // If MSD is 4. For example if n = 428, then count of
        //    // numbers is sum of following.
        //    // 1) Count of numbers from 1 to 399
        //    // 2) Count of numbers from 400 to 428 which is 29.
        //    if (msd == 4)
        //        return (msd) * a[d] + (n % p) + 1;

        //    // IF MSD > 4. For example if n is 728, then count of
        //    // numbers is sum of following.
        //    // 1) Count of numbers from 1 to 399 and count of numbers
        //    //    from 500 to 699, i.e., "a[2] * 6"
        //    // 2) Count of numbers from 400 to 499, i.e. 100
        //    // 3) Count of numbers from 700 to 728, recur for 28
        //    if (msd > 4)
        //        return (msd - 1) * a[d] + p + countNumbersWith4(n % p);

        //    // IF MSD < 4. For example if n is 328, then count of
        //    // numbers is sum of following.
        //    // 1) Count of numbers from 1 to 299 a
        //    // 2) Count of numbers from 300 to 328, recur for 28
        //    return (msd) * a[d] + countNumbersWith4(n % p);
        //}

        public static void pyramidNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= (n-i); s++)
                {
                    Console.Write(" ");
                }
                for (int no = 1; no <= i; no++)
                {
                    Console.Write(no);
                }
                for (int number = (i-1); number >= 1; number--)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }

        public static void FibSeq(int n)
        {
            List<long> returnLong = new List<long>();
            int secondNumber = 1;
            int firstNumber = 0;
            int calculatedValue = 0;
            for (int i = 0; i < n; i++)
            {
                calculatedValue = firstNumber + secondNumber;
                returnLong.Add(calculatedValue);
                firstNumber = secondNumber;
                secondNumber = calculatedValue;
            }
            foreach (var item in returnLong)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetMedian(int [] arr)
        {
            int length = arr.Length;
            if (length%2==0)
            {
               QuickSort(arr, 0, arr.Length - 1);
                int median = arr[(((arr.Length / 2) - 1 )+ ((arr.Length  / 2) + 1)) /2];
            }
            else
            {
                QuickSort(arr, 0, arr.Length - 1);
                int median = arr[arr.Length / 2];

            }
        }

        public static void QuickSort(int [] arr,int left,int right)
        {
            if (left<right)
            {
                int p = Partition(arr, left, right);
                if (p>1)
                {
                    QuickSort(arr, left, p);
                }

                if (p+1 <right)
                {
                    QuickSort(arr, p+1, right);
                }
            }
        }

        public static int Partition(int [] arr , int left,int right)
        {
            int p = arr[left];
            
            while (true)
            {
                int l = arr[left];
                int r = arr[right];
                while (arr[left]<p)
                {
                    left++;
                }
                while (arr[right]>p)
                {
                    right--;
                }

                if (left<right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void Intersection(int[]n,int[]m)
        {
            int nlen = n.Length;
            int mlen = m.Length;
            int i = 0;
            int j = 0;
            while (i<nlen && j<mlen)
            {
                if (n[i] < m[j])
                    i++;
                else if (m[j] < n[i])
                    j++;
                else
                {
                    Console.WriteLine(m[j++]);
                    i++;
                }
            }
        }

        public static void ReverseString(string str)
        {
            //with temp
            char[] c = str.ToCharArray();
            Console.WriteLine(str);
            for (int i = 0, j= c.Length-1; i < j; i++,j--)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
            }
            Console.WriteLine(new string(c));

            //without temp
            char[] c1 = str.ToCharArray();
            Console.WriteLine(str);
            for (int i = 0,j=str.Length-1; i < j; i++,j--)
            {
                c1[i] = str[j];
                c1[j]= str[i];
            }
            Console.WriteLine(new string(c1));

        }

        public  static string stringReverseString2(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }

        public static void CompareData (Dictionary<int,string> inputs, Dictionary<int, string> inputs1)
        {
            List<string> result = new List<string>();

            foreach (var input in inputs)
            {
                foreach (var input1 in inputs1)
                {
                    if (input.Key < input1.Key)
                    {
                        result.Add(input.Value);
                        break;
                    }
                    if (input.Key == input1.Key)
                    {
                        result.Add(input.Value);
                        result.Add(input1.Value);
                        break;
                    }
                    else
                    {
                        result.Add(input1.Value);
                        break;
                    }
                }
            }
        }

        public static Dictionary<char,int> FindDuplicateCharacters(string orgstring)
        {
            char[] charArray = orgstring.ToCharArray();
            Dictionary<char, int> returnValue = new Dictionary<char, int>();
            foreach (char c in charArray)
            {
                if(!returnValue.Any())
                {
                    returnValue.Add(c, 1);
                }
                else
                {
                    if (returnValue.ContainsKey(c))
                    {
                        returnValue[c] = returnValue[c] + 1;
                    }
                    else
                    {
                        returnValue.Add(c, 1);
                    }
                }
            }
            foreach (var item in returnValue)
            {
                
                Console.WriteLine(item.Key + "    ===>>>   " + item.Value);
                if (item.Value>1)
                {

                    Console.WriteLine("Duplicate Values are : "+item.Key + "    ===>>>   " + item.Value);
                }
            }
            
            char[] outBuffer = new char[returnValue.Count];
            int ixOut = 0;
            //remove duplicate 
            foreach (var item in returnValue)
            {
                if (item.Value == 1)
                {
                    outBuffer[ixOut++] = item.Key;
                }
            }
            Console.WriteLine("word is : "+ new string(outBuffer,0, ixOut));
            return null;
        }

    }
}

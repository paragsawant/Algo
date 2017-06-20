using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Array_LeftRotation
    {
        static void Start(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            StringBuilder sb = new StringBuilder();

            for (int i = k; i < n; i++)
            {
                sb.Append(a[i].ToString());
                sb.Append(" ");
            }
            for (int j = 0; j < k; j++)
            {
                sb.Append(a[j].ToString());
                sb.Append(" ");
            }
            Console.Write(sb.ToString().Trim());
        }
    }
}

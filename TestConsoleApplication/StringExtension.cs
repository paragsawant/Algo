using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    public static class StringExtension
    {
        public static int WordCount(this string input)
        {
            return input.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string LogError(this string input)
        {
            return "Exception : "+input;
        }
    }
}

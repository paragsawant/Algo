using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterviewTopics
{
    public class ReverseWords
    {
        public string Reverse(string s)
        {
            Stack<string> stack = new Stack<string>();
            s.Trim();
            s = s.Contains("  ") ? s.Replace("  ", " ") : s;
            foreach (var word in s.Split(' '))
            {
                stack.Push(word);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count!=0)
            {
                sb.Append(stack.Pop() + " ");
            }

            return sb.ToString(); 
        }
    }
}

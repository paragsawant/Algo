using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class Node
    {
        public Node left;
        public Node right;
        public int data;

        public void DisplayNode()
        {
            Console.Write(data + " ");
        }
    }
}

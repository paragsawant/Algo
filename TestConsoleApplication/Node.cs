using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
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

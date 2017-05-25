using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
   public  class List
    {
        public class Node
        {
            public object NodeContent;
            public Node Next;
        }

        private int size;
        public int Count
        {
            get
            {
                return size;
            }
        }
        public Node current;
        public Node head;
        public List()
        {
            size = 0;
            head = null;
        }

        public void ListNodes()
        {
            Node temp = head;
            while (temp!=null)
            {
                Console.WriteLine(temp.NodeContent);
                temp = temp.Next;
            }
        }

        public Node Retrieve(int Position)
        {
            Node tempNode = head;
            Node retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    retNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }

            return retNode;
        }

        public void Add(object content)
        {
            size++;
            var node = new Node { NodeContent = content };
            if (head==null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }
    }
}

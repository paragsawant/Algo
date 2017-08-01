using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

        public Node ReturnNode()
        {
            return root;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                Node parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    if (i < currentNode.data)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void PreOrder(Node root)
        {
            if(root!=null)
            {
                Console.WriteLine(root.data + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.data + " ");
                InOrder(root.right);
            }
        }
        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.data + " ");
            }
        }
    }
}

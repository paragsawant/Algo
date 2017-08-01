using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication.BST
{
    public class BST
    {
        public Node root;

        public BST()
        {
            root = null;
        }

        public void InsertNode(int i)
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
                Node parentNode = null;
                while (true)
                {
                    parentNode = currentNode;
                    if (i<currentNode.data)
                    {
                        currentNode = currentNode.left;
                        if (currentNode==null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if(currentNode==null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
    }
}

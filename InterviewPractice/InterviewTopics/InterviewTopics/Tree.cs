using System;

namespace InterviewTopics
{
    public class Tree
    {
        public TreeNode root;
        public Tree()
        {
            root = null;
        }

        public TreeNode ReturnNode()
        {
            return root;
        }

        public void Insert(int i)
        {
            TreeNode newNode = new TreeNode();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                TreeNode currentNode = root;
                TreeNode parentNode;
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

        public void PreOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }
        public void InOrder(TreeNode root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.data + " ");
                InOrder(root.right);
            }
        }
        public void PostOrder(TreeNode root)
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

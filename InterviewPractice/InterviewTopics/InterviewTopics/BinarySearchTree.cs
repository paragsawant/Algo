using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class BinarySearchTree
    {
        public int GetMax(TreeNode root)
        {
            TreeNode currentNode = root;
            while (root.right!=null)
            {
                currentNode = root.right;
            }

            return currentNode.data;
        }

        public int GetMin(TreeNode root)
        {
            TreeNode currentNode = root;
            while (root.left != null)
            {
                currentNode = root.left;
            }

            return currentNode.data;
        }
    }
}

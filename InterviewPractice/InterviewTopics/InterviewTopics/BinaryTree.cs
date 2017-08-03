﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class BinaryTree
    {
        TreeNode root;
        static bool n1b1;
        static bool n2b2;
        TreeNode FindLCA(int n1,int n2)
        {
            n1b1 = false;
            n2b2 = false;
            TreeNode lca= FindLCA(root, n1, n2);

            if (n1b1 && n2b2)
                return lca;

            return null;
        }

        TreeNode FindLCA(TreeNode node, int n1, int n2)
        {
            if (node == null)
                return null;

            if (node.data == n1)
                {
                n1b1 = true;
                return node;

            }
            if (node.data == n2)
            {
                n2b2 = true;
                return node;
            }

            TreeNode left_lca = FindLCA(node.left, n1, n2);
            TreeNode right_rca = FindLCA(node.right, n1, n2);

            if (left_lca !=null && right_rca!=null)
            {
                return node;
            }

            return left_lca != null ? left_lca : right_rca;
        }
    }
}
//http://www.geeksforgeeks.org/maximum-element-two-nodes-bst/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication.BST
{
    public static class GlobalMembers
    {
        // Create and return a pointer of new Node.
        public static Node createNode(int x)
        {
            Node p = new Node();
            p.data = x;
            p.left = p.right = null;
            return p;
        }

        // Insert a new Node in Binary Search Tree.
        public static void insertNode(Node root, int x)
        {
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to variables (in C#, the variable no longer points to the original when the original variable is re-assigned):
            //ORIGINAL LINE: Node *p = root, *q = null;
            Node p = root;
            Node q = null;

            while (p != null)
            {
                //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to variables (in C#, the variable no longer points to the original when the original variable is re-assigned):
                //ORIGINAL LINE: q = p;
                q = p;
                if (p.data < x)
                {
                    p = p.right;
                }
                else
                {
                    p = p.left;
                }
            }

            if (q == null)
            {
                p = createNode(x);
            }
            else
            {
                if (q.data < x)
                {
                    q.right = createNode(x);
                }
                else
                {
                    q.left = createNode(x);
                }
            }
        }

        // Return the maximum element between a Node
        // and its given ancestor.
        public static int maxelpath(Node q, int x)
        {
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to variables (in C#, the variable no longer points to the original when the original variable is re-assigned):
            //ORIGINAL LINE: Node *p = q;
            Node p = q;

            int mx = int.MinValue;

            // Traversing the path between ansector and
            // Node and finding maximum element.
            while (p.data != x)
            {
                if (p.data > x)
                {
                    mx = Math.Max(mx, p.data);
                    p = p.left;
                }
                else
                {
                    mx = Math.Max(mx, p.data);
                    p = p.right;
                }
            }

            return Math.Max(mx, x);
        }

        // Return maximum element in the path between
        // two given Node of BST.
        public static int maximumElement(Node root, int x, int y)
        {
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to variables (in C#, the variable no longer points to the original when the original variable is re-assigned):
            //ORIGINAL LINE: Node *p = root;
            Node p = root;

            // Finding the LCA of Node x and Node y
            while ((x < p.data && y < p.data) || (x > p.data && y > p.data))
            {
                // Checking if both the Node lie on the
                // left side of the parent p.
                if (x < p.data && y < p.data)
                {
                    p = p.left;
                }

                // Checking if both the Node lie on the
                // right side of the parent p.
                else if (x > p.data && y > p.data)
                {
                    p = p.right;
                }
            }

            // Return the maximum of maximum elements occur
            // in path from ancestor to both Node.
            return Math.Max(maxelpath(p, x), maxelpath(p, y));
        }


        // Driven Program
        static int Start()
        {
            int[] arr = { 18, 36, 9, 6, 12, 10, 1, 8 };
            int a = 1;
            int b = 10;
            //C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
            //ORIGINAL LINE: int n = sizeof(arr)/sizeof(arr[0]);
            int n = arr.Length;

            // Creating the root of Binary Search Tree
            Node root = createNode(arr[0]);

            // Inserting Nodes in Binary Search Tree
            for (int i = 1; i < n; i++)
            {
                insertNode(root, arr[i]);
            }

            Console.Write(maximumElement(root, a, b));
            Console.Write("\n");

            return 0;
        }
        //http://www.geeksforgeeks.org/write-a-c-program-to-find-the-maximum-depth-or-height-of-a-tree/
        static int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.left);
                int rDepth = maxDepth(node.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else return (rDepth + 1);
            }
        }

        //http://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/
        //static bool isBST(Node node)
        //{
        //    if (node == null)
        //        return true;

        //    /* false if left is > than node */
        //    if (node.left != null && node.left.data > node.data)
        //        return false;

        //    /* false if right is < than node */
        //    if (node.right != null && node.right.data < node.data)
        //        return false;

        //    /* false if, recursively, the left or right is not a BST */
        //    if (!isBST(node.left) || !isBST(node.right))
        //        return false;

        //    /* passing all that, it's a BST */
        //    return true;
        //}



        /* Returns true if the given tree is a binary search tree 
         (efficient version). */
        static bool isBST(Node node)
        {
            return (isBSTUtil(node, int.MinValue, int.MaxValue));
        }

        /* Returns true if the given tree is a BST and its 
           values are >= min and <= max. */
        static bool isBSTUtil(Node node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
                return true;

            /* false if this node violates the min/max constraint */
            if (node.data < min || node.data > max)
                return false;

            /* otherwise check the subtrees recursively, 
             tightening the min or max constraint */
            return
              (isBSTUtil(node.left, min, node.data - 1) &&  // Allow only distinct values
              isBSTUtil(node.right, node.data + 1, max));  // Allow only distinct values
        }
    }
}

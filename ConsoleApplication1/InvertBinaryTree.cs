using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class InvertBinaryTree
    {

        private TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            if (root.left != null)
                InvertTree(root.left);
            if (root.right != null)
                InvertTree(root.right);
            return root;

        }
    }

    public class TreeNode
    {
        public TreeNode left = null;
        public TreeNode right = null;
        public int value = default;
        public TreeNode(TreeNode node)
        {
            left = node.left;
            right = node.right;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class NodeDepths
    {
        public static int FindNodeDepths(BinaryTree root)
        {
            return sumNodeDepths(root, 0);
        }

        public static int sumNodeDepths(BinaryTree? root, int nodeDepths)
        {
            if (root == null)
            {
                return 0;
            }
            var node = root;

            return nodeDepths + sumNodeDepths(node.left, nodeDepths + 1) + sumNodeDepths(node.right, nodeDepths + 1);
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree? left;
            public BinaryTree? right;

            public BinaryTree(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
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

        public static List<int> BranchSums(BinaryTree root)
        {
            var sums = new List<int>();
            calculateBranchSums(root, 0, sums);
            return sums;
        }

        public static void calculateBranchSums(BinaryTree? root, int runningSum, List<int> sums)
        {
            if (root == null)
            {
                return;
            }
            var currentNode = root;

            var finalRunningSum = runningSum + currentNode.value;
            if (currentNode.right == null && currentNode.left == null)
            {
                sums.Add(finalRunningSum);
                return;
            }

            calculateBranchSums(currentNode.left, finalRunningSum, sums);
            calculateBranchSums(currentNode.right, finalRunningSum, sums);
        }
    }

}
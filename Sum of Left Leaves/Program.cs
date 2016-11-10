//https://leetcode.com/problems/sum-of-left-leaves/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Left_Leaves
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            Console.WriteLine("SumOfLeftLeaves=" + SumOfLeftLeaves(root));

            Console.Read();
        }

        static int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;

            if (root == null)
            {
                return 0;
            }
            
            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                {
                    sum += root.left.val;
                }
                else
                {
                    sum += SumOfLeftLeaves(root.left);
                }
            }

            if (root.right != null)
            {
                sum += SumOfLeftLeaves(root.right);
            }
            
            return sum;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static TreeNode treenodeGen(int[] nums)
        {
            TreeNode root = new TreeNode(nums[0]);
            
            return root;
        }
    }
}

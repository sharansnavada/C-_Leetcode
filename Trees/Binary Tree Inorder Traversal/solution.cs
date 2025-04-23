/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;

        while (current != null || stack.Count > 0) {
            // Traverse to the leftmost node
            while (current != null) {
                stack.Push(current);
                current = current.left;
            }

            // Visit the node
            current = stack.Pop();
            result.Add(current.val);

            // Go to the right subtree
            current = current.right;
        }

        return result;
    }
}

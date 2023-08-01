/*
Prompt: 
"You are given the root of a binary tree that consists of exactly 3 nodes: the root, its left child, and its right child.
Return true if the value of the root is equal to the sum of the values of its two children, or false otherwise."

Constraints:
The tree consists only of the root, its left child, and its right child.
-100 <= Node.val <= 100

Robert Colburn
8/1/2023
*/

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
    public bool CheckTree(TreeNode root) {
        if(root.val == (root.left.val + root.right.val))
        return true;
        return false;
    }
}

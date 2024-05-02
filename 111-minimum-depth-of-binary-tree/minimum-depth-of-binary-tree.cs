public class Solution {
    public int MinDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        if (root.left == null) {
            return 1 + MinDepth(root.right);
        }
        if (root.right == null) {
            return 1 + MinDepth(root.left);
        }
        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}

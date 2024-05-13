public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int l = MaxDepth(root.left);
        int r = MaxDepth(root.right);
        return 1 + Math.Max(l, r);
    }
}

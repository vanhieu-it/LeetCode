public class Solution {
    public bool IsBalanced(TreeNode root) {
        return Height(root) >= 0;
    }
    
    private int Height(TreeNode root) {
        if (root == null) {
            return 0;
        }
        
        int leftHeight = Height(root.left);
        int rightHeight = Height(root.right);
        
        if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1) {
            return -1;
        }
        
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}

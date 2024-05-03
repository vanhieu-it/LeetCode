public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        Dfs(root);
        return root;
    }
    
    private void Dfs(TreeNode root) {
        if (root == null) {
            return;
        }
        
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        Dfs(root.left);
        Dfs(root.right);
    }
}

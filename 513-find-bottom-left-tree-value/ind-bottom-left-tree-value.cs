public class Solution {
    public int FindBottomLeftValue(TreeNode root) {
        int answer = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count != 0) {
            answer = q.Peek().val;
            for (int i = q.Count; i > 0; --i) {
                TreeNode node = q.Dequeue();
                if (node.left != null) {
                    q.Enqueue(node.left);
                }
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
        }
        return answer;
    }
}

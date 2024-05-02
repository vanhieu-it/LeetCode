using System;
using System.Collections.Generic;

public class Solution {
    public bool IsEvenOddTree(TreeNode root) {
        bool even = true;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0) {
            int prev = even ? 0 : 100000000;
            int size = q.Count;
            for (int i = 0; i < size; ++i) {
                root = q.Dequeue();
                if (even && (root.val % 2 == 0 || prev >= root.val)) {
                    return false;
                }
                if (!even && (root.val % 2 == 1 || prev <= root.val)) {
                    return false;
                }
                prev = root.val;
                if (root.left != null) {
                    q.Enqueue(root.left);
                }
                if (root.right != null) {
                    q.Enqueue(root.right);
                }
            }
            even = !even;
        }
        return true;
    }
}

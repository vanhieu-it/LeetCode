/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNodes(ListNode head) {
        ListNode dummy = new ListNode(1 << 30);
        dummy.next = head;
        Stack<ListNode> stk = new Stack<ListNode>();
        stk.Push(dummy);
        for (ListNode cur = head; cur != null; cur = cur.next) {
            while (stk.Peek().val < cur.val) {
                stk.Pop();
            }
            stk.Peek().next = cur;
            stk.Push(cur);
        }
        return dummy.next;
    }
}
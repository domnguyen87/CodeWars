// Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.

// Input: l1 = [1,2,4], l2 = [1,3,4]
// Output: [1,1,2,3,4,4]

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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        ListNode dummy  = new ListNode(-1);
        ListNode head = dummy;

        while (l1 != null || l2 != null)
        {
            if((l1 != null && l2 == null) || (l1 != null && l2 != null && l1.val < l2.cal))
            {
                ListNode curr = new ListNode(l1.val);
                head.next = curr;
                l1 = l1.next;
            }
            else
            {
                ListNode curr = new ListNode(l2.val);
                head.next = curr;
                l2 = l2.next;
            }
            head=head.next;
        }

        return dummy.next;
    }
}
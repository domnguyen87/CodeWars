// Merge two sorted linked lists and return it as a new list.The new list should be made by splicing together the nodes of the first two lists.
// Example:
// Input: 1->2->4, 1->3->4
// Output: 1->1->2->3->4->4

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        ListNode result;

        if(l1.val < l2.val) {
            result = l1;
            result.next = MergeTwoLists(l1.next, l2);
        } else {
            result = l2;
            result.next = MergeTwoLists(l1, l2.next);
        }

        return result;
    }
}
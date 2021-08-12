// Given the head of a linked list, rotate the list to the right by k places.

// Input: head = [1,2,3,4,5], k = 2
// Output: [4,5,1,2,3]

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
    public ListNode RotateRight(ListNode head, int k) {
        
        //no rotation needed
        if( k == 0 || head = null || head.next == null)
        {
            return head;
        }

        ListNode temp = head;

        // Count length
        int length = 0;
        while( temp != null)
        {
            temp = temp.next;
            length++;
        }

        // count index of the new head
        int index = length - k % length;

        //no rotation needed
        if(index == length)
        {
            return head;
        }

        //find new tail head
        ListNode newTail = head;
        for(int i = 0; i < index - 1; i++)
        {
            newTail = newTail.next;
        }

        
    }
}
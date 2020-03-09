/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int[] Add(ListNode l1, ListNode l2, int carry) {
        int[] result = new int[2]; // Addition, Carry-Over
        int n1 = 0, n2 = 0;
        if (l1 != null) {
            n1 = l1.val;
        }
        if (l2 != null) {
            n2 = l2.val;
        }
        result[0] = n1 + n2 + carry;
        result[1] = 0;
        if (result[0] > 9) { // Check if addition has a carry-over
            result[1] = (int)Math.Floor((double)(result[0]/10));
            result[0] = result[0]%10;
        }
        return result;
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode firstResultNode = null;
        ListNode currentResultNode = new ListNode(); // Initialize
        ListNode currentNode1 = l1, currentNode2 = l2;
        int carry = 0;
        int currentIndex = 0;
        // Check that either node1 or node2 exist or the carry over exists
        while (currentNode1 != null || currentNode2 != null || carry > 0) {
            int[] currentAdd = Add(currentNode1, currentNode2, carry);
            currentResultNode.val = currentAdd[0];
            if (currentIndex == 0) {
                firstResultNode = currentResultNode;
            }
            carry = currentAdd[1];
            if (currentNode1 != null) {
                currentNode1 = currentNode1.next;
            }
            if (currentNode2 != null) {
                currentNode2 = currentNode2.next;
            }
            if (currentNode1 != null || currentNode2 != null || carry > 0) {
                currentResultNode.next = new ListNode();
            }
            currentResultNode = currentResultNode.next;
            currentIndex++;
        }
        
        return firstResultNode;
    }
}
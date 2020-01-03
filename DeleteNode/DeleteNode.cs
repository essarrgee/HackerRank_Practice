

    // Complete the deleteNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {

        SinglyLinkedListNode currentNode = head;

        if (position == 0) {
            head = currentNode.next;
            return head;
        }

        for (int i=0; i<position; i++) {
            if (position > 0 && i == position - 1) {
                if (currentNode.next != null){
                    currentNode.next = currentNode.next.next;
                    return head;
                }
            }
            currentNode = currentNode.next;
        }

        return head;
    }


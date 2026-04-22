namespace LeetCode75.LinkedList;

public class DeleteTheMiddleNodeOfALinkedList
{
    //beats 100%
    public static ListNode DeleteMiddle(ListNode? head) {
        if (head == null || head.next   == null)
            return null;

        var slow = head;
        var fast = head;
        ListNode prev = null;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = slow.next;

        return head;
    }
    //beats 45%
    public static ListNode? DeleteMiddleFirstTry(ListNode? head)
    {
        if (head is null || head.next is null)
            return null;

        var length = Length(head);
        var middleIndex = length / 2;

        var current = head;
        ListNode? prev = null;

        for (int i = 0; i < middleIndex; i++)
        {
            prev = current;
            current = current!.next;
        }

        // delete middle
        prev!.next = current!.next;

        return head;
    }

    public static int Length(ListNode? head)
    {
        var count = 0;
        while (head != null)
        {
            count++;
            head = head.next;
        }

        return count;
    }
}

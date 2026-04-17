namespace LeetCode75.LinkedList;

public class OddEven
{
    private const int Two = 2;
    private const int Zero = 0;

    //beats 100%
    public static ListNode OddEvenList(ListNode head)
    {
        if (head == null)
            return null;

        ListNode odds = null;
        ListNode evens = null;

        ListNode oddsTail = null;
        ListNode evensTail = null;
        var current = head;
        var currentPosition = 1;

        while (current != null)
        {
            var next = current.next;
            var isEven = currentPosition % Two == Zero;

            if (isEven)
            {
                if (evens is null)
                {
                    evens = current;
                    evensTail = current;
                }
                else
                {
                    evensTail.next = current;
                    evensTail = evensTail.next;
                }
            }
            else
            {
                if (odds is null)
                {
                    odds = current;
                    oddsTail = current;
                }
                else
                {
                    oddsTail.next = current;
                    oddsTail = oddsTail.next;
                }
            }

            current = next;
            currentPosition++;
        }
        if (evensTail is not null)
            evensTail.next = null;
        if (oddsTail != null)
            oddsTail.next = evens;
        return odds;
    }
}

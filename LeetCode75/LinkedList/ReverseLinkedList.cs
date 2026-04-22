namespace LeetCode75.LinkedList;

public class ReverseLinkedList
{
  public static ListNode ReverseList(ListNode head)
  {
    var current = head;
    ListNode prev = null;
    while(current != null)
    {
      var next = current.next;
      current.next = prev;

      prev = current;
      current = next;
      
    }
    return prev;
  }
}

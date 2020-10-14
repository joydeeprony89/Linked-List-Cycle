using System;

namespace Linked_List_Cycle
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    ListNode temp = head;
                    while (temp != fast)
                    {
                        temp = temp.next;
                        fast = fast.next;
                    }
                    return fast;
                }
            }
            return null;
        }
    }
}

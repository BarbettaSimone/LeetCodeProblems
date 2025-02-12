using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next; 
        }
    }

    internal class LeetCodeSolution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int rest = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (l1.val + l2.val + rest > 9)
                {
                    result.val = l1.val + l2.val + rest - 10;
                    rest = 1;
                }
                else
                {
                    result.val = l1.val + l2.val + rest;
                    rest = 0;
                }
                if (l1.next == null && l2.next == null)
                {
                    if (rest > 0)
                    {
                        result.next = new ListNode();
                        result = result.next;
                        result.val = rest;
                        rest = 0;
                    }
                    break;
                }
                result.next = new ListNode();
                result = result.next;
                l1 = evaluateNext(l1);
                l2 = evaluateNext(l2);
            }
            return head;
        }

        private ListNode evaluateNext(ListNode ls)
        {
            if (ls.next == null)
            {
                ls.val = 0;
            }
            else
            {
                ls = ls.next;
            }
            return ls;
        }
    }
    public static class Converter
    {
        public static ListNode ConvertArrayToListNode(int[] arr)
        {
            // Create the head node
            ListNode head = new ListNode(arr[0]);
            ListNode current = head;

            // Iterate over the remaining array elements and link them
            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);  // Create a new node with the current value
                current = current.next;  // Move the pointer to the new node
            }

            return head;  // Return the head of the linked list
        }

        public static int[] ConvertListNodeToArray(ListNode head)
        {
            // Count the number of nodes in the linked list
            int length = 0;
            ListNode current = head;
            while (current != null)
            {
                length++;
                current = current.next;
            }

            // Create an array with the size of the linked list
            int[] result = new int[length];

            // Fill the array with values from the linked list
            current = head;
            for (int i = 0; i < length; i++)
            {
                result[i] = current.val;  // Assign the current node's value to the array
                current = current.next;   // Move to the next node
            }

            return result;  // Return the populated array
        }
    }
}

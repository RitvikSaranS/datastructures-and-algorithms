using System;
using System.Collections.Generic;
using System.Text;
using DSA_Helper.Arsenal;
using static DSA_Helper.Arsenal.LinkedList;

namespace DSA_Helper.Problems.Linked_List
{
    class E_ReverseLL
    {
        LinkedList ll;
        Node HEAD;
        public E_ReverseLL(int[] arr)
        {
            ll = new LinkedList(arr);
            HEAD = ll.GetHeadNode();
        }
        public void Reverse()
        {
            Node previous = null;
            Node current = HEAD;
            Node next = current.next;
            while(next != null)
            {
                current.next = previous;
                previous = current;
                current = next;
                next = next.next;
            }
            current.next = previous;
            ll.SetHeadNode(current);
            ll.PrintLinkedList();
        }
    }
}

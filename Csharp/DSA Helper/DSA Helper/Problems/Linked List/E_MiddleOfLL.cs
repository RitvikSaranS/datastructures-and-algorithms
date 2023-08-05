using DSA_Helper.Arsenal;
using System;
using System.Text;
using static DSA_Helper.Arsenal.LinkedList;

namespace DSA_Helper.Problems.Linked_List
{
    class E_MiddleOfLL
    {
        LinkedList ll;
        Node HEAD;
        public E_MiddleOfLL(int[] arr)
        {
            ll = new LinkedList(arr);
            HEAD = ll.GetHeadNode();
        }
        public void FindMiddleOfLL()
        {
            Node slow = HEAD;
            Node fast = HEAD;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.PrintNode();
        }
    }
}

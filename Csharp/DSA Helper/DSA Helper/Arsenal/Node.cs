using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Arsenal
{
    public class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            next = null;
        }
        public void PrintNode()
        {
            Console.WriteLine(value);
        }
    }
}

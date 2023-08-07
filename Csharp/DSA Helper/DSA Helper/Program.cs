using DSA_Helper.Problems.Basics;
using DSA_Helper.Problems.Arrays;
using DSA_Helper.Problems.Dynamic_Programming;
using System;
using DSA_Helper.Problems.RoughWork;
using DSA_Helper.Arsenal;
using DSA_Helper.Problems.Linked_List;
using System.Collections.Generic;

namespace DSA_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList(new int[] { 1, 2, 3 });
            Stack s1 = new Stack(ll.GetHeadNode());
            Stack s2 = new Stack(new List<int> { 1, 2, 3 });
            s1.PrintStack();
            s2.PrintStack();
            s1.Pop();
            s2.Pop();
            s1.PrintStack();
            s2.PrintStack();
            Console.Read();
        } 
    }
}
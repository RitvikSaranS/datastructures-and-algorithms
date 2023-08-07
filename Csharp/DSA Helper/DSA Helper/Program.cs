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
            LinkedList ll = new LinkedList(new int[] { 1,2,4 });
            Stack s = new Stack(ll.GetHeadNode());
            //s.Push(5);
            s.Pop();
            s.PrintStack();
            Console.Read();
        } 
    }
}
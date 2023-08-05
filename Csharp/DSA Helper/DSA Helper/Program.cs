using DSA_Helper.Problems.Basics;
using DSA_Helper.Problems.Arrays;
using DSA_Helper.Problems.Dynamic_Programming;
using System;
using DSA_Helper.Problems.RoughWork;
using DSA_Helper.Arsenal;
using DSA_Helper.Problems.Linked_List;

namespace DSA_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            E_ReverseLL l = new E_ReverseLL(new int[]{ 1, 2, 3, 4 });
            l.Reverse();
            Console.Read();
        } 
    }
}
using System;
using DSA_Helper.Arsenal;
using DSA_Helper.Problems.Basics;
using DSA_Helper.Problems.Arrays;
using DSA_Helper.Problems.Dynamic_Programming;
using DSA_Helper.Problems.Linked_List;
using System.Collections.Generic;
using DSA_Helper.Problems.Strings;

namespace DSA_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            H_NextSmallestPalindrome h = new H_NextSmallestPalindrome("23545");
            h.findNextSmallestPalindrome();
            Console.Read();
        } 
    }
}
﻿using DSA_Helper.Problems.Basics;
using DSA_Helper.Problems.Arrays;
using DSA_Helper.Problems.Dynamic_Programming;
using System;

namespace DSA_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            M_MajorityElement2 m = new M_MajorityElement2(new int[] { 2, 1, 1, 3, 1, 4, 5, 6 });
            m.FindMajority();
            Console.Read();
        } 
    }
}
using DSA_Helper.Problems.Basics;
using DSA_Helper.Problems.Arrays;
using DSA_Helper.Problems.Dynamic_Programming;
using System;

namespace DSA_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            E_ClimbingStairs c = new E_ClimbingStairs(6);
            c.CountJumps_Recursive();
            c.CountJumps_Iterative();
            Console.Read();
        }
    }
}

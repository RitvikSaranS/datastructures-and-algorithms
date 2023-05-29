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
            E_GeekJump e = new E_GeekJump(new int[] {  });
            e.MinimumEnergy_Recursive();
            e.MinimumEnergy_Best();
            Console.Read();
        }
    }
}

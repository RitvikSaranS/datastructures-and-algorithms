using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/combination-sum-ii/
    class M_CombinationSum2
    {
        int[] candidates;
        List<int> potential = new List<int>();
        public M_CombinationSum2(int[] candidates)
        {
            this.candidates = candidates;
        }
        public void CombinationSum(int target)
        {
            Array.Sort(candidates);
            Console.WriteLine();
            void helper(int ind)
            {
                if (target < 0) return;
                if (target == 0)
                {
                    printList(potential);
                    return;
                }

                if (ind >= candidates.Length) return;
                for (int i = ind; i < candidates.Length; i++)
                {
                    if (i > ind && candidates[i] == candidates[i - 1])
                    {
                        continue;
                    }
                    target -= candidates[i];
                    potential.Add(candidates[i]);
                    helper(i + 1);
                    target += candidates[i];
                    potential.Remove(candidates[i]);
                }
            }
            helper(0);
        }
        public void printList(List<int> potential)
        {
            potential.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}

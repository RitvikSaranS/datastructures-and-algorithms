using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    /*
     nCr / nC(r+1) => (n - r - 1)! * (r + 1)! / (n - r)! * r!
     nC(r + 1) = (n - r)/r * nCr
    */
    // https://leetcode.com/problems/pascals-triangle/
    class E_PascalTriangle
    {
        int rows;
        public E_PascalTriangle(int rows)
        {
            this.rows = rows;
        }
        public void PascalTriange()
        {
            List<List<int>> ps = new List<List<int>>();
            for(int j = 1; j <= rows; j++)
            {
                List<int> ls = new List<int>();
                ls.Add(1);
                int last = 1;
                for(int i = 1; i < j; i++)
                {
                    last = last * (j - i) / i;
                    ls.Add(last);
                }
                ps.Add(ls);
            }
            for(int i = 0; i < ps.Count; i++)
            {
                for(int j = 0; j < ps[i].Count; j++)
                {
                    Console.Write(ps[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/set-matrix-zeroes/
    class M_SetMatrixZeroes
    {
        int[][] matrix;
        public M_SetMatrixZeroes(int[][] matrix)
        {
            this.matrix = matrix;
        }
        public void SetZeroes()
        {
            bool row0 = false;
            bool col0 = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if(i == 0)
                        {
                            row0 = true;
                        }if(j == 0)
                        {
                            col0 = true;
                        }
                        if(i == 0 && j == 0)
                        {
                            row0 = true;
                            col0 = true;
                        }
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }
            for(int i = 1; i < matrix[0].Length; i++)
            {
                if(matrix[0][i] == 0)
                {
                    for(int j = 0; j < matrix.Length; j++)
                    {
                        matrix[j][i] = 0;
                    }
                }
                if (matrix[0][i] != 0 && row0)
                {
                    matrix[0][i] = 0;
                }
            }
            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
                if (matrix[i][0] != 0 && col0)
                {
                    matrix[i][0] = 0;
                }
            }
            if (row0 && col0) matrix[0][0] = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                } 
                Console.WriteLine();
            }
        }
    }
}

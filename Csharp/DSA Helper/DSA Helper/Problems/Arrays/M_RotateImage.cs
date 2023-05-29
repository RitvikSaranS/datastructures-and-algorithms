using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class M_RotateImage
    {
        int[][] matrix;
        public M_RotateImage(int[][] matrix)
        {
            this.matrix = matrix;
        }
        public void Rotate()
        {
            Transpose();
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Reverse(matrix[i]);
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Transpose()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix[i].Length; j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = tmp;
                }
            }
        }
    }
}

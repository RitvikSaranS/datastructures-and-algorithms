using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Strings
{
    // https://www.interviewbit.com/problems/next-smallest-palindrome/
    class H_NextSmallestPalindrome
    {
        private StringBuilder A { get; set; }
        public H_NextSmallestPalindrome(string sample)
        {
            A = new StringBuilder(sample);
        }
        public void findNextSmallestPalindrome()
        {
            if (checkPalindrome(A)) A = AddOne(A, A.Length - 1, 0);
            int n = A.Length;
            for (int i = n - 1, j = 0; i >= n / 2 && j < i; i--, j++)
            {
                int num1 = A[i] - '0';
                int num2 = A[j] - '0';
                bool flag = false;
                if (num1 > num2) flag = true;
                A[i] = A[j];
                if (flag) AddOne(A, i - 1, j);
            }
            Console.WriteLine(A);
        }
        public bool checkPalindrome(StringBuilder A)
        {
            for (int i = 0, j = A.Length - 1; i <= j; i++, j--) if (A[i] != A[j]) return false;
            return true;
        }
        public StringBuilder AddOne(StringBuilder A, int i, int j)
        {
            bool carry = true;
            for (int k = i; k >= 0; k--)
            {
                if (carry == true)
                {
                    if (A[k] == '9')
                    {
                        carry = true;
                        A[k] = '0';
                        if (k == 0) A.Insert(0, '1');
                    }
                    else
                    {
                        A[k] = ((A[k] - '0') + 1).ToString()[0];
                        carry = false;
                    }
                    if (k <= j && (i + j - k + 1) < A.Length) A[i + j - k + 1] = A[k];
                }
                else break;
            }
            return A;
        }
    }
}

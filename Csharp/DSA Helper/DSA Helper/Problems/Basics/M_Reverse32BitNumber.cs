using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Basics
{
    // https://leetcode.com/problems/reverse-integer
    class M_Reverse32BitNumber
    {
        int x;
        public M_Reverse32BitNumber(int x)
        {
            this.x = x;
        }
        public int reverse()
        {
            int num = 0;
            while (x != 0)
            {
                int increment = x % 10;
                if (x % 10 < 0)
                {
                    if(helper(num, true))
                    {
                        return 0;
                    }else if(Int32.MinValue - num * 10 > increment)
                    {
                        return 0;
                    }
                }
                else if (x % 10 > 0)
                {
                    if(helper(num, false))
                    {
                        return 0;
                    }
                    else if(Int32.MaxValue - num * 10 < increment)
                    {
                        return 0;
                    }
                }
                num = num * 10 + increment;
                x /= 10;
            }
            return num;
        }
        public bool helper(int num, bool check)
        {
            int tmp = 0;
            for (int i = 0; i < 10; i++)
            {
                if (check && Int32.MinValue - num > tmp)
                {
                    return true;
                }
                else if (!check && Int32.MaxValue - num < tmp)
                {
                    return true;
                }
                tmp += num;
            }
            return false;
        }
    }
}

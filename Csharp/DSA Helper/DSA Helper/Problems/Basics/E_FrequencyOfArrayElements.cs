using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Basics
{
    class E_FrequencyOfArrayElements
    {
        Hashtable ht;
        int[] nums;
        public E_FrequencyOfArrayElements(int[] nums)
        {
            this.nums = nums;
            ht = new Hashtable();
        }
        public void findFrequencyOf()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                {
                    ht.Add(nums[i], 1);
                }
                else
                {
                    ht[nums[i]] = (int)ht[nums[i]] + 1;
                }
            }
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + "  " + entry.Value);
            }
        }
    }
}

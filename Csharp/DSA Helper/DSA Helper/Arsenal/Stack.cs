using System;
using System.Collections.Generic;
using System.Text;
using static DSA_Helper.Arsenal.LinkedList;

namespace DSA_Helper.Arsenal
{
    class Stack
    {
        int count;
        Node HEAD;
        LinkedList ll = null;
        List<int> arrList = null;
        public Stack()
        {
            arrList = new List<int>();
            count = arrList.Count;
        }
        public Stack(List<int> arrList)
        {
            this.arrList = new List<int>(arrList);
            count = arrList.Count;
        }
        public Stack(Node HEAD)
        {
            ll = new LinkedList();
            ll.SetHeadNode(HEAD);
            this.HEAD = ll.Reverse();
            SetCount();
        }
        public void Push(int value)
        {
            if(HEAD == null)
            {
                arrList.Add(value);
                count++;
            }else
            {
                Node newNode = new Node(value);
                newNode.next = HEAD;
                HEAD = newNode;
                count++;
            }
        }
        public int? Pop()
        {
            if(HEAD == null)
            {
                if (count == 0)
                {
                    Console.WriteLine("The stack is empty");
                    return null;
                }else
                {
                    int value = arrList[count - 1];
                    arrList.RemoveAt(count - 1);
                    count--;
                    Console.WriteLine($"{value} popped");
                    return value;
                }
            }else
            {
                if(HEAD == null)
                {
                    Console.WriteLine("The stack is empty");
                    return null;
                }
                else
                {
                    int value = HEAD.value;
                    HEAD = HEAD.next;
                    count--;
                    Console.WriteLine($"{value} popped");
                    return value;
                }
            }
        }
        public int? Peek()
        {
            if(HEAD == null)
            {
                if(count != 0)
                {
                    Console.WriteLine(arrList[count - 1]);
                    return arrList[count - 1];
                }else
                {
                    Console.WriteLine("The stack is empty");
                    return null;
                }
            }else
            {
                if(HEAD != null)
                {
                    Console.WriteLine(HEAD.value);
                    return HEAD.value;
                }else
                {
                    Console.WriteLine("The stack is empty");
                    return null;
                }
            }
        }
        public void SetCount()
        {
            count = 0;
            if(HEAD != null)
            {
                Node tmp = HEAD;
                while(tmp != null)
                {
                    count++;
                    tmp = tmp.next;
                }
            }
        }
        public void PrintStack()
        {
            if(HEAD == null)
            {
                if(count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write($"{arrList[i]} ");
                    }
                }
                else Console.Write("null ");
                Console.WriteLine("<- HEAD");
            }
            else
            {

                Console.Write("HEAD ->");
                if (HEAD != null)
                {
                    Node tmp = HEAD;
                    while (tmp != null)
                    {
                        Console.Write($" {tmp.value}");
                        tmp = tmp.next;
                    }
                    Console.WriteLine();
                }
                else Console.WriteLine(" null");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Arsenal
{
    public class LinkedList
    {
        public Node HEAD;
        public LinkedList()
        {
            HEAD = null;
        }
        public LinkedList(int[] arr)
        {
            HEAD = null;
            for (int i = 0; i < arr.Length; i++)
            {
                AddNode(arr[i], "last");
            }
        }
        public void AddNode(int value, dynamic position)
        {
            Node NewNode = new Node(value);
            if (HEAD == null)
            {
                HEAD = NewNode;
                return;
            }
            if (position.GetType() == typeof(string))
            {
                if (position.ToLower().Trim() == "first")
                {
                    NewNode.next = HEAD;
                    HEAD = NewNode;
                }
                else if (position.ToLower().Trim() == "last")
                {
                    GetLastNode().next = NewNode;
                }
                else
                {
                    Console.WriteLine("Enter a valid position. first, last or zero based index");
                }
            }
            else
            {
                int count = 0;
                Node tmp = HEAD;
                Node prev = null;
                while (count < position)
                {
                    if (tmp == null)
                    {
                        Console.WriteLine("Enter a valid zero based index position to add");
                        return;
                    }
                    count++;
                    prev = tmp;
                    tmp = tmp.next;
                }
                NewNode.next = tmp;
                if (prev == null)
                {
                    HEAD = NewNode;
                }
                else prev.next = NewNode;
            }
        }
        public void RemoveNode(dynamic position)
        {
            if (HEAD == null)
            {
                Console.WriteLine("There is no Nodes to delete");
                return;
            }
            else if (position.GetType() == typeof(string))
            {
                if (position == "first")
                {
                    HEAD = HEAD.next;
                }
                else if(position == "last")
                {
                    Node tmp = HEAD;
                    Node prev = null;
                    while (tmp.next != null)
                    {
                        prev = tmp;
                        tmp = tmp.next;
                    }
                    if (prev == null) HEAD = null;
                    else prev.next = tmp.next;
                } else Console.WriteLine("Enter a valid position. first, last or zero based index");
            }
            else
            {
                int count = 0;
                Node tmp = HEAD;
                Node prev = null;
                while (count < position)
                {
                    if (tmp == null)
                    {
                        Console.WriteLine("Enter a valid zero based index position to remove");
                        return;
                    }
                    count++;
                    prev = tmp;
                    tmp = tmp.next;
                }
                if (prev == null) HEAD = null;
                else prev.next = tmp.next;
            }
        }
        public Node GetLastNode()
        {
            if(HEAD == null)
            {
                Console.WriteLine("Linked List is Empty");
                return HEAD;
            }
            Node tmp = HEAD;
            while (tmp.next != null) tmp = tmp.next;
            return tmp;
        }
        public Node GetHeadNode()
        {
            return HEAD;
        }
        public void SetHeadNode(Node node)
        {
            HEAD = node;
        }
        public Node Reverse()
        {
            if (HEAD == null) return null;
            Node previous = null;
            Node current = HEAD;
            Node next = current.next;
            while (next != null)
            {
                current.next = previous;
                previous = current;
                current = next;
                next = next.next;
            }
            current.next = previous;
            return current;
        }
        public void PrintLinkedList()
        {
            Node tmp = HEAD;
            Console.Write("HEAD -> ");
            while (tmp != null)
            {
                Console.Write($"{tmp.value} -> ");
                tmp = tmp.next;
            }
            Console.WriteLine("null");
        }
    }
}

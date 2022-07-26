﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueue
{
    public class LinkedList
    {
        Node head;
       

        public void add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

       public int pop()
        {
            int deleted = head.data;
            head = head.next;
            return deleted;
        }


        void RemoveLast()
        {
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }


        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }


        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public int peek()
        {
            return head.data;
        }

        public int size()
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    public class LinkedList
    {
        internal Node head;
        internal Node tail;

        internal void Add(int data) //element addition 
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Append(int data)
        {
            Add(data);
            Console.WriteLine("{0} node Appended", data);
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted value is " + head);
            return head;
        }

        internal void Pop()    //delete head 56
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty , delete is not possible");
                return;
            }

            Console.WriteLine("Value popped is {0}", this.head.data);
            this.head = this.head.next;
        }

        internal Node PopLast(Node popLast)
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("list is already empty, there is nothing to delete");
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            //checking for tail Node.
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int PopLast = newNode.next.data;
            newNode.next = null;
            Console.WriteLine("node deleted at Last position is " + PopLast);
            return popLast;
        }

        public int SearchNode(int value) //find node with value 30
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\nthe node is found : " + value);
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("{0} is not a Linked List Node", value);
            return 0;
        }
    }
}
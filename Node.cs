using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    public class Node
    {
        public int data;         // elements added here
        public Node next;        // next element address stored here

        public Node()
        {
        }

        public Node(int data)
        {
            this.data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structure
{
    internal class Stack
    {
        public Node head {  get; set; }

        public int Count { get; set; }

        public Stack(Node head)
        {
            this.head = null;
            this.Count = 0;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public void push(int node)
        {
            Node? newNode = new Node(node);
            if (head == null)
            {
                head = newNode;
            }
            newNode.setNext(head); 
        }

        public void pop()
        {
            if (IsEmpty())
            {
                return;
            }
            head = head.getNext();
        }

        public int Peek()
        {

        }



        //public int Count()
        //{
        //    return c
        //}

    }
}

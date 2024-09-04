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

        public int count { get; set; }

        public Stack(Node head)
        {
            this.head = null;
            this.count = 0;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public void push(int data)
        {
            Node? newNode = new Node(data);
            if (head != null)
                newNode.setNext(head); 
            head = newNode;
            count++;
        }

        public int pop()
        {
        if (IsEmpty())
            {
                return -1;
            }
        int node = head.getValue();
        head = head.getNext();
        count--;
        return node;

        }

        public int? Peak()
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                return head.getValue();
            }
        }

        public int Count()
        {
            return count;
        }

        //public string Display()
        //{
        //    return "";
        //}

        

    }
}

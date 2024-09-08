using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Structure
{
    public class Queue
    {
        public Node Head {  get; set; }
        public Node Tail { get; set; }

        public int count { get; set; }

        public Queue(Node head, Node tail)
        {
            this.Head = null;
            this.Tail = null;
        }

        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.setNext(newNode);
                Tail = newNode;
            }
            count++;
        }

        public int? Dequeue()
        {
            int node = Head.getValue();
            if (IsEmpty())
            {
                return null;
            }
            Head = Head.getNext();
            count--;
            if (Head == null)
            {
                Tail = null;
            }
            return node;
        }

        public int? Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return Head.getValue();
        }

        public int Count()
        {
            return count;
        }

        public string Display()
        {
            if (IsEmpty())
            {
                return "";
            }
            Node node = Head.getNext();
            string result = Head.getValue().ToString();
            while (Tail != Head)
            {
                result += " -> " + node.getValue().ToString();
                node = node.getNext();
            }
            return result;

        }
       

    }
}

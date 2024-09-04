using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Dequeue()
        {
            int node = Head.getValue();
            if (IsEmpty())
            {
                return -1;
            }
            Head = Head.getNext();
            
            count--;
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
       

    }
}

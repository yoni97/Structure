using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure;



namespace Structure
{
    public class CircularDubleLinkedList
    {

        public DoubleNode Head;
        public int Count;

        public CircularDubleLinkedList()
        {
            Head = null;
            Count = 0;
        }


        public void AddLast(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                DoubleNode Tail = Head.Prev;
                Tail.Next = newNode;
                newNode.Prev = Tail;
                newNode.Next = Head;
                Head.Prev = newNode;
            }
            Count++;
        }

        // next to try alone:
        // display 
        public void Display(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            if (Head == null)
            {
                return;
            }


        }
        // remove (value)
        // remove (index)
        // find
        // addAfterIndex
    }
}

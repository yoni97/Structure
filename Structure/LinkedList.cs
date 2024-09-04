using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Structure
{
    public class Node
    {
        private int Value;
        private Node Next;

        public Node(int data)
        {
            Value = data;
            Next = null;
        }

        public int getValue() { return Value; }
        public Node getNext() { return Next; }

        public void setValue(int value) { Value = value; }
        public void setNext(Node next) { Next = next; }
    }


    public class LinkedList
    {
        public Node? Head;

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(Node data)
        {
            Head = data;
        }

        // Method to add to  the end of the list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // if head not null
            Node nodeHead = Head;
            while (nodeHead.getNext() != null)
            {
                nodeHead = nodeHead.getNext();
            }
            nodeHead.setNext(newNode);
            return;
        }


        public string Display()
        {
            if (Head == null)
                return "";

            Node node = Head.getNext();
            string result = Head.getValue().ToString();
            while (node != null)
            {
                result += " -> " + node.getValue().ToString();
                node = node.getNext();
            }
            return result;
        }

        public int Length()
        {
            if (Head == null)
                return 0;

            int count = 1;
            Node node = Head.getNext();
            while (node != null)
            {
                count++;
                node = node.getNext();
            }
            return count;
        }
        

            
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if (Head == null)
            { 
                return;
            }
            Node node = Head;
            
            while (node.getNext() != null)
            {
                if (node.getNext().getValue() == data)
                {
                    node.setNext(node.getNext().getNext());
                    return;
                }
                node = node.getNext();
            }
        }

        public void removeValue(int value)
        {
            if (Head != null)
            {
                if (Head.getValue() == value)
                {
                    Head = Head.getNext();
                    return;
                }
                Node tmp = Head;
                while (tmp.getNext() != null)
                {
                    if (tmp.getNext().getValue() == value)
                    {
                        tmp.setNext(tmp.getNext().getNext());
                        return;
                    }
                    tmp = tmp.getNext();

                }
            }

        }


        // Method to remove the first value


        public void RemoveAllValues(int value)
        {
            if (Head == null)
            {
                return ;
            }
            while (Head != null && Head.getValue() == value)
            {
                Head = Head.getNext();
            }
            if (Head == null)
            {
                return;
            }
        }


        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            if (Head == null)
            { return; }

            int count = 0;
            Node node = Head;
            while (node.getNext() != null)
            {
                if (count == index)
                {
                    //Node temp = node.getNext().;
                    node.setNext(node.getNext().getNext());
                    return;
                }
                count++;
               // node = node.getNext();
            }
        }

        // Method to find by value
        public int Find(int data)
        {
            if (Head == null)
            { return -1; }

            int count = 1;
            Node node = Head;
            while (node.getNext() != null)
            {
                if (node.getNext().getValue() == data)
                {
                    return count;
                }
                count++;
                node = node.getNext();
            }
            return -1;
        }

        // Method to get a value by  index
        

        public int Get(int index)
        {
            Node temp = Head;
            for (int i = 0; i < index; i++)
            {
                if (temp == null)
                {
                    return -1;
                }
                temp = temp.getNext();
            }
            if (temp == null)
            {
                return -1;
            }
            return temp.getValue();
        }
    }
}











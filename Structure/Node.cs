using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Structure
{
    internal class Node
    {
        public LinkedList _data;
        public Node(int data)
        {
            this.Value = data;
            this.Next = null;
        }

        private int Value;
        private Node Next;

        public int GetValue(int value)   // property
        {
            return Value;    // get method
        }

        public void SetValue(int value) 
        {
            this.Value = value; 
        }

        public Node GetNext(Node next)
        {
            return Next;
        }

        public void SetNext(Node next)
        {
            this.Next = null;   // set method
        }    
    }
}


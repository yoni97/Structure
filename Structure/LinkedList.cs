using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Structure
{
    internal class LinkedList
    {

        public Node head;

        public LinkedList()
        {

        }

        public LinkedList(int data)
        {

        }

        // Method to add to  the end of the list
        public void Add(int data)
        {
            Node head = new Node(data);
            //Node temp = head.GetNext(); 
            while (head.GetNext != null)
            {
                head = head.GetNext();
            }

        }


        public String Display()
        {
            1-> 2-> 5-> - 5-> 5
        }

        public int Length()

        // Method to remove the first value
        public void RemoveValue(int data)
        {

        }

        // Method to remove all the values from the list
        public void RemoveAllValues(int data)
        {

        }

        // Method to remove the value in an index
        public void RemoveIndex(int data)
        {

        }

        // Method to find by value and return index
        public int Find(data)
        {

        }

        // Method to get a value by  index and return the value
        public int Get(data)
        {

        }
    }


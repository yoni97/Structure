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

        public Queue(Node head, Node tail)
        {
            this.Head = null;
            this.Tail = null;
        }


    }
}

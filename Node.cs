using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Node
    {
        public int data;
        public Node next;

        //constructor
        public Node(int item)
        {
            data = item;
            next = null;
        }
    }
}

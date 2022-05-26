using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queues
    {
        public Node top;

        public Queues()
        {
            top = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                Node temptop = top;
                while (temptop.next != null)
                {
                    temptop = temptop.next;
                }
                temptop.next = newNode;
            }
            Console.WriteLine(newNode.data + " is inserted into the queue");
        }
        public void Dequeue()
        {
            if (top == null)
            {
                Console.WriteLine("\nCan't dequeue on a empty queue");
                return;
            }
            else
            {
                Console.WriteLine("\n" + top.data + " is deleted from the queue --> dequeue operation");
                top = top.next;
            }
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Console.WriteLine("\nQueue Layout \n");
            Node tempNode = top;
            while (tempNode != null)
            {
                Console.WriteLine("|_ " + tempNode.data + " _|");
                tempNode = tempNode.next;
            }
            Console.WriteLine();
        }
    }
}

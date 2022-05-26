using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stacks
    {
        public Node top;

        public Stacks()
        {
            top = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(newNode.data + " is inserted into the stack");
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("\nCan't peek on a empty stack");
                return;
            }
            Console.WriteLine(top.data+" is at the top of the stack --> peek operation ");
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nCan't pop on a empty stack");
                return;
            }
            Console.WriteLine("\n"+top.data + " is deleted from the stack --> pop operation ");
            top = top.next;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is empty");
                return;
            }
            Console.WriteLine("\nStack Layout \n");
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

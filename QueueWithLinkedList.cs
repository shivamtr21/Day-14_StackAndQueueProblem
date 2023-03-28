using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueWithLinkedList
    {
        public Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} inserted into Queue");
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty,Dequeue is not possible.");
                return;
            }
            while (head != null)
            {
                Console.WriteLine($"Value dequeue is {head.data}");
                head = head.next;
            }
        }
    }
}

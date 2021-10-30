using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDS
{
    class QueueOperations
    {

        Node head;

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(int data)
        {
            Node new_node = new Node(data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new_node;
            }
            Console.WriteLine("value is inserted" + new_node.data);
        }

        /// <summary>
        /// Dequeues the elements form Queue.
        /// </summary>
        public void Dequeue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("no elements present ");
                return;
            }
            this.head = temp.next;
            temp = null;

        }



        /// <summary>
        /// Displays this queue values.
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}

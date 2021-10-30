using System;

namespace QueueDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueOperations queue = new QueueOperations();
            queue.Enqueue(50);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("the Queue list is:");
            queue.Display();
            queue.Dequeue();
            Console.WriteLine("the Deueue list is:");
            queue.Display();
        }
    }
}

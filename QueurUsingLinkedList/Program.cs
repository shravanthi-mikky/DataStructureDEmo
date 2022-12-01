using System;

namespace QueurUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueUsingLList linkedListQueue = new QueueUsingLList();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}

using System;

namespace StackUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            StackUsingLL linkedListStack = new StackUsingLL();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            //linkedListStack.Peek(); top.data
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            Console.ReadKey();
        }
    }
}
